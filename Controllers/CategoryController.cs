using BulkyBookWeb.Data;
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http.ModelBinding;

namespace BulkyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly DataBaseContext _dataBaseContext;
        public CategoryController(DataBaseContext dataBaseContext) { 
            _dataBaseContext = dataBaseContext;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> categories = _dataBaseContext.Categories;

            return View(categories);
        }


        public IActionResult Create()
        {
        

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category model)
        {
            if (model.Name == model.DisplayOrder.ToString()) {
                ModelState.AddModelError("Custome Error", "The display Order can not be same with catagory Name");
            }

            if(ModelState.IsValid)
            {
                this._dataBaseContext.Categories.Add(model);   
                this._dataBaseContext.SaveChanges();
                TempData["success"] = "Category Crrated Successfully";
                return RedirectToAction("Index");
            }

            return View(model);
        }




        public IActionResult Edit(int? id)
        {
            if (id==null || id == 0) { 
                return NotFound();
            }


            var record = _dataBaseContext.Categories.Find(id);
            if (record == null)
            {
                NotFound();
            }
            return View(record);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category model)
        {
            if (model.Name == model.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Custome Error", "The display Order can not be same with catagory Name");
            }

            if (ModelState.IsValid)
            {
                this._dataBaseContext.Categories.Update(model);
                this._dataBaseContext.SaveChanges();
                TempData["success"] = "Category Updated Successfully";

                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Delete(int? id)
        {

            if (id==null || id == 0) { 
                NotFound(); 
            }

            var record = this._dataBaseContext.Categories.Find(id);
            this._dataBaseContext.Categories.Remove(record);
            this._dataBaseContext.SaveChanges();
            TempData["success"] = "Category Deleted Successfully";


            return RedirectToAction("Index");


        } 

    }
}
