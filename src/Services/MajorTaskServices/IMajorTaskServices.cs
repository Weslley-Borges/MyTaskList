using MyTaskList.src.Models;

namespace MyTaskList.src.Services
{
    internal interface IMajorTaskServices
    {
        List<MajorTask> GetAllTasks();
        MajorTask? GetTask(int id);
		MajorTask? AddTask(MajorTask majorTask);
		MajorTask? DeleteTask(MajorTask majorTask);
		MajorTask? UpdateTask(int id, MajorTask request);
    }
}
