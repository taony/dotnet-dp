using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevNotes.DotNet.DP.AbstractFactory.Products;
using DevNotes.DotNet.DP.AbstractFactory.Products.Intel;

namespace DevNotes.DotNet.DP.AbstractFactory.Factory
{
    public class IntelFactory : AbstractFactory
    {
        public override AbstractCpu CreateCpu()
        {
            return new IntelCpu();
        }

        public override AbstractMainboard CreateMainboard()
        {
            return new IntelMainboard();
        }
    }
}
