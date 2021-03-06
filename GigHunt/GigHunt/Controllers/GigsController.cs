﻿using GigHunt.Models;
using GigHunt.ViewModels;
using Microsoft.AspNet.Identity;
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
        [ValidateAntiForgeryToken]
        public ActionResult Create (GigCreateFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Genres = _dbContext.Genres.ToList();

                return View("Create", viewModel);
            }

            var gig = new Gig
            {
                ArtistId = User.Identity.GetUserId(),
                DateTime = viewModel.GetDateTime(),
                GenreId = viewModel.Genre,
                Venue = viewModel.Venue
            };

            _dbContext.Gigs.Add(gig);

            _dbContext.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}