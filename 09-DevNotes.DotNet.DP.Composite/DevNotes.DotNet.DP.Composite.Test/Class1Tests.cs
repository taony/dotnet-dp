using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevNotes.DotNet.DP.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevNotes.DotNet.DP.Composite.Test
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void PrintTest()
        {
           Class1 clazz=new Class1();
            clazz.Print();
        }
    }
}