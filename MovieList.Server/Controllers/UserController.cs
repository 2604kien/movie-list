using Microsoft.AspNetCore.Mvc;

namespace MovieList.Server.Controllers
{
	public class UserController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
