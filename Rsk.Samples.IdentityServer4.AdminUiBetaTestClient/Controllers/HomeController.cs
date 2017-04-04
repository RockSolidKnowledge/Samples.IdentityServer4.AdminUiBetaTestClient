using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Rsk.Samples.IdentityServer4.AdminUiBetaTestClient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult SignIn()
        {
            return View("Index");
        }

        [Authorize]
        public IActionResult SignOut()
        {
            return new SignOutResult(new[] { "OpenIdConnect", "Cookies" });
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
