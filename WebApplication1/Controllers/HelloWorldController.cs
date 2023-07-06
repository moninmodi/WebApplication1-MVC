using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dog = new List<DogViewModel>();
        public IActionResult Index()
        {
            DogViewModel dg = new DogViewModel()
            { Name = "Tyson", age=3};

            return View(dog);
        }   
        public IActionResult Hello()
        {
            Dog dg = new Dog("Bark Bark");
            return View(dg);
        }
        public IActionResult Create() {
            var dg = new DogViewModel();
            return View(dg);

        }
		public IActionResult CreateDog(DogViewModel dg) {
            dog.Add(dg);
            return RedirectToAction(nameof(Index));
            //return View("Index");
        }
	}
}
