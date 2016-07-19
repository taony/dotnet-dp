namespace DevNotes.DotNet.DP.Singleton.Simple
{
    /// <summary>
    /// 简化版的单体模式（非线程安全）
    /// </summary>
    public class Singleton
    {
        /// <summary>
        /// 默认构造函数
        /// </summary>
        private Singleton() {  }

        /// <summary>
        /// 静态实例
        /// </summary>
        public static readonly Singleton instance = new Singleton();
    }
}
