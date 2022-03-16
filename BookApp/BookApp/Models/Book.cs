using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Models
{
    public class Book
    {
        public Book()
        {
            this.CreatedAt = DateTime.UtcNow;
        }

        [Key]
        public int Id { get; set; }

        [Required]
		//[MinLength(3)]
		//[MaxLength(100)]
        public string Title { get; set; }

        [Required]
        public int ReleaseYear { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
