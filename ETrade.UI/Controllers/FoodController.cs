using ETrade.UI.Models.ViewModel;

using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class FoodController : BaseController

    {
        private readonly FoodsModel model;

        public FoodController(IUow uow, FoodsModel model) : base(uow)
        {
            this.model = model;
        }

        public IActionResult List()
        {
            return View(uow.FoodRepository.GetFoods());
        }

        public IActionResult Create()
        {
            model.Cats = uow.CategoryRepository.GetCategories();
            model.Text = "Save";
            model.Head = "New Foods";
            model.Class = "btn btn-outline-success my-2";
            return View("Crud", model);
        }

        [HttpPost]
        public IActionResult Create(FoodsModel model)
        {
            uow.FoodRepository.Add(model.Foods);
            uow.Commit();
            return RedirectToAction("List");
        }

        public IActionResult Update(Guid Id)
        {
            model.Text = "Save";
            model.Head = "Update Properties";
            model.Class = "btn btn-outline-success my-2";
            model.Foods = uow.FoodRepository.Find(Id);

            return View("Crud", model);
        }

        [HttpPost]
        public IActionResult Update(FoodsModel model)
        {
            uow.FoodRepository.Update(model.Foods);
            uow.Commit();
            return RedirectToAction("List");
        }

        public IActionResult Delete(Guid Id)
        {
            uow.FoodRepository.Delete(uow.FoodRepository.Find(Id));
            uow.Commit();
            return RedirectToAction("List");
        }
    }
}