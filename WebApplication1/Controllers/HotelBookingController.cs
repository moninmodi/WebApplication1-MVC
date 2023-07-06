using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class HotelBookingController : Controller
    {
        private static List<HotelBooking> hotel = new List<HotelBooking>();
        public IActionResult Index()
        {
            HotelBooking hb = new HotelBooking()
            { Id = 1, GuestName="Monin Modi", DateStart = DateTime.Parse("2023-07-06"), DateEnd = DateTime.Parse("2023-07-10")};
            return View(hotel);
        }
        public IActionResult Create()
        {
            var hb = new HotelBooking();
            return View(hb);

        }
        public IActionResult CreateBook(HotelBooking hb)
        {
            hotel.Add(hb);
            return RedirectToAction(nameof(Index));
        }
    }
}
