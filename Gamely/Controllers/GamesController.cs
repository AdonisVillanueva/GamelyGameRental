using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web.Mvc;
using Gamely.Models;
using Gamely.ViewModels;

namespace Gamely.Controllers
{
    public class GamesController : Controller
    {
		public ActionResult Details(int id)
		{
			var Game = _context.Games.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

			if (Game == null)
				return HttpNotFound();

			return View(Game);

		}

		// GET: Games
		public ActionResult Random()
        {
            var game = new Game() { Name = "Final Fantasy X" };

            // return View(game);
            // return Content("Hello World");
            // return EmptyResult();
            // return HttpNotFound();
            //return RedirectToAction("Index", "Home", new { page = 1, sortby = "name" });
            //ViewData["Game"] = game;

            //ViewBag.Game = game;
            var customers = new List<Customer>
            {
                new Customer {Name = "John Doe" },
                new Customer { Name = "Jane Doe" }
            };

            var viewModel = new RandomGameViewModel()
            {
                Game = game,
                Customers = customers
            };

            return View(viewModel);
           

        }

		private ApplicationDbContext _context;

		public GamesController()
		{
			_context = new ApplicationDbContext();
		}

		protected override void Dispose(bool disposing)
		{
			_context.Dispose();
		}

		public ViewResult Index()
		{
			var Games = _context.Games.Include(m => m.Genre).ToList();

			return View(Games);
		}

		[Route("Games/released/{year:regex(\\{4}):range(2000, 2017)}/{month:regex(\\{2}):range(1, 12)}")]

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
            
    }
}