using MyTaskList.src.Models;
using MyTaskList.src.Services;

namespace MyTaskList.src.Controllers
{
	/// <summary>
	/// A controller class that operates the MajorTasks service logic
	/// </summary>
	internal class MajorTaskController
	{
		private readonly IMajorTaskServices _services;

		public MajorTaskController(IMajorTaskServices services) 
			=> _services = services;

		/// <summary>
		/// Perform data validation and create a new <see cref="MajorTask"/>
		/// </summary>
		/// <param name="newTask">The task that will be added to the database</param>
		/// <returns>A <see cref="Response"/> that may contain an error message</returns>
		public Response<MajorTask> NewMajorTask(MajorTask newTask)
		{
			if (newTask.Title == "" || newTask.Description == "")
				return new Response<MajorTask>(true, "ERRO: Preencha os campos 'Título' e 'Descrição'");

			_services.AddTask(newTask);
			return new Response<MajorTask>(false, "Tarefa criada com sucesso!");
		}

		/// <summary>
		/// Validate and update a <see cref="MajorTask"/>
		/// </summary>
		/// <param name="task">The <see cref="MajorTask"/> that will be updated</param>
		/// <param name="request">The new task data</param>
		/// <returns>A <see cref="Response"/> that may contain an error message</returns>
		public Response<MajorTask> UpdateMajorTask(MajorTask? task, MajorTask request)
		{
			if (task == null)
				return new Response<MajorTask>(true, "ERRO: Nenhuma tarefa foi selecionada!");

			_services.UpdateTask(task.Id, request);
			return new Response<MajorTask>(false, "Tarefa atualizada com sucesso!", _services.GetTask(task.Id));
		}

		/// <summary>
		/// Validate and delete a <see cref="MajorTask"/>
		/// </summary>
		/// <param name="task">The <see cref="MajorTask"/> that will be deleted</param>
		/// <returns>A <see cref="Response"/> that may contain an error message</returns>
		public Response<MajorTask> DeleteMajorTask(MajorTask? task)
		{
			if (task == null)
				return new Response<MajorTask>(true, "ERRO: Nenhuma tarefa foi selecionada!");

			_services.DeleteTask(task);
			return new Response<MajorTask>(false, "Tarefa deletada com sucesso!");
		}

		/// <summary>
		/// Get all tasks
		/// </summary>
		/// <returns>A <see cref="Response"/> with all <see cref="MajorTask"/>'s as data.</returns>
		public Response<List<MajorTask>> GetAllTasks()
		{
			return new Response<List<MajorTask>>(false, "", _services.GetAllTasks());
		}
	}
}
