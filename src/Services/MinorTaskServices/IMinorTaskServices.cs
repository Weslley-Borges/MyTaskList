using MyTaskList.src.Models;

namespace MyTaskList.src.Services.MinorTaskServices
{
    internal interface IMinorTaskServices
    {
        MinorTask? GetTask(int id);
        List<MinorTask>? GetTasksFromMajorTask(int majorTaskId);
        void AddTask(MinorTask minorTask);
        void UpdateTask(int id, MinorTask request);
        void DeleteTask(MinorTask minorTask);
    }
}
