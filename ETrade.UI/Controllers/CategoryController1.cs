using ETrade.Dal.Abstract;
using Microsoft.AspNetCore.Mvc;
using ETrad.Date.Models.Entities;
using ETrade.Dal.Abstract;
using ETrade.Dal.Concrete;

namespace ETrade.UI.Controllers
{
    public class CategoryController1 : Controller
    {
        private readonly ICategoryDAL categoryDAL;
        //CategoryDAL _categoryDAL = new CategoryDAL();
        public CategoryController1(ICategoryDAL categoryDAL)
        {
            this.categoryDAL = categoryDAL;
        }
        public IActionResult Index()
        {
            return View(categoryDAL.GetAll());
        }
    }
}
