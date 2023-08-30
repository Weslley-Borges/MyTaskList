using Microsoft.EntityFrameworkCore;
using MyTaskList.src.Models;


namespace MyTaskList.src.Data
{
	internal class DataContext : DbContext
	{
		string stringConnection = "Server=.\\SQLExpress; Database=myTaskListdb; Trusted_Connection=true; TrustServerConnection=true;";
		
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		=> optionsBuilder
			.UseSqlServer(stringConnection);

		public DbSet<MajorTask> MajorTasks { get; set; }
	}
}
