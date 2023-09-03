using MyTaskList.src.Data;
using MyTaskList.src.Models;
using MyTaskList.src.Controllers;
using MyTaskList.src.Services.MajorTaskServices;
using MyTaskList.src.Services.MinorTaskServices;

namespace MyTaskList
{
	public partial class Form1 : Form
	{
		private readonly MajorTaskController _majorTaskController;
		private readonly MinorTaskController _minorTaskController;
		private readonly DataContext db = new();

		private MajorTask? atualMajorTask;
		private MinorTask? atualMinorTask;

		public Form1()
		{
			_majorTaskController = new MajorTaskController(new MajorTaskServices(db));
			_minorTaskController = new MinorTaskController(new MinorTaskServices(db));

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

		// ----- MinorTasks Events
		private void MinorTasksCheckList_SelectedIndexChanged(object sender, EventArgs e)
		{
			string? selected = MinorTasksCheckList.SelectedItem?.ToString();

			atualMinorTask = _minorTaskController
				.GetAllTasks()
				.Data?
				.Find(t => t?.Title == selected && t?.MajorTask == atualMajorTask);

			UpdateForm();
		}

		private void NewMinorTaskButton_Click(object sender, EventArgs e)
		{
			Response<MinorTask> result = _minorTaskController.NewMinorTask(
				atualMajorTask,
				MinorTaskInput.Text);

			if (!result.IsError)
				atualMinorTask = null;

			UpdateForm();
			ShowMessage(result, MinorTaskErrorLabel);
		}

		private void DeleteMinorTaskButton_Click(object sender, EventArgs e)
		{
			Response<MinorTask> result = _minorTaskController.DeleteMinorTask(atualMinorTask);

			if (!result.IsError)
				atualMinorTask = null;

			UpdateForm();
			ShowMessage(result, MinorTaskErrorLabel);
		}

		private void UpdateMinorTaskButton_Click(object sender, EventArgs e)
		{

			Response<MinorTask> result = _minorTaskController.UpdateMinorTask(
				atualMinorTask, MinorTaskInput.Text);

			if (!result.IsError)
				atualMinorTask = null;

			UpdateForm();
			ShowMessage(result, MinorTaskErrorLabel);
		}


		/// <summary>
		/// Updates WinForm's view
		/// </summary>
		private void UpdateForm()
		{
			MinorTaskErrorLabel.Text = "";
			MajorTaskErrorLabel.Text = "";
			MinorTasksCheckList.Items.Clear();
			MajorTasksList.Items.Clear();

			_majorTaskController
				.GetAllTasks()
				.Data?
				.ForEach(t => MajorTasksList.Items.Add(t.Title));

			MajorTaskTitleInput.Text = atualMajorTask?.Title;
			MajorTaskDescriptionInput.Text = atualMajorTask?.Description;
			MinorTaskInput.Text = atualMinorTask?.Title;

			if (atualMajorTask == null)
			{
				MinorTasksCheckList.Visible = false;
				MinorTaskInput.Visible = false;
				MinorTaskLabel.Visible = false;
				NewMinorTaskButton.Visible = false;
				DeleteMinorTaskButton.Visible = false;
				UpdateMinorTaskButton.Visible = false;
				MinorTasksListLabel.Visible = false;
				DoneCheckbox.Visible = false;

				return;
			}

			MinorTasksListLabel.Visible = true;
			MinorTasksCheckList.Visible = true;
			MinorTaskLabel.Visible = true;
			MinorTaskInput.Visible = true;
			NewMinorTaskButton.Visible = true;
			DeleteMinorTaskButton.Visible = true;
			UpdateMinorTaskButton.Visible = true;
			DoneCheckbox.Visible = true;

			int idx = 0;
			_minorTaskController
				.GetAllTasksfromMajorTask(atualMajorTask.Id)
				.Data?
				.ForEach(t =>
				{
					MinorTasksCheckList.Items.Add(t.Title);
					CheckState st = t.Done ? CheckState.Checked : CheckState.Unchecked;

					MinorTasksCheckList.SetItemCheckState(idx, st);
					idx++;
				}
			);

			if (atualMinorTask == null) return;

			DoneCheckbox.Checked = atualMinorTask.Done;
		}

		private void DoneCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			if (atualMinorTask == null)
				return;

			_minorTaskController.CheckAsDone(atualMinorTask);
			UpdateForm();
		}

		private static void ShowMessage<T>(Response<T> r, Label label)
		{
			if (r.IsError)
			{
				label.ForeColor = Color.Red;
				label.Text = r.Message;
			}
			else
			{
				label.ForeColor = Color.Green;
				label.Text = r.Message;
			}
		}
	}
}