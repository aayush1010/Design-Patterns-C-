using DesignPatterns.FactoryPattern;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var fridge = Samsung.Factory.GetNewFridge();
            var washingMachine = Samsung.Factory.GetNewWashingMachine();

            Console.WriteLine(fridge.ToString());
            Console.WriteLine(washingMachine.ToString());

            Console.ReadLine();
        }
    }
}
