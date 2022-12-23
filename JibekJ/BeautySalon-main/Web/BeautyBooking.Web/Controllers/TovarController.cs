using Microsoft.AspNetCore.Mvc;
using BeautyBooking.Data.Models;
using BeautyBooking.Web.ViewModels;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using BeautyBooking.Data;

namespace BeautyBooking.Web.Controllers
{
	public class TovarController : Controller
	{
		public JibekDbContext GetContext()
		{
			return new JibekDbContext();
		}
		public IActionResult Index()
		{
			return View(this.GetContext().Tovars.ToList());
		}
		public IActionResult New()
		{
			return View(new TovarCreateViewModel());
		}
		public async Task<IActionResult> Create(TovarCreateViewModel model)
		{
			using (var context = GetContext())
			{
				var client = new Tovar
				{
					Name = model.Name,
					count = model.count,
					cost = model.cost,
					descrip = model.descrip,
					comment = model.comment,
					dolg = model.dolg,
					shir = model.shir,

				};
				context.Tovars.Add(client);
				context.SaveChanges();
			}
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult Edit(int? id)
		{
			using (var context = GetContext())
			{
				Tovar findClient = context.Tovars.Find(id);
				var client = new TovarEditViewModel
				{
					Id = findClient.Id,
					Name = findClient.Name,
					count = findClient.count,
					cost = findClient.cost,
					descrip = findClient.descrip,
					comment = findClient.comment,
				};
				return View(client);
			}
		}

		[HttpPost]
		public async Task<IActionResult> Edit(TovarEditViewModel model)
		{
			using (var context = GetContext())
			{
				Tovar client = context.Tovars.Find(model.Id);
				client.Name = model.Name;
				client.count = model.count;
				client.cost = model.cost;
				client.descrip = model.descrip;
				client.comment = model.comment;
				context.SaveChanges();
			}
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult Delete(int? id)
		{
			using (var context = GetContext())
			{
				Tovar findClient = context.Tovars.Find(id);
				var client = new TovarDeleteViewModel
				{
					Id = findClient.Id,
					Name = findClient.Name,
					count = findClient.count,
					cost = findClient.cost,
					descrip = findClient.descrip,
					comment = findClient.comment
				};
				return View(client);
			}
		}

		[HttpPost]
		public async Task<IActionResult> DeleteTovar(TovarDeleteViewModel model)
		{
			using (var context = GetContext())
			{
				Tovar client = context.Tovars.Find(model.Id);
				context.Tovars.Remove(client);
				context.SaveChanges();
			}
			return RedirectToAction("Index");
		}

	}
}
