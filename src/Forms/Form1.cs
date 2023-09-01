using MyTaskList.src.Data;
using MyTaskList.src.Models;
using MyTaskList.src.Services.MajorTaskServices;

namespace MyTaskList
{
    public partial class Form1 : Form
    {
        private static readonly DataContext db = new();
        private readonly MajorTaskServices majorTaskServices = new(db);

        public int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MajorTask t = new() {Title = $"Eita_{count}", Description = "Vish" };
            majorTaskServices.AddTask(t);

            var ts = majorTaskServices.GetTask(t.Id);
            if (ts != null)
                textBox1.Text = ts.Title;

            majorTaskServices.DeleteTask(t);
            count++;
        }
    }
}