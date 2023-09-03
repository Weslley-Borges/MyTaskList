using MyTaskList.src.Models;

namespace MyTaskList.src.Services.MinorTaskServices
{
    internal interface IMinorTaskServices
    {
        MinorTask? GetTask(int id);
		List<MinorTask> GetAllTasks();
		List<MinorTask> GetTasksFromMajorTask(int majorTaskId);
        MinorTask? AddTask(MinorTask minorTask);
		MinorTask? UpdateTask(int id,MinorTask request);
		MinorTask? DeleteTask(MinorTask minorTask);
    }
}
