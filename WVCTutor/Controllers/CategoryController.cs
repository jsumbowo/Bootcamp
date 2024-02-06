using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using WVCTutor.Data;
using WVCTutor.Models;

namespace WVCTutor.Controllers;

public class CategoryController : Controller
{
	public readonly DataBase database; 
	public CategoryController(DataBase db)
	
	{
		database = db;
	}
	
	public IActionResult Index()
	
	{
		IEnumerable<Category> categories = database.Categories.ToList();
		return View(categories);
	}
	public IActionResult Add()
	
	{
		return View();
	}
	[HttpPost]
	public IActionResult Add(Category category)
	
	{
		IEnumerable<Category> categories = database.Categories.ToList();
		if(ModelState.IsValid)
		{
			if(categories.FirstOrDefault(c => c.CategoryName.ToLower() == category.CategoryName.ToLower()) is null)
			{
				database.Categories.Add(category);
				database.SaveChanges();
				return RedirectToAction("Index");
			}	
		}
		return RedirectToAction("Add");
	}
	
	public IActionResult Delete(int? id)
	
	{
		Category? category = database.Categories.ToList().FirstOrDefault(c => c.CategoryId == id);
		if(category is null)
		
		{
			return RedirectToAction("Index");	
		}
		return View(category);
	}
	[HttpPost]
	public async Task<IActionResult> Delete(int id)
	
	{
		Category? delCat = database.Categories.ToList().FirstOrDefault(c => c.CategoryId == id);
		database.Categories.Remove(delCat);
		await database.SaveChangesAsync();
		return RedirectToAction("Index");
	}
	
	public IActionResult Edit(int? id)
	
	{
		Category? category = database.Categories.ToList().FirstOrDefault(c => c.CategoryId == id);
		if(category is null)
		
		{
			return RedirectToAction("Index");	
		}
		return View(category);
	}
	[HttpPost]
	public async Task<IActionResult> Edit(Category category)
	
	{
		if(ModelState.IsValid)
		{
			database.Categories.Update(category);
			await database.SaveChangesAsync();
			return RedirectToAction("Index");
		}
		return RedirectToAction("Edit");
	}
}
