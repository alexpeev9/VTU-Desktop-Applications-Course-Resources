using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SongWebApp.Data.Models
{
	public class Song
	{
		[Key]
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string ImageUrl { get; set; }
		public string Author { get; set; }

		// One to Many Relation
		public Guid GenreId { get; set; }
		public Genre Genre { get; set; }
	}
}
