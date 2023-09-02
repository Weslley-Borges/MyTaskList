using MyTaskList.src.Data;
using MyTaskList.src.Models;
using MyTaskList.src.Services.MajorTaskServices;
using MyTaskList.src.Services.MinorTaskServices;
using System.Windows.Forms;

namespace MyTaskList
{
	public partial class Form1 : Form
	{
		private static readonly DataContext db = new();
		private readonly MajorTaskServices majorTaskServices = new(db);
		private readonly MinorTaskServices minorTaskServices = new(db);

		private MajorTask? atualTask = null;

		public Form1()
		{
			InitializeComponent();
			updateForm();
		}

		private void NewMajorTaskButton_Click(object sender, EventArgs e)
		{
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
			atualTask = null;
			updateForm();
		}

		private void updateForm()
		{
			MajorTaskErrorLabel.Text = "";
			MinorTaskErrorLabel.Text = "";

			MinorTasksCheckList.Items.Clear();
			MajorTasksList.Items.Clear();
			majorTaskServices
				.GetAllTasks()
				.ForEach(t => MajorTasksList.Items.Add(t.Title));

			if (atualTask == null)
			{
				MajorTaskTitleInput.Text = "";
				MajorTaskDescriptionInput.Text = "";
			}
			else
			{
				MajorTaskTitleInput.Text = atualTask.Title;
				MajorTaskDescriptionInput.Text = atualTask.Description;
				minorTaskServices
					.GetTasksFromMajorTask(atualTask.Id)?
					.ForEach(t => MinorTasksCheckList.Items.Add(t.Title));
			}
		}

		private void MinorTasksCheckList_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void MajorTasksList_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selected = MajorTasksList.SelectedItem;
			if (selected == null) return;

			var selectedTask = majorTaskServices
				.GetAllTasks()
				.Find(t => t.Title == selected.ToString());
			if (selectedTask == null) return;

			atualTask = selectedTask;
			updateForm();
		}
	}
}