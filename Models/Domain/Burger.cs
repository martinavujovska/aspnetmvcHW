using BurgerApp.Models.Enums;

namespace BurgerApp.Models.Domain
{
    public class Burger
    {

        public Burger(string name, decimal price, bool isVegeterian, bool isVegan, bool hasFries, Kinds kinds)
        {
            if(name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            Price = price;
            IsVegeterian = isVegeterian;
            IsVegan = isVegan;
            HasFries = hasFries;
            Kinds = kinds;
        }

        public Burger(string name, decimal price, Kinds kinds)
        {
            if(name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            Name = name;
            Price = price;
            Kinds = kinds;
            
        }


        public string Name { get; set; } = string.Empty;    
        public decimal Price { get; set; }
        public bool IsVegeterian { get; set; }
        public bool IsVegan { get; set; }
        public bool HasFries { get; set; }
        public Kinds Kinds { get; set; }
    }
}
