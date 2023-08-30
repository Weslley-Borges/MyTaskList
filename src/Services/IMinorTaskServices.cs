using MyTaskList.src.Models;

namespace MyTaskList.src.Services
{
    internal interface IMinorTaskServices
    {
        MinorTask GetTask(int id);
        void AddTask(string title, string description);
        void SetTaskDone(int id);
        void DeleteTask(int id);
        MinorTask UpdateTask(int id, string title, string description);
        List<MinorTask> GetAllTasks();
    }
}
