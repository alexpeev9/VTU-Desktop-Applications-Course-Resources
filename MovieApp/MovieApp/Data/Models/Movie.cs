using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Data.Models
{
	public class Movie
	{
		[Key]
		public Guid Id { get; set; }
		public string Titile { get; set; }
		public string ImageUrl { get; set; }
		public int ReleaseYear { get; set; }
	}
}
