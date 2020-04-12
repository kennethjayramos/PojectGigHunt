using GigHunt.Models;
using GigHunt.ViewModels;
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
    }
}