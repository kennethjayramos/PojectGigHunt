using GigHunt.Models;
using System.Collections.Generic;

namespace GigHunt.ViewModels
{
    public class GigCreateFormViewModel
    {
        public string Venue { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }

        public int Genre { get; set; }

        public IEnumerable<Genre> Genres { get; set; }
    }
}