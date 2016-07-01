using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevNotes.DotNet.DP.AbstractFactory.Products;

namespace DevNotes.DotNet.DP.AbstractFactory
{
    public class ComputerBuilder
    {
        public AbstractCpu cpu;
        public AbstractMainboard mainboard;
        private AbstractFactory factory;

        public ComputerBuilder(AbstractFactory factory)
        {

        }

        public void Build(AbstractFactory factory)
        {
            cpu = factory.CreateCpu();
            mainboard = factory.CreateMainboard();

            cpu.Print();
            mainboard.Print();

            Console.ReadLine();
        }
    }
}
