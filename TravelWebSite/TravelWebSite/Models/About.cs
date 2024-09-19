using System.ComponentModel.DataAnnotations;

namespace TravelWebSite.Models
{
	public class About
	{
		[Key]
        public int ID { get; set; }
		public string ImageUrl { get; set; }
		public string Description { get; set; }
    }
}
