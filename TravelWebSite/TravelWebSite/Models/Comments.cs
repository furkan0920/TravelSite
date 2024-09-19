using System.ComponentModel.DataAnnotations;

namespace TravelWebSite.Models
{
	public class Comments
	{
		[Key] 
		public int ID { get; set; }
		public string UserName { get; set; }
		public string Mail { get; set; }
		public string Comment { get; set; }
        public int Blogid { get; set; }
        public virtual Blog Blog { get; set; }
	}
}
