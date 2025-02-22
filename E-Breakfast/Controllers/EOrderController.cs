using Microsoft.AspNetCore.Mvc;

namespace E_Breakfast.Controllers
{
    public class EOrderController : Controller
    {
        public IActionResult AddNewOrder()
        {
            return View();
        }
    }
}
