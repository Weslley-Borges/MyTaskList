using Microsoft.EntityFrameworkCore;
using MyTaskList.src.Models;


namespace MyTaskList.src.Data
{
    internal class DataContext : DbContext
    {
        public DbSet<MajorTask> MajorTasks { get; set; }
        public DbSet<MinorTask> MinorTasks { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=127.0.0.1;Port=3306 ;Uid=root; Database=myTaskList;";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            Console.WriteLine(ServerVersion.AutoDetect(connectionString));
        }
    }
}
