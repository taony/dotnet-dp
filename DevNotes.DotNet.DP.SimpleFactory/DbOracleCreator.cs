using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevNotes.DotNet.DP.SimpleFactory
{
    /// <summary>
    /// Oracle 实现
    /// </summary>
    public class DbOracleCreator : IDbCreator
    {
        /// <summary>
        /// 实现Oracle创建方法
        /// </summary>
        public void Create()
        {
            Console.WriteLine("Creat By Oracle ");
        }
    }
}
