using CsharpDesignPatterns.AbstractFactory;
using System;

namespace CsharpDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Console.WriteLine("Hey THerin derrin dippity do wop boo!");
            AbstractFactoryDemo();
        }

        static void AbstractFactoryDemo()
        {
            AbstractBikeFactory factory = new RoadBikeFactory();
            IBikeFrame bikeFrame = factory.CreateBikeFrame();
            IBikeSeat bikeSeat = factory.CreateBikeSeat();
            Console.WriteLine(bikeFrame.BikeFrameParts);
            Console.WriteLine(bikeSeat.BikeSeatParts);
        }

    }

}
