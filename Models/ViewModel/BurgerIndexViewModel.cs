using BurgerApp.Models.Domain;

namespace BurgerApp.Models.ViewModel
{
    public class BurgerIndexViewModel
    {
        public IEnumerable<Burger> Burgers { get; set; } = new List<Burger>();
        public string PriceClassName { get; set; } = string.Empty;
    }
}
