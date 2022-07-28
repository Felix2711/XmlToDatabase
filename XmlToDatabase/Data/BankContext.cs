using Microsoft.EntityFrameworkCore;
using XmlToDatabase.Models;

namespace XmlToDatabase.Data
{
	public class BankContext : DbContext
	{
		public DbSet<Entry> Entries { get; set; }
		public BankContext(DbContextOptions<BankContext> options) : base(options) { }
	}
}
