using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevNotes.DotNet.DP.SimpleFactory
{
    /// <summary>
    /// SqlServer实现 
    /// </summary>
    public class DbSqlServerCreator : IDbCreator
    {
        /// <summary>
        /// SqlServer创建方法
        /// </summary>
        public void Create()
        {
            Console.WriteLine("Create By Sqlserver");
        }
    }
}
