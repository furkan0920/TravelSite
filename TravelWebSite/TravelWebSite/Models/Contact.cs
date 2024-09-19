using System.ComponentModel.DataAnnotations;

namespace TravelWebSite.Models
{
	public class Contact
	{
		[Key]	
		public int ID { get; set; }
		public string FullName { get; set; }
		public string Mail { get; set; }
		public string Subject { get; set; }
		public string Message { get; set; }
	}
}
