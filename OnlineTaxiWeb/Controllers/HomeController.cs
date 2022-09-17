using DatabaseDomain.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace OnlineTaxiWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _context;

        public HomeController(IUnitOfWork context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            var res = await _context._user.GetAllAsync();

            return View(res);

        }
    }
}
