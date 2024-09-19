

using System.ComponentModel.DataAnnotations;

namespace TravelWebSite.Models
{
	public class AddressBlog
	{
		[Key]
        public int ID { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string FullAddress { get; set; }
		public string Mail { get; set; }
		public string Phone { get; set; }
		public string Location { get; set; }

    }
}
