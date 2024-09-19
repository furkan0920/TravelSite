using System.ComponentModel.DataAnnotations;

namespace TravelWebSite.Models
{
	public class Admin
	{
		[Key]
		public int ID { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }
}
