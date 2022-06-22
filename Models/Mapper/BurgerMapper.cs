using BurgerApp.Models.Domain;
using BurgerApp.Models.ViewModel;
using BurgerApp.Models.Enums;

namespace BurgerApp.Models.Mapper
{
    public static class BurgerMapper
    {
        public static Burger CreateBurger(BurgerPostViewModel model)
        {
            return new Burger("", model.Price, model.Kinds);
        }
        
    }
}
