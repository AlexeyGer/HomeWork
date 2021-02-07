using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
	public class TeachersController : Controller
	{
		private readonly AppDbContext _db;


		public TeachersController(AppDbContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			ViewData["Teachers"] = _db.Teachers;
			return View();
		}
	}
}
