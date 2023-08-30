using MyTaskList.src.Data;
using MyTaskList.src.Models;

namespace MyTaskList.src.Services
{
    internal class MajorTaskServices : IMajorTaskServices
    {
        private readonly DataContext _context;

        public MajorTaskServices(DataContext context)
        {
            _context = context;
        }

        public void AddTask(string title, string description)
        {
            throw new NotImplementedException();
        }

        public void DeleteTask(int id)
        {
            throw new NotImplementedException();
        }

        public List<MajorTask> GetAllTasks()
        {
            throw new NotImplementedException();
        }

        public MajorTask GetTask(int id)
        {
            throw new NotImplementedException();
        }

        public void SetTaskDone(int id)
        {
            throw new NotImplementedException();
        }

        public MajorTask UpdateTask(int id, string title, string description)
        {
            throw new NotImplementedException();
        }
    }
}
