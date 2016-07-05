using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevNotes.DotNet.DP.AbstractFactory.Products;
using DevNotes.DotNet.DP.AbstractFactory.Products.Amd;

namespace DevNotes.DotNet.DP.AbstractFactory.Factory
{
    public class AmdFactory : AbstractFactory
    {
        public override AbstractCpu CreateCpu()
        {
            return new AmdCpu();
        }

        public override AbstractMainboard CreateMainboard()
        {
            return new AmdMainboard();
        }
    }
}
