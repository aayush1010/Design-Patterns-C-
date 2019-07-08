namespace DesignPatterns.PrototypePattern
{
    /// <summary>
    /// Engine : this can be update for the new car created
    /// </summary>
    class Engine
    {
        /// <summary>
        /// The capacity of engine
        /// </summary>
        public int Capacity;

        /// <summary>
        /// Initializes a new instance of the <see cref="Engine"/> class.
        /// Constructor used to create new engine
        /// </summary>
        /// <param name="capacity">The capacity.</param>
        public Engine(int capacity)
        {
            Capacity = capacity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Engine"/> class.
        /// </summary>
        /// Constructor used to create new engine using old engine
        /// <param name="oldEngine">The old engine.</param>
        public Engine(Engine oldEngine)
        {
            Capacity = oldEngine.Capacity;
        }

        /// <summary>
        /// Return engine to string
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"{nameof(Capacity)} : {Capacity}";
        }
    }

    /// <summary>
    /// Car class
    /// </summary>
    class Car
    {
        /// <summary>
        /// The seating capacity of car
        /// </summary>
        public int SeatingCapacity;

        /// <summary>
        /// The engine of car
        /// </summary>
        public Engine Engine;

        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// Constructor to create new car with seating capacity and engine
        /// </summary>
        /// <param name="seatingCapacity">The seating capacity.</param>
        /// <param name="engine">The engine.</param>
        public Car(int seatingCapacity, Engine engine)
        {
            SeatingCapacity = seatingCapacity;
            Engine = engine;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// Constructor to create new car using old car properties
        /// <param name="oldCar">The old car.</param>
        public Car(Car oldCar)
        {
            SeatingCapacity = oldCar.SeatingCapacity;
            Engine = new Engine(oldCar.Engine);
        }

        /// <summary>
        /// Convert car object to string for print
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"{nameof(SeatingCapacity)} : {SeatingCapacity}, {nameof(Engine)} : {Engine}";
        }
    }

}
