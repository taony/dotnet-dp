using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevNotes.DotNet.DP.Singleton
{
    /// <summary>
    /// 单体模式一
    /// </summary>
    public class Singleton
    {
        private static Singleton _instance = null;

        public static Singleton CreateInstance()
        {
            return _instance ?? (_instance = new Singleton());
        }
    }
}
