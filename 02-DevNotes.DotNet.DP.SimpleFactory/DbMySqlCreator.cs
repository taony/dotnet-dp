using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevNotes.DotNet.DP.SimpleFactory
{
    /// <summary>
    /// MySql实现
    /// </summary>
    public class DbMySqlCreator : IDbCreator
    {
        /// <summary>
        /// 实现MySql创建方法
        /// </summary>
        public void Create()
        {
            Console.WriteLine("Creator By MySql");
        }
    }
}
