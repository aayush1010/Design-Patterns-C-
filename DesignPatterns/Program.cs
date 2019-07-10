using DesignPatterns.BridgePattern;
using DesignPatterns.FactoryPattern;
using DesignPatterns.FluentBuilderPattern;
using DesignPatterns.PrototypePattern;
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


            // Fluent Builder Pattern
            var htmlBuilder = new HtmlBuilder("html");
            htmlBuilder.AddChild("head", "").AddChild("body", "<p>Hello World!</p>").AddChild("script", "");
            Console.WriteLine(htmlBuilder.ToString());

            // Prototype Patten
            var hondaAmaze = new Car(5, new Engine(1600));
            var hondaCity = new Car(hondaAmaze);
            hondaCity.Engine.Capacity = 2000;
            Console.WriteLine(hondaAmaze);
            Console.WriteLine(hondaCity);

            // Bridge Pattern
            var circle = new Circle(new Pencil(), 5);
            circle.Draw();
            circle = new Circle(new Pen(), 5);
            circle.Draw();
            Console.ReadLine();

        }
    }
}
