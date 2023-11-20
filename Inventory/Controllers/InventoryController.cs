using Microsoft.AspNetCore.Mvc;

namespace Inventory.Controllers
{
    public class InventoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddNewItem()
        {
            return View();
        }

        public IActionResult EditItem()
        {
            return View();
        }

        public IActionResult SearchItem()
        {
            return View();
        }

     }
}
