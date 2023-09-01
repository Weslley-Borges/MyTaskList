using MyTaskList.src.Data;
using MyTaskList.src.Models;
using MyTaskList.src.Services.MajorTaskServices;

namespace MyTaskList.src.Services.MinorTaskServices
{
	internal class MinorTaskServices : IMinorTaskServices
	{
		private readonly DataContext _context;

		public MinorTaskServices(DataContext context)
		{
			_context = context;
		}

        public void AddTask(MinorTask minorTask)
        {
            _context.MinorTasks.Add(minorTask);
            _context.SaveChanges();
        }

        public void DeleteTask(MinorTask minorTask)
        {
            _context.MinorTasks.Remove(minorTask);
            _context.SaveChanges();
        }

        public MinorTask? GetTask(int id)
        {
            var task = _context.MinorTasks.Find(id);
            if (task == null)
                return null;
            return task;
        }

        public List<MinorTask>? GetTasksFromMajorTask(int majorTaskId)
        {
            var task = _context.MinorTasks.ToList().FindAll(t => t.MajorTask.Id == majorTaskId);
            if (task == null)
                return null;
            return task;
        }

        public void UpdateTask(int id, MinorTask request)
        {
            var task = _context.MinorTasks.Find(request);
            if (task == null)
                return;

            task.Title = request.Title;
            task.Done = request.Done;

            _context.SaveChanges();
        }
    }
}
