using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevNotes.DotNet.DP.SimpleFactory
{
    /// <summary>
    /// 创建工厂方法
    /// </summary>
    public class DbFactory
    {
        /// <summary>
        /// 工厂方法获得创建对象接口实现
        /// </summary>
        /// <param name="dbType"></param>
        /// <returns></returns>
        public static IDbCreator GetCreator(string dbType)
        {
            if (!string.IsNullOrEmpty(dbType))
            {
                switch (dbType.ToLower())
                {
                    case "sqlserver":
                        return new DbSqlServerCreator();
                    case "oracle":
                        return new DbOracleCreator();
                    case "mysql":
                        return new DbMySqlCreator();
                }
            }

            Console.WriteLine("NULL DB TYPE VALUE! ");
            return null;
        }
    }
}
