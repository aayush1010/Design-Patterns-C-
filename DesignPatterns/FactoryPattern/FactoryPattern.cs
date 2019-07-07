// Factory Pattern 
namespace DesignPatterns.FactoryPattern
{
    /// <summary>
    /// Samsung class to demonstrate the factory pattern
    /// </summary>
    public class Samsung
    {
        private string product;

        private Samsung(string product)
        {
            this.product = product;
        }

        public override string ToString()
        {
            return $"{nameof(product)} : {product}";
        }

        public static class Factory
        {
            public static Samsung GetNewFridge()
            {
                return new Samsung("Here is your fridge");
            }

            public static Samsung GetNewWashingMachine()
            {
                return new Samsung("Here is your washing machine");
            }
        }
    }
}

