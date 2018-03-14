using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Gamely.Models
{
    public class Game
    {
        public int Id { get; set; }

		[Required]
        public string Name { get; set; }

		public Genre Genre { get; set; }

		[Display(Name = "Genre")]
		[Required]
		public byte GenreId { get; set; }

		[Display(Name = "Date Added")]
		public DateTime? DateAdded { get; set; }

		[Display (Name = "Date Released")]
		public DateTime? ReleaseDate { get; set; }

		[Display (Name = "Number in Stock")]
		public int Stock { get; set; }

    }
}