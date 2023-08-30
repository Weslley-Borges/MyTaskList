using MyTaskList.src.Models;

namespace MyTaskList.src.Services
{
    internal interface IMajorTaskServices
    {
        MajorTask GetTask(int id);
        void AddTask(string title, string description);
        void SetTaskDone(int id);
        void DeleteTask(int id);
        MajorTask UpdateTask(int id, string title, string description);
        List<MajorTask> GetAllTasks();
    }
}
