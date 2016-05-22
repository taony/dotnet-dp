using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevNotes.DotNet.DP.SimpleFactory.UnitTest
{
    [TestClass]
    public class ClientUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IDbCreator creator = null;
            string[] arrDbTypes = new string[] {
                    "SqlServer","Oracle","MySql"
            };

            foreach (var dbType in arrDbTypes)
            {
                creator = DbFactory.GetCreator(dbType);
                if (null != creator)
                {
                    creator.Create();
                }
            }

        }
    }
}
