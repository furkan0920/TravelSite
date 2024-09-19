
using Microsoft.EntityFrameworkCore;

namespace TravelWebSite.Models
{
	public class Context : DbContext
	{
			

		public Context(DbContextOptions<Context> options) : base(options)
		{

		}


		public DbSet<Admin> Admins { get; set; }
		public DbSet<AddressBlog> Addres { get; set; }	
		public DbSet<Blog> Blogs { get; set; }	
		public DbSet<About> Abouts { get; set; }	
		public DbSet<Contact>Contacts { get; set; }	
		public DbSet<Comments>Commentss { get; set; }	

	}
}
