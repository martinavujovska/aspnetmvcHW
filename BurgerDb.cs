using BurgerApp.Models.Domain;
using BurgerApp.Models.Enums;

namespace BurgerApp
{
    public static class BurgerDb
    {
        public static List<Burger> Burgers = new List<Burger>
        {
            new Burger("Cheeseburger", 150, false, false, true, Kinds.Cheeseburger),
            new Burger("Chrispy Chicken", 300, false, false, true, Kinds.ChickenBurger)
        };

        public static string SaveBurger(Burger burger)
        {
            var burgerName = Burgers.OrderBy(x => x.Name).LastOrDefault();
            Burgers.Add(burger);
            return burger.Name;
        }

        public static void UpdateBurger(Burger model)
        {
            var burgerIndex = 0;
            foreach(var burger in Burgers)
            {
                if(burger.Name == model.Name)
                {
                    break;
                }
                burgerIndex++;
            }
            if(Burgers[burgerIndex] is not null)
            {
                Burgers[burgerIndex] = model;   
            }
        }
        public static void DeleteBurger(string name)
        {
            var model = Burgers.FirstOrDefault(x => x.Name == name);
            if(model is not null)
            {
                DeleteBurger(model);
            }
        }
        public static void DeleteBurger(Burger model)
        {
            Burgers.Remove(model);
        }
     
    }
}