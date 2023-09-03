using MyTaskList.src.Data;
using MyTaskList.src.Models;
using MyTaskList.src.Services.MajorTaskServices;
using MyTaskList.src.Services.MinorTaskServices;

namespace MyTaskList
{
	public partial class Form1 : Form
	{
		private static readonly DataContext db = new();
		private readonly MajorTaskServices majorTaskServices = new(db);
		private readonly MinorTaskServices minorTaskServices = new(db);

		private MajorTask? atualMajorTask;
		private MinorTask? atualMinorTask;

		public Form1()
		{
			InitializeComponent();
			UpdateForm();
		}

		private void NewMajorTaskButton_Click(object sender, EventArgs e)
		{
			if (MajorTaskTitleInput.Text == "" || MajorTaskDescriptionInput.Text == "")
			{
				MajorTaskErrorLabel.Text = "ERRO: Preencha os campos 'Título' e 'Descrição'";
				return;
			}

			MajorTask t = new()
			{
				Title = MajorTaskTitleInput.Text,
				Description = MajorTaskDescriptionInput.Text
			};

			// Validar
			bool valid = true;
			List<MajorTask> tasks = majorTaskServices.GetAllTasks();

			foreach (MajorTask mT in tasks)
			{
				valid = mT.Title != t.Title;
				if (!valid) break;
			}

			if (!valid)
			{
				MajorTaskErrorLabel.Text = "ERRO: CRIE UMA TAREFA COM NOME DIFERENTE";
				return;
			}

			// Inserir no banco de dados
			majorTaskServices.AddTask(t);
			atualMajorTask = null;
			UpdateForm();
		}

		/// <summary>
		/// Updates WinForm's view
		/// </summary>
		private void UpdateForm()
		{
			MajorTaskErrorLabel.Text = "";
			MinorTaskErrorLabel.Text = "";
			MinorTasksCheckList.Items.Clear();
			MajorTasksList.Items.Clear();

			majorTaskServices
				.GetAllTasks()
				.ForEach(t => MajorTasksList.Items.Add(t.Title));

			MajorTaskTitleInput.Text = atualMajorTask?.Title;
			MajorTaskDescriptionInput.Text = atualMajorTask?.Description;
			MinorTaskInput.Text = atualMinorTask?.Title;

			if (atualMajorTask == null) return;

			minorTaskServices
				.GetTasksFromMajorTask(atualMajorTask.Id)
				.ForEach(t => MinorTasksCheckList.Items.Add(t.Title));
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

		private void MajorTasksList_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selected = MajorTasksList.SelectedItem;
			if (selected == null) return;

			var selectedTask = majorTaskServices
				.GetAllTasks()
				.Find(t => t?.Title == selected.ToString());
			if (selectedTask == null) return;

			atualMajorTask = selectedTask;
			atualMinorTask = null;
			UpdateForm();
		}

		private void DeleteMajorTaskButton_Click(object sender, EventArgs e)
		{
			if (atualMajorTask == null)
			{
				MajorTaskErrorLabel.Text = "ERRO: Nenhuma tarefa foi selecionada!";
				return;
			}

			majorTaskServices.DeleteTask(atualMajorTask);
			atualMajorTask = null;
			UpdateForm();
		}

		private void UpdateMajorTaskButton_Click(object sender, EventArgs e)
		{
			if (atualMajorTask == null)
			{
				MajorTaskErrorLabel.Text = "ERRO: Nenhuma tarefa foi selecionada!";
				return;
			}

			MajorTask request = new()
			{
				Title = MajorTaskTitleInput.Text,
				Description = MajorTaskDescriptionInput.Text
			};

			majorTaskServices.UpdateTask(atualMajorTask.Id, request);
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
	}
}