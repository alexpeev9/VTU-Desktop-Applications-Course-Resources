using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFormAppSecondGroup.Database.Model
{
	public class Car
	{
		[Key]
		public Guid Id { get; set; }
		public string Model { get; set; }
		public string Brand { get; set; }
	}
}
