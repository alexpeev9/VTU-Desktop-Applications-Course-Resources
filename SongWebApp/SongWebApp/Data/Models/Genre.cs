using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SongWebApp.Data.Models
{
	public class Genre
	{
		[Key]
		public Guid Id { get; set; }
		public string Name { get; set; }
		public ICollection<Song> Songs { get; set; }
	}
}
