using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevNotes.DotNet.DP.Singleton
{
    public class SingletonForSimple
    {
        private SingletonForSimple()
        {
        }

        public static readonly SingletonForSimple instance = new SingletonForSimple();
    }
}
