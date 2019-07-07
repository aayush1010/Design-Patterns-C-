using DesignPatterns.FactoryPattern;
using DesignPatterns.FluentBuilderPattern;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Factory Pattern
            var fridge = Samsung.Factory.GetNewFridge();
            var washingMachine = Samsung.Factory.GetNewWashingMachine();

            Console.WriteLine(fridge.ToString());
            Console.WriteLine(washingMachine.ToString());


            // Fluent Builder
            var htmlBuilder = new HtmlBuilder("html");
            htmlBuilder.AddChild("head", "").AddChild("body", "<p>Hello World!</p>").AddChild("script", "");
            Console.WriteLine(htmlBuilder.ToString());

            Console.ReadLine();


        }
    }
}
