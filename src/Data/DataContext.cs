using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyTaskList.src.Models;

namespace MyTaskList.src.Data
{
    internal class DataContext : DbContext
    {
        public DbSet<MajorTask> MajorTasks { get; set; }
        public DbSet<MinorTask> MinorTasks { get; set; }

        public string? _connectionString;
        public DataContext()
        {
			IConfiguration config = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

			_connectionString = config["ConnectionStrings:MySQL"];
		}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString));
        }
    }
}
