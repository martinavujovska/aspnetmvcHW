using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using BurgerApp.Models.Mapper;
using BurgerApp.Models.ViewModel;
using BurgerApp.Models.Domain;
using BurgerApp.Models.Enums;


namespace BurgerApp.Controllers
{
    public class BurgerController : Controller
    {
        public BurgerController()
        {
            var test = 0;
            var test2 = 0;

            var test3 = ++test;
            var test4 = test2++;
        }
        public IActionResult Index()
        {
            var burgers = BurgerDb.Burgers.ToList();
            var model = new BurgerIndexViewModel
            {
                Burgers = burgers,
            };

            return View(model);
        }
        public IActionResult Details(string name)
        {
            var burger = BurgerDb.Burgers.FirstOrDefault(x => x.Name == name);

            if (burger is null)
            {
                return NotFound();
            }
            return View(burger);
        }
        public IActionResult Edit(string name)
        {
            var burger = BurgerDb.Burgers.FirstOrDefault(x => x.Name == name);

            if (burger is null)
            {
                return new EmptyResult();
            }
            return View(burger);
        }
        [HttpPost]
        public IActionResult Edit(string name, Burger model)
        {
            if (model is null)
            {
                return BadRequest();
            }
            var burger = BurgerDb.Burgers.FirstOrDefault(x => x.Name == name);

            if (burger is null)
            {
                return new EmptyResult();
            }
            model.Name = name;
            BurgerDb.UpdateBurger(model);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Create()
        {
            var model = new CreateBurgerViewModel()
            {
                Kinds = new List<Kinds>()
                {
                   Kinds.MushroomBurger,
                   Kinds.SupremeVeggieBurger,
                   Kinds.Hamburger
                }
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(BurgerPostViewModel model)
        {
            var burger = BurgerMapper.CreateBurger(model);
            var burgerName = BurgerDb.SaveBurger(burger);
            return RedirectToAction("Index");
        }
        [HttpGet("Burger/Delete/{name}")]
        public IActionResult GetDeletePage(string name)
        {
            var burger = BurgerDb.Burgers.FirstOrDefault(x => x.Name == name);

            if (burger is null)
            {
                return new EmptyResult();
            }
            return View(burger);
        }
        [HttpPost]
        public IActionResult Delete(string name)
        {
            var burger = BurgerDb.Burgers.FirstOrDefault(x => x.Name == name);

            if(burger is null)
            {
                return new EmptyResult();
            }
            BurgerDb.DeleteBurger(burger);
            return RedirectToAction("Index");
        }
    }
 }


