using ETrade.UI.Models.ViewModel;
using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
	public class PropertiesController : BaseController
	{
		private readonly PropertiesModel model;

		public PropertiesController(IUow uow, PropertiesModel model) : base(uow)
		{
			this.model = model;
		}

		public IActionResult List()
		{
			return View(uow.PropertyRepository.GetProperties());
		}

		public IActionResult Create()
		{
			model.Text = "Save";
			model.Head = "New Properties";
			model.Class = "btn btn-outline-success my-2";
			//Select-option part, we need this func.
			model.FoodDTOs = uow.FoodRepository.GetFoods();
			return View("Crud", model);
		}

		[HttpPost]
		public IActionResult Create(PropertiesModel model)
		{
			uow.PropertyRepository.Add(model.Properties);
			uow.Commit();
			return RedirectToAction("List");
		}

		public IActionResult Update(Guid Id)
		{
			model.Text = "Save";
			model.Head = "Update Properties";
			model.Class = "btn btn-outline-success my-2";
			model.Properties = uow.PropertyRepository.Find(Id);

			return View("Crud", model);
		}

		[HttpPost]
		public IActionResult Update(PropertiesModel model)
		{
			uow.PropertyRepository.Update(model.Properties);
			uow.Commit();
			return RedirectToAction("List");
		}

		public IActionResult Delete(Guid Id)
		{
			uow.PropertyRepository.Delete(uow.PropertyRepository.Find(Id));
			uow.Commit();
			return RedirectToAction("List");
		}
	}
}