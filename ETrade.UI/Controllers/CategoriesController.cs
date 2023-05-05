using ETrade.UI.Models.ViewModel;
using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class CategoriesController : BaseController
    {
        private readonly CategoriesModel model;

        public CategoriesController(IUow uow, CategoriesModel model) : base(uow)
        {
            this.model = model;
        }

        public IActionResult List()
        {
            return View(uow.CategoryRepository.GetCategories());
        }

        public IActionResult Create()
        {
            model.Text = "Save";
            model.Head = "New Categories";
            model.Class = "btn btn-outline-success my-2";

            return View("Crud", model);
        }

        [HttpPost]
        public IActionResult Create(CategoriesModel model)
        {
            uow.CategoryRepository.Add(model.Categories);
            uow.Commit();
            return RedirectToAction("List");
        }

        public IActionResult Update(Guid Id)
        {
            model.Text = "Save";
            model.Head = "Update Categories";
            model.Class = "btn btn-outline-success my-2";
            model.Categories = uow.CategoryRepository.Find(Id);

            return View("Crud", model);
        }

        [HttpPost]
        public IActionResult Update(CategoriesModel model)
        {
            uow.CategoryRepository.Update(model.Categories);
            uow.Commit();
            return RedirectToAction("List");
        }

        public IActionResult Delete(Guid Id)
        {
            uow.CategoryRepository.Delete(uow.CategoryRepository.Find(Id));
            uow.Commit();
            return RedirectToAction("List");
        }
    }
}