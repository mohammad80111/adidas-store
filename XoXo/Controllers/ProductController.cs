using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using XoXo.Models;

namespace XoXo.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext appDb)
        {
                
            _context = appDb;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Product> lista=_context.Products.Include(c=>c.Category).ToList();
            return View(lista);
        }



        [HttpGet]
        public IActionResult Create()
        {
            selectcategory();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            TempData["Create"] = "create sucess";
            _context.Products.Add(product); 
            _context.SaveChanges();

            return RedirectToAction("Index");
        }



        [HttpGet]
        public IActionResult Edit(int? id)
        {
            selectcategory();
            var pro=_context.Products.Find(id);

            return View(pro);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            TempData["Edit"] = "edit done";
            _context.Products.Update(product);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }



        public ViewResult Delete(int id)
        {
            TempData["Delete"] = "delete done";
            Product P1=(from pro in _context.Products
                        where pro.ID==id
                        select pro).FirstOrDefault();
            _context.Products.Remove(P1);
            _context.SaveChanges();
            List<Product> lista = _context.Products.Include(c => c.Category).ToList();
            return View("Index",lista);
        }



        public void selectcategory(int selectid=0)
        {
            List<Category> categories=_context.Categories.ToList();

            SelectList selectListItems = new SelectList(categories, "CategoryId", "Name", selectid);

            ViewBag.selectlistbag = selectListItems;
        }

    }
}
