using Microsoft.AspNetCore.Mvc;
using PassengerTrackingApp.Data;
using PassengerTrackingApp.Models;

namespace PassengerTrackingApp.Controllers
{
    public class HomeController : Controller
    {
        // Gerçek veritabanı köprümüz
        private readonly AppDbContext _context;

        // Constructor Injection: Program.cs'te tanıttığımız DbContext buraya otomatik enjekte edilir
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        // 1. Veritabanındaki tüm yolcuları çekip View'a gönderen GET metodu
        public IActionResult Index()
        {
            // SQL karşılığı: SELECT * FROM Passengers
            var passengers = _context.Passengers.ToList();
            return View(passengers);
        }

        // 2. JavaScript Fetch API'den gelen yolcuyu SQL'e kaydeden POST metodu
        [HttpPost]
        public IActionResult AddPassenger([FromBody] Passenger newPassenger)
        {
            if (newPassenger == null || string.IsNullOrWhiteSpace(newPassenger.FullName))
            {
                return BadRequest("Geçersiz yolcu bilgisi!");
            }

            // Entity Framework takip mekanizmasına yeni yolcuyu ekle
            _context.Passengers.Add(newPassenger);

            // Değişiklikleri fiziksel olarak SQL Server'a kaydet (INSERT INTO Passengers ...)
            _context.SaveChanges();

            // SQL'in otomatik oluşturduğu Id ile birlikte nesneyi JSON olarak geri dön
            return Ok(newPassenger);
        }
    }
}