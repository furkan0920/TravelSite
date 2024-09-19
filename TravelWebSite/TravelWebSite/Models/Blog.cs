using System.ComponentModel.DataAnnotations;

namespace TravelWebSite.Models
{
	public class Blog
	{
		[Key]
		public int ID { get; set; }
		public string Title { get; set; }
		public DateTime DateT { get; set; }
		public string Description { get; set; }
		public string BlogImage { get; set; }

		public ICollection<Comments> Commentss { get; set;}  //bire çok ilişki sağlanması bir blogda birden fazla yorum olabilir
}
}
