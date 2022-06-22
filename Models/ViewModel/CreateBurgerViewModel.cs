using BurgerApp.Models.Domain;
using BurgerApp.Models.Enums;

namespace BurgerApp.Models.ViewModel
{
    public class CreateBurgerViewModel
    {
        public IEnumerable<Kinds> Kinds { get; set; } = new List<Kinds>();
    }
}
