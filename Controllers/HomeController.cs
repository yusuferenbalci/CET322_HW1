using Book_Display_HW1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Book_Display_HW1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var books = new List<Book>
        {
            new Book { Name = "Dönüþüm", Author = "Franz Kafka", PageNumber = 200, DueDate = DateTime.Now.AddDays(5) },
            new Book { Name = "Nutuk", Author = "Mustafa Kemal Atatürk", PageNumber = 150, DueDate = DateTime.Now.AddDays(0) },
            new Book { Name = "Þeker Portakalý", Author = "Jose Mauro de Vasconcelos", PageNumber = 150, DueDate = DateTime.Now.AddDays(-2) }
            
        };

            return View(books);
        }
    }
}
