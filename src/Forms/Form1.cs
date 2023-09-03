using MyTaskList.src.Controllers;
using MyTaskList.src.Data;
using MyTaskList.src.Models;
using MyTaskList.src.Services.MajorTaskServices;
using MyTaskList.src.Services.MinorTaskServices;

namespace MyTaskList
{
	public partial class Form1 : Form
	{
		private readonly DataContext db = new();
		private readonly MinorTaskServices _minorTaskServices = new(db);

		private MajorTask? atualMajorTask;
		private MinorTask? atualMinorTask;

		private readonly MajorTaskController _majorTaskController;

		public Form1()
		{
			_majorTaskController = new MajorTaskController(new MajorTaskServices(db));

			InitializeComponent();
			UpdateForm();
		}

		// ----- MajorTasks Events
		private void NewMajorTaskButton_Click(object sender, EventArgs e)
		{
			Response<MajorTask> result = _majorTaskController.NewMajorTask(
				new()
				{
					Title = MajorTaskTitleInput.Text,
					Description = MajorTaskDescriptionInput.Text
				});

			if (!result.IsError)
				atualMajorTask = null;

			UpdateForm();
			ShowMessage(result, MajorTaskErrorLabel);
		}

		private void UpdateMajorTaskButton_Click(object sender, EventArgs e)
		{
			Response<MajorTask> result = _majorTaskController.UpdateMajorTask(
				atualMajorTask,
				new()
				{
					Title = MajorTaskTitleInput.Text,
					Description = MajorTaskDescriptionInput.Text
				});

			if (!result.IsError)
				atualMajorTask = result.Data;

			UpdateForm();
			ShowMessage(result, MajorTaskErrorLabel);
		}

		private void DeleteMajorTaskButton_Click(object sender, EventArgs e)
		{
			Response<MajorTask> result = _majorTaskController.DeleteMajorTask(atualMajorTask);

			if (result.IsError)
			{
				MajorTaskErrorLabel.Text = result.Message;
				return;
			}

			atualMajorTask = null;
			UpdateForm();
			ShowMessage(result, MajorTaskErrorLabel);
		}

		private void MajorTasksList_SelectedIndexChanged(object sender, EventArgs e)
		{
			atualMajorTask = _majorTaskController
				.GetAllTasks()
				.Data?
				.Find(t => t?.Title == MajorTasksList.SelectedItem?.ToString());

			atualMinorTask = null;
			UpdateForm();
		}

		

		private void MinorTasksCheckList_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selected = MinorTasksCheckList.SelectedItem;
			if (selected == null) return;

			var selectedTask = atualMajorTask?
				.MinorTasks
				.Find(t => t.Title == selected.ToString());

			atualMinorTask = selectedTask;
			UpdateForm();
		}

		

		private void NewMinorTaskButton_Click(object sender, EventArgs e)
		{
			if (atualMajorTask == null)
			{
				MajorTaskErrorLabel.Text = "ERRO: Nenhuma tarefa foi selecionada!";
				return;
			}
			if (MinorTaskInput.Text == "")
			{
				MinorTaskErrorLabel.Text = "ERRO: Preencha o campo 'Título'";
				return;
			}

			MinorTask t = new()
			{
				Title = MinorTaskInput.Text,
				MajorTask = atualMajorTask
			};

			// Validate
			bool valid = true;
			List<MinorTask> tasks = minorTaskServices.GetTasksFromMajorTask(atualMajorTask.Id);

			foreach (MinorTask mT in tasks)
			{
				valid = mT.Title != t.Title;
				if (!valid) break;
			}

			if (!valid)
			{
				MinorTaskErrorLabel.Text = "ERRO: CRIE UMA TAREFA COM NOME DIFERENTE";
				return;
			}

			// Inserir no banco de dados
			minorTaskServices.AddTask(t);
			atualMinorTask = null;
			UpdateForm();
		}

		private void DeleteMinorTaskButton_Click(object sender, EventArgs e)
		{
			if (atualMajorTask == null)
			{
				MajorTaskErrorLabel.Text = "ERRO: Nenhuma tarefa foi selecionada!";
				return;
			}
			if (atualMinorTask == null)
			{
				MinorTaskErrorLabel.Text = "ERRO: Nenhuma tarefa menor foi selecionada!";
				return;
			}

			minorTaskServices.DeleteTask(atualMinorTask);
			UpdateForm();
		}

		private void UpdateMinorTaskButton_Click(object sender, EventArgs e)
		{
			if (atualMajorTask == null)
			{
				MajorTaskErrorLabel.Text = "ERRO: Nenhuma tarefa foi selecionada!";
				return;
			}
			if (atualMinorTask == null)
			{
				MinorTaskErrorLabel.Text = "ERRO: Nenhuma tarefa menor foi selecionada!";
				return;
			}

			MinorTask request = new()
			{
				Title = MinorTaskInput.Text,
				MajorTask = atualMajorTask
			};

			minorTaskServices.UpdateTask(atualMinorTask.Id, request);
			UpdateForm();
		}


		/// <summary>
		/// Updates WinForm's view
		/// </summary>
		private void UpdateForm()
		{
			MinorTasksCheckList.Items.Clear();
			MajorTasksList.Items.Clear();

			_majorTaskController
				.GetAllTasks()
				.Data?
				.ForEach(t => MajorTasksList.Items.Add(t.Title));

			MajorTaskTitleInput.Text = atualMajorTask?.Title;
			MajorTaskDescriptionInput.Text = atualMajorTask?.Description;
			MinorTaskInput.Text = atualMinorTask?.Title;

			if (atualMajorTask == null) return;

			minorTaskServices
				.GetTasksFromMajorTask(atualMajorTask.Id)
				.ForEach(t => MinorTasksCheckList.Items.Add(t.Title));
		}

		private static void ShowMessage<T>(Response<T> r, Label label)
		{
			if (r.IsError)
			{
				label.ForeColor = Color.Red;
				label.Text = r.Message;
			}

			label.ForeColor = Color.Green;
			label.Text = r.Message;
		}
	}
}