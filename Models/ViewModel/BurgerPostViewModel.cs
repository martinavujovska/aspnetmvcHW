using BurgerApp.Models.Enums;

namespace BurgerApp.Models.ViewModel
{
    public class BurgerPostViewModel
    {
        public string Name { get; set; }    
        public decimal Price { get; set; }
        public Kinds Kinds { get; set; }

    }
}
