using GigHunt.Models;
using GigHunt.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.Mvc;

namespace GigHunt.Controllers
{
    public class GigsController : Controller
    {
        // set ApplicationDbContext
        private readonly ApplicationDbContext _dbContext;

        #region Constructor

        public GigsController()
        {
            _dbContext = new ApplicationDbContext();
        }

        #endregion

        // POST: Gigs
        [Authorize]
        public ActionResult Create()
        {
            var gigViewModel = new GigCreateFormViewModel
            {
                Genres = _dbContext.Genres.ToList()
            };

            return View(gigViewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create (GigCreateFormViewModel viewModel)
        {
            var artistId = User.Identity.GetUserId();

            var artist = _dbContext.Users.Single(u => u.Id == artistId);

            var genre = _dbContext.Genres.Single(g => g.Id == viewModel.Genre);

            var gig = new Gig
            {
                Artist = artist,
                DateTime = DateTime.Parse(string.Format("{0} {1}", viewModel.Date, viewModel.Time)),
                Genre = genre,
                Venue = viewModel.Venue
            };

            _dbContext.Gigs.Add(gig);

            _dbContext.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}