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
	public IActionResult Add(Category category)
	
	{
		database.Categories.Add(category);
		database.SaveChanges();
		return RedirectToAction("Index");
	}
	
}
