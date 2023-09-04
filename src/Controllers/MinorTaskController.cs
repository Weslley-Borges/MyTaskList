using MyTaskList.src.Models;
using MyTaskList.src.Services.MinorTaskServices;

namespace MyTaskList.src.Controllers
{
	internal class MinorTaskController
	{
		private readonly IMinorTaskServices _services;

		public MinorTaskController(IMinorTaskServices services)
			=> _services = services;

		/// <summary>
		/// Perform data validation and create a new <see cref="MinorTask"/>
		/// </summary>
		/// <param name="newTask">The task that will be added to the database</param>
		/// <returns>A <see cref="Response"/> that may contain an error message</returns>
		public Response<MinorTask> NewMinorTask(MajorTask? task, string title)
		{
			if (task == null)
				return new Response<MinorTask>(true, "ERRO: Selecione uma tarefa antes de inserir uma tarefa menor nela!");

			if (title == "")
				return new Response<MinorTask>(true, "ERRO: Preencha o campo 'Título'");

			_services.AddTask(new() { Title = title, MajorTask = task});
			return new Response<MinorTask>(false, "Tarefa criada com sucesso!");
		}

		/// <summary>
		/// Validate and update a <see cref="MinorTask"/>
		/// </summary>
		/// <param name="task">The <see cref="MinorTask"/> that will be updated</param>
		/// <param name="request">The new task data</param>
		/// <returns>A <see cref="Response"/> that may contain an error message</returns>
		public Response<MinorTask> UpdateMinorTask(MinorTask? task, string title)
		{
			if (task == null)
				return new Response<MinorTask>(true, "ERRO: Nenhuma tarefa foi selecionada!");

			MinorTask request = task;
			request.Title = title;

			_services.UpdateTask(task.Id, request);
			return new Response<MinorTask>(false, "Tarefa atualizada com sucesso!", _services.GetTask(task.Id));
		}

		public Response<MinorTask> CheckAsDone(MinorTask? task)
		{
			if (task == null)
				return new Response<MinorTask>(true, "ERRO: Nenhuma tarefa foi selecionada!");

			MinorTask request = task;
			request.Done = request.Done == false;

			_services.UpdateTask(task.Id, request);
			return new Response<MinorTask>(false, "Tarefa atualizada com sucesso!", _services.GetTask(task.Id));
		}

		/// <summary>
		/// Validate and delete a <see cref="MinorTask"/>
		/// </summary>
		/// <param name="task">The <see cref="MinorTask"/> that will be deleted</param>
		/// <returns>A <see cref="Response"/> that may contain an error message</returns>
		public Response<MinorTask> DeleteMinorTask(MinorTask? task)
		{
			if (task == null)
				return new Response<MinorTask>(true, "ERRO: Nenhuma tarefa foi selecionada!");

			_services.DeleteTask(task);
			return new Response<MinorTask>(false, "Tarefa deletada com sucesso!");
		}

		/// <summary>
		/// Get all tasks from a MajorTask
		/// </summary>
		/// <returns>A <see cref="Response"/> with a list of <see cref="MinorTask"/>'s as data.</returns>
		public Response<List<MinorTask>> GetAllTasksfromMajorTask(int id)
		{
			return new Response<List<MinorTask>>(false, "", _services.GetTasksFromMajorTask(id));
		}

		/// <summary>
		/// Get all tasks
		/// </summary>
		/// <returns>A <see cref="Response"/> with all <see cref="MajorTask"/>'s as data.</returns>
		public Response<List<MinorTask>> GetAllTasks()
		{
			return new Response<List<MinorTask>>(false, "", _services.GetAllTasks());
		}
	}
}
