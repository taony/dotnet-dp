using System;

namespace DevNotes.DotNet.FactoryMethod
{
    public class Client
    {
        public static void Main(string[] args)
        {
            Creator creator = new ConcreteCreator();
            Product product = creator.GetProduct();
            if (null != product)
            {
                Console.WriteLine(product.ToString());
            }
        }

    }
}
