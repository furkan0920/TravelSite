using System.ComponentModel.DataAnnotations;

namespace TravelWebSite.Models
{
	public class index
	{
		[Key]
        public int ID { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
    }
}
