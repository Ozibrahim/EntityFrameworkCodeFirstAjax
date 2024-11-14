using EntityFrameworkCodeFirstAjax.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkCodeFirstAjax.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Category cat)
        {
            using (NorthwindContext ctx = new NorthwindContext())
            {
                ctx.Add(cat);
                ctx.SaveChanges();
                List<Category> list = ctx.Categories.ToList();
                return Json(new { result = true, mesaj = "Kategori Başarıyla Eklendi",kategorilistesi= list });
            }      
        }

        [HttpPost]
        public IActionResult GetCategory(int id)
        {
            using (NorthwindContext ctx = new NorthwindContext())
            {
                Category cat = ctx.Categories.SingleOrDefault(x => x.CategoryId == id);
                
                List<Category> list = ctx.Categories.ToList();
                return Json(new { result = true, kategori = cat });
            }
        }

        [HttpPost]
        public IActionResult Update(Category cat)
        {
            using (NorthwindContext ctx = new NorthwindContext())
            {
                Category kategori = ctx.Categories.SingleOrDefault(x => x.CategoryId == cat.CategoryId);
                kategori.CategoryName = cat.CategoryName;
                kategori.Description = cat.Description;
                ctx.Update(kategori);
                ctx.SaveChanges();
                List<Category> list = ctx.Categories.ToList();
                return Json(new { result = true, mesaj = "Kategori Başarıyla Guncellendi", kategorilistesi = list });
            }
        }

        [HttpPost]
        public IActionResult Sil(int id)
        {
            using (NorthwindContext ctx = new NorthwindContext())
            {
                Category cat = ctx.Categories.SingleOrDefault(x => x.CategoryId == id);
                ctx.Remove(cat);
                ctx.SaveChanges();
                List<Category> list = ctx.Categories.ToList();
                return Json(new { result = true, mesaj = "Kategori Başarıyla Eklendi", kategorilistesi = list });
            }
        }


    }
}
