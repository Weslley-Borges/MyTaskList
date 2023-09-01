using MyTaskList.src.Data;
using MyTaskList.src.Models;
using MyTaskList.src.Services.MajorTaskServices;

namespace MyTaskList
{
    public partial class Form1 : Form
    {
        private static readonly DataContext db = new();
        private readonly MajorTaskServices majorTaskServices = new(db);

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
            MajorTaskTitleInput.Text = "";
            MajorTaskDescriptionInput.Text = "";

            majorTaskServices.DeleteTask(t);
        }

    }
}