// Factory Pattern 
namespace DesignPatterns.FactoryPattern
{
    /// <summary>
    /// Samsung class to demonstrate the factory pattern
    /// </summary>
    public class Samsung
    {
        /// <summary>
        /// The product factory needs to create
        /// </summary>
        private string product;

        /// <summary>
        /// Initializes a new instance of the <see cref="Samsung"/> class.
        /// The constructor is private because the samsung products should be made using the factory only
        /// </summary>
        /// <param name="product">The product.</param>
        private Samsung(string product)
        {
            this.product = product;
        }

        /// <summary>
        /// Print the product created
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"{nameof(product)} : {product}";
        }

        /// <summary>
        /// Factory class to make samsung products
        /// The factory class is made inner so that it can make the samsung objects using the Private Constructor 
        /// </summary>
        public static class Factory
        {
            /// <summary>
            /// Gets the new fridge.
            /// </summary>
            /// <returns>Samsung object of Fridge</returns>
            public static Samsung GetNewFridge()
            {
                return new Samsung("Here is your fridge");
            }

            /// <summary>
            /// Gets the new washing machine.
            /// </summary>
            /// <returns>Samsung object of Washing Machine</returns>
            public static Samsung GetNewWashingMachine()
            {
                return new Samsung("Here is your washing machine");
            }
        }
    }
}

