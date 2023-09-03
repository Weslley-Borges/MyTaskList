using MyTaskList.src.Data;
using MyTaskList.src.Models;

namespace MyTaskList.src.Services.MajorTaskServices
{
	/// <summary>
	/// A class for controlling operations on the MajorTask table in the database
	/// </summary>
	internal class MajorTaskServices : IMajorTaskServices
    {
        private readonly DataContext _context;

        public MajorTaskServices(DataContext context)
        {
            _context = context;
        }
        
        /// <summary>
        /// Get all the major tasks from the list
        /// </summary>
        /// <returns>All major tasks</returns>
        public List<MajorTask> GetAllTasks()
        {
            var tasks = _context.MajorTasks.ToList();
            return tasks;
        }

        /// <summary>
        /// Search for one MajorTask by it's Id.
        /// </summary>
        /// <param name="id"><see cref="MajorTask"/>'s Id.</param>
        /// <returns>A MajorTask or null</returns>
        public MajorTask? GetTask(int id)
        {
            var task = _context.MajorTasks.Find(id);
            if (task == null)
                return null;
            return task;
        }

        /// <summary>
        /// Add a <see cref="MajorTask"/> to the list
        /// </summary>
        /// <param name="majorTask">New task</param>
        public void AddTask(MajorTask majorTask)
        {
            _context.MajorTasks.Add(majorTask);
            _context.SaveChanges();
        }

        /// <summary>
        /// Remove a <see cref="MajorTask"/> from the list
        /// </summary>
        /// <param name="majorTask">old task</param>
        public void DeleteTask(MajorTask majorTask)
        {
            _context.MajorTasks.Remove(majorTask);
            _context.SaveChanges();
        }

        /// <summary>
        /// Update a <see cref="MajorTask"/>'s data
        /// </summary>
        /// <param name="request">Th <see cref="MajorTask"/> requested.</param>
        public void UpdateTask(int id, MajorTask request)
        {
            var task = GetTask(id);
            if (task == null)
                return;

            task.Title = request.Title;
            task.Description = request.Description;
            task.Done = request.Done;

            _context.SaveChanges();
        }
    }
}
