using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gamely.Models;
using Gamely.ViewModels;

namespace Gamely.Controllers
{
    public class GamesController : Controller
    {
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

        public ActionResult Edit(int id)
        {
            return Content("id" + id);
        }


        //games
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}",pageIndex,sortBy));
        }

        [Route("movies/released/{year:regex(\\{4}):range(2000, 2017)}/{month:regex(\\{2}):range(1, 12)}")]

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
            
    }
}