namespace DevNotes.DotNet.DP.Singleton
{
    /// <summary>
    /// 单体模式一
    /// </summary>
    public class Singleton
    {
        //私有，静态实例
        private static Singleton _instance = null;

        //私有构造函数
        private Singleton()
        {

        }

        //静态工厂方法
        public static Singleton CreateInstance()
        {
            return _instance ?? (_instance = new Singleton());
        }
    }
}
