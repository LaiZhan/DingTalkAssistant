using System;
using System.Diagnostics;
using System.Threading;
using Top.Api;
using Top.Api.Domain;
using Top.Api.Request;

namespace Top.Tmc
{
    public class TmcApiClient
    {
        private ITopClient _topClient;

        private readonly string _appkey;

        private readonly string _appSecret;

        private readonly string _groupName;

        /**
         * 每次调用api拉取的消息数量
         */
        private int _quality;

        /**
         * 得到消息为空时，下次拉取的等待间隔
         * 每次消费得到的消息为空时, 至少暂停1s再去执行下一次循环拉消息
         */
        private int _duration;

        private volatile bool _running;

        public event EventHandler<MessageArgs> OnMessage;

        /**
         * 循环拉取消息线程数量
         */
        private int _pullRequestThreads;

        private bool EnableTraceLog { get; set; }

        private ITopLogger Logger { get; set; }

        public int Quality
        {
            get => _quality;
            set => _quality = Math.Max(1, value);
        }

        public int Duration
        {
            get => _duration;
            set => _duration = Math.Max(1, value);
        }

        public int PullRequestThreads
        {
            get => _pullRequestThreads;
            set => _pullRequestThreads = Math.Max(1, value);
        }

        public TmcApiClient(string appkey, string appSecret, string groupName)
        {
            Logger = Log.Instance;
            _appkey = appkey;
            _appSecret = appSecret;
            _groupName = groupName;
            _quality = 20;
            _duration = 5;
            _pullRequestThreads = 1;
            _running = false;
            _topClient = null;
        }

        public void Connect(string uri)
        {
            Console.WriteLine("TmcApiClient Start");
            _topClient = new DefaultTopClient(uri, _appkey, _appSecret, "json");
            _running = true;
            for (var i = 0; i < _pullRequestThreads; i++)
            {
                var thread = new Thread(o =>
                {
                    while (_running)
                    {
                        try
                        {
                            var req = new TmcMessagesConsumeRequest
                            {
                                GroupName = _groupName,
                                Quantity = _quality
                            };
                            var sw = new Stopwatch();
                            sw.Start();
                            var rsp = _topClient.Execute(req);
                            sw.Stop();
                            Console.WriteLine("request time: " + sw.ElapsedMilliseconds);
                            if (rsp == null || rsp.Messages == null || rsp.Messages.Count < 1)
                            {
                                Console.WriteLine("wait...");
                                Thread.Sleep(new TimeSpan(0, 0, _duration));
                            }
                            else
                            {
                                Console.WriteLine(rsp.Messages.Count);
                                foreach (var msg in rsp.Messages)
                                {
                                    HandleMessage(msg);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Logger.Warn($"pull message exception, error: {ex}");
                        }
                    }
                })
                {
                    IsBackground = true,
                    Name = $"TmcApiClient PullRequestThread-{i}"
                };
                Console.WriteLine(thread.Name + " start");
                thread.Start();
                Thread.Sleep(2000);
            }
        }

        private static Message ConvertToMsg(TmcMessage tmcMsg)
        {
            var msg = new Message
            {
                Id = tmcMsg.Id,
                Topic = tmcMsg.Topic,
                PubAppKey = tmcMsg.PubAppKey,
                PubTime = Convert.ToDateTime(tmcMsg.PubTime),
                UserId = tmcMsg.UserId,
                UserNick = tmcMsg.UserNick,
                Content = tmcMsg.Content
            };
            return msg;
        }

        private void HandleMessage(TmcMessage msg)
        {
            if (OnMessage == null)
            {
                return;
            }

            ThreadPool.QueueUserWorkItem(o =>
            {
                if (!_running)
                {
                    Logger.Info($"message dropped as client closed: {msg}");
                    return;
                }

                var args = new MessageArgs(ConvertToMsg(msg), m => this.Confirm(m.Id));
                var sw = new Stopwatch();
                try
                {
                    sw.Start();
                    OnMessage(this, args);
                    sw.Stop();
                }
                catch (Exception e)
                {
                    args.Fail(e.Message);
                }

                if (args._isFail)
                {
                    Logger.Info("process message error: {0}", args._reason);
                    // 不执行确认

                    return;
                }

                // prevent confirm attach
                if (sw.ElapsedMilliseconds <= 1)
                {
                    Thread.Sleep(10);
                }

                if (args._isConfirmed)
                {
                    return;
                }

                try
                {
                    Confirm(msg.Id);

                    if (EnableTraceLog)
                    {
                        Logger.Info("confirm message topic: {0}, id: {1}", msg.Topic, msg.Id);
                    }
                }
                catch (Exception e)
                {
                    Logger.Warn($"confirm message {msg} error {e.StackTrace}");
                }
            });
        }

        private void Confirm(long id)
        {
            var cReq = new TmcMessagesConfirmRequest
            {
                GroupName = _groupName,
                SMessageIds = id.ToString()
            };
            _topClient.Execute(cReq);
        }

        public void Close()
        {
            _running = false;
            Console.WriteLine("TmcApiClient Stop");
        }
    }
}