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

		private MajorTask? atualTask = null;

		public Form1()
		{
			InitializeComponent();
		}

		private void NewMajorTaskButton_Click(object sender, EventArgs e)
		{
			MajorTask t = new()
			{
				Title = MajorTaskTitleInput.Text,
				Description = MajorTaskDescriptionInput.Text
			};

			majorTaskServices.AddTask(t);
			MajorTasksList.Items.Add($"{MajorTaskTitleInput.Text} - {MajorTaskDescriptionInput.Text}");

			atualTask = null;

			majorTaskServices.DeleteTask(t);
			updateForm();
		}

		private void updateForm()
		{
			MinorTasksCheckList.Items.Clear();
			MajorTasksList.Items.Clear();
			majorTaskServices
				.GetAllTasks()
				.ForEach(t => MajorTasksList.Items.Add(t));

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
			
		}
	}
}