using MyTaskList.src.Models;

namespace MyTaskList.src.Services
{
    internal interface IMajorTaskServices
    {
        List<MajorTask> GetAllTasks();
        MajorTask? GetTask(int id);
        void AddTask(MajorTask majorTask);
        void DeleteTask(MajorTask majorTask);
        void UpdateTask(int id, MajorTask request);
    }
}
