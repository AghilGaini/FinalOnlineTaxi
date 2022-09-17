using DatabaseDomain.DTO.Security;
using DatabaseDomain.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DatabaseDomain.OtherModels;

namespace OnlineTaxiWeb.Controllers
{
    public class SecurityController : Controller
    {
        private readonly IUnitOfWork _context;

        public SecurityController(IUnitOfWork context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Users()
        {
            var res = new UsersDTO();

            res.Users.AddRange(await _context._user.GetAllUsersDTOAsync());

            res.Actions.Add(new ActionItem() { Action = "EditUser", Controller = "Security", Title = "ویرایش", OnClickFunction = "EditUser" });
            res.Actions.Add(new ActionItem() { Action = "DeleteUser", Controller = "Security", Title = "حذف", OnClickFunction = "DeleteUser" });

            return View(res);
        }




    }
}
