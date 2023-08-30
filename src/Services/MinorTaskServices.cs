using MyTaskList.src.Data;
using MyTaskList.src.Models;

namespace MyTaskList.src.Services
{
	internal class MinorTaskServices : IMinorTaskServices
	{
		private readonly DataContext _context;

		public MinorTaskServices(DataContext context)
		{
			_context = context;
		}

        public List<MinorTask> GetAllTasks()
        {
            throw new NotImplementedException();
        }

        public void AddTask(string title, string description)
		{
			throw new NotImplementedException();
		}

		public void DeleteTask(int id)
		{
			throw new NotImplementedException();
		}


		public MinorTask GetTask(int id)
		{
			throw new NotImplementedException();
		}

		public void SetTaskDone(int id)
		{
			throw new NotImplementedException();
		}

		public MinorTask UpdateTask(int id, string title, string description)
		{
			throw new NotImplementedException();
		}
	}
}
