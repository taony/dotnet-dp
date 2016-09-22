namespace DevNotes.DotNet.DP.Singleton.Thread
{
    /// <summary>
    /// 线程安全的单体模式
    /// </summary>
    public class Singleton
    {
        /// <summary>
        /// 单体实例
        /// </summary>
        private static Singleton _instance;
        /// <summary>
        /// 线程安全锁
        /// </summary>
        private static object _lock = new object();

        /// <summary>
        /// 构造函数
        /// </summary>
        private Singleton() { }

        /// <summary>
        /// 获取流程实例
        /// </summary>
        /// <returns>实例</returns>
        public static Singleton GetInstance()
        {
            //双重锁方式较好地解决了多线程下的单例模式实现
            if (null == _instance)
            {
                //加锁
                lock (_lock)
                {
                    if (null == _instance)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }
    }
}
