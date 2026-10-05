using Microsoft.AspNetCore.Mvc;
using PassengerTrackingApp.Models;

namespace PassengerTrackingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var passengers = new List<Passenger>
    {
        new Passenger { Id = 1, FullName = "Ahmet Yılmaz", FlightNumber = "TK2140", ServiceType = "Tekerlekli Sandalye", Status = "Bekliyor" },
        new Passenger { Id = 2, FullName = "Ayşe Kaya", FlightNumber = "TK1881", ServiceType = "Sedye", Status = "Hizmet Verildi" },
        new Passenger { Id = 3, FullName = "Mehmet Demir", FlightNumber = "PC2023", ServiceType = "Tekerlekli Sandalye", Status = "Bekliyor" }
    };

            return View(passengers); // Model'i doğrudan View'a parametre olarak fırlatıyoruz!
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
