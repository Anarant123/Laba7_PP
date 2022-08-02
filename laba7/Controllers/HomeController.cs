using laba7.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace laba7.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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
        public IActionResult _Get()
        {
            return View();
        }
        public IActionResult _Post()
        {
            return View();
        }
        public IActionResult _Put()
        {
            return View();
        }
        public IActionResult _Delete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult _Post(string Name, string Age, string Birthday, string Phone, string Email, string City)
        {
            ViewBag.Name = Name;
            ViewBag.Age = Age;
            ViewBag.Birthday = Birthday;
            ViewBag.Phone = Phone;
            ViewBag.Email = Email;
            ViewBag.City = City;
            using (UsersContext db = new UsersContext())
            {
                User user = new User(Identity.Id, Name, Convert.ToInt32(Age), Convert.ToDateTime(Birthday), Phone, Email, City);
                db.Users.Add(user);
                db.SaveChanges();
            }
            Identity.Id++;
            return View();
        }
        [HttpPost]
        public IActionResult _Get(string sort)
        {
            ViewBag.Sort = sort;
            return View("_Get2");
        }
        [HttpPost]
        public IActionResult _Get2(string Name)
        {
            using (UsersContext db = new UsersContext())
            {
                foreach (User user in db.Users)
                {
                    if (Name == user.Name)
                    {
                        ViewBag.Name = user.Name;
                        ViewBag.Age = user.Age;
                        ViewBag.Birthday = user.Birthday;
                        ViewBag.Phone = user.Phone;
                        ViewBag.Email = user.Email;
                        ViewBag.City = user.City;
                    }
                }
            }
            return View();
        }
        [HttpPost]
        public IActionResult _Put(string Id)
        {
            ViewBag.Id = Id;
            return View("_Put2");
        }
        [HttpPost]
        public IActionResult _Delete(string Id)
        {
            ViewBag.ResultDelete = "Участник с Id: " + Id + " успешно удален!";
            return View();
        }
    }
}