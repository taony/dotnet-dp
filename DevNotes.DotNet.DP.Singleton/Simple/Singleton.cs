namespace DevNotes.DotNet.DP.Singleton.Simple
{
    public class Singleton
    {
        private Singleton()
        {
        }

        public static readonly Singleton instance = new Singleton();
    }
}
