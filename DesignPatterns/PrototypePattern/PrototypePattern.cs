namespace DesignPatterns.PrototypePattern
{
    class Engine
    {
        public int Capacity;

        public Engine(int capacity)
        {
            Capacity = capacity;
        }

        public Engine(Engine oldEngine)
        {
            Capacity = oldEngine.Capacity;
        }

        public override string ToString()
        {
            return $"{nameof(Capacity)} : {Capacity}";
        }
    }
    class Car
    {
        public int SeatingCapacity;
        public Engine Engine;

        public Car(int seatingCapacity, Engine engine)
        {
            SeatingCapacity = seatingCapacity;
            Engine = engine;
        }

        public Car(Car oldCar)
        {
            SeatingCapacity = oldCar.SeatingCapacity;
            Engine = new Engine(oldCar.Engine);
        }

        public override string ToString()
        {
            return $"{nameof(SeatingCapacity)} : {SeatingCapacity}, {nameof(Engine)} : {Engine}";
        }
    }

}
