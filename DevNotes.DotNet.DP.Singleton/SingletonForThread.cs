namespace DevNotes.DotNet.DP.Singleton
{
    /// <summary>
    /// 线程安全的单体模式
    /// </summary>
    public class SingletonForThread
    {
        /// <summary>
        /// 单体实例
        /// </summary>
        private static SingletonForThread _instance;
        /// <summary>
        /// 线程安全锁
        /// </summary>
        private static object _lock = new object();

        /// <summary>
        /// 构造函数
        /// </summary>
        private SingletonForThread()
        {
        }

        /// <summary>
        /// 获取流程实例
        /// </summary>
        /// <returns></returns>
        public static SingletonForThread GetInstance()
        {
            //双重锁方式较好地解决了多线程下的单例模式实现
            if (null == _instance)
            {
                lock (_lock)
                {
                    if (null == _instance)
                    {
                        _instance = new SingletonForThread();
                    }
                }
            }
            return _instance;
        }
    }
}
