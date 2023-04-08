using Builder;
using Proxy;
using Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisignPaterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Singleton pattern
            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();
            singleton1.SomeBusinessLogic();
            if (singleton1 == singleton2)
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            else Console.WriteLine("Singleton failed, variables contain different instances.");

            //Builder pattern
            ConcreteBuilder1 builder = new ConcreteBuilder1();
            Director director = new Director(builder);
            //director.BuildMinimalProduct();
            director.BuildFullProduct();
            var product = builder.GetProduct();
            foreach (var part in product.GetParts())
            {
                Console.WriteLine(part);
            }

            //Strategy pattern
            string inputString = "absdef";
            Context context = new Context();
            context.DoSomething(inputString);
            context.SetStrategy(new StrategyA());
            context.DoSomething(inputString);
            context.SetStrategy(new StrategyB());
            context.DoSomething(inputString);
            context.SetStrategy(new StrategyC());
            context.DoSomething(inputString);

            //Proxy
            INetResource resource = new NetResourceProxy(new NetResource());
            while (true)
            {
                Console.WriteLine(resource.GetStatus());
            }
            

            Console.ReadKey();
        }  
    }
}
