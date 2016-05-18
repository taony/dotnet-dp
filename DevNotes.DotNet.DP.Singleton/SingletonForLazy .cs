namespace DevNotes.DotNet.DP.Singleton
{
    /// <summary>
    /// 延迟实例化的单体模式
    /// </summary>
    public class SingletonForLazy
    {
        //初始暂不实例化
        private static SingletonForLazy _instance = null;

        //私有的构造子(构造器,构造函数,构造方法)
        private SingletonForLazy() { }

        //静态的工厂方法，需要使用时才去创建该单体
        public static SingletonForLazy GetInstance()
        {
            return _instance ?? (_instance = new SingletonForLazy());
        }
    }
}
