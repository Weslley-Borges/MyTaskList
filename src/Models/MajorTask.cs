namespace MyTaskList.src.Models
{
	internal class MajorTask
	{
		public int Id { get; set; }
		public required string Title { get; set; }
		public required string Description { get; set; }
		public bool Done { get; set; } = false;
		public List<MinorTask> MinorTasks { get; set; } = new List<MinorTask> { };
	}
}
