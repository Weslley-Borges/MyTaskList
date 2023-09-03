using MyTaskList.src.Data;
using MyTaskList.src.Models;

namespace MyTaskList.src.Services.MinorTaskServices
{
	/// <summary>
	/// A class for controlling operations on the MinorTask table in the database
	/// </summary>
	internal class MinorTaskServices : IMinorTaskServices
	{
		private readonly DataContext _context;

		public MinorTaskServices(DataContext context)
		{
			_context = context;
		}

        /// <summary>
        /// Add a new <see cref="MinorTask"/> in the table
        /// </summary>
        /// <param name="minorTask">the new task</param>
        public MinorTask AddTask(MinorTask minorTask)
        {
            _context.MinorTasks.Add(minorTask);
            _context.SaveChanges();

            return minorTask;
        }

		/// <summary>
		/// Remove a <see cref="MinorTask"/> from the table
		/// </summary>
		/// <param name="minorTask">the new task</param>
		public MinorTask DeleteTask(MinorTask minorTask)
        {
            _context.MinorTasks.Remove(minorTask);
            _context.SaveChanges();

            return minorTask;
        }

        /// <summary>
        /// Get a specific <see cref="MinorTask"/> by the Id
        /// </summary>
        /// <param name="id">The Requested <see cref="MinorTask"/> Id</param>
        /// <returns>A task or null</returns>
        public MinorTask? GetTask(int id)
        {
            var task = _context.MinorTasks.Find(id);
            if (task == null)
                return null;

            return task;
        }

        /// <summary>
        /// Get all <see cref="MinorTask"/>s of a specific <see cref="MajorTask"/> by it's Id
        /// </summary>
        /// <param name="majorTaskId">The MajorTask Id</param>
        /// <returns>A list of <see cref="MinorTask"/></returns>
        public List<MinorTask> GetTasksFromMajorTask(int majorTaskId)
        {
            return _context.MinorTasks.ToList().FindAll(t => t.MajorTask.Id == majorTaskId);
        }

		/// <summary>
		/// Get all <see cref="MinorTask"/>s
		/// </summary>
		/// <returns>A list of <see cref="MinorTask"/></returns>
		public List<MinorTask> GetAllTasks()
		{
            return _context.MinorTasks.ToList();
		}

		/// <summary>
		/// Update a specific <see cref="MinorTask"/>
		/// </summary>
		/// <param name="id">The requested task Id</param>
		/// <param name="request">task new data</param>
		public MinorTask? UpdateTask(int id, MinorTask request)
        {
            var task = GetTask(id);
            if (task == null)
                return null;

            task.Title = request.Title;
            task.Done = request.Done;

            _context.SaveChanges();

            return GetTask(id);
        }
    }
}
