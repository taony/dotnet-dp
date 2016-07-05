using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevNotes.DotNet.DP.AbstractFactory.Factory;

namespace DevNotes.DotNet.DP.AbstractFactory
{
    public class Client
    {
        public static void Main(string[] args)
        {
            IntelFactory factory=new IntelFactory();
            ComputerBuilder builder=new ComputerBuilder(factory);
            builder.Build(factory);
        }
    }
}
