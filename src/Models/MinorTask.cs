namespace MyTaskList.src.Models
{
    internal class MinorTask
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public bool Done { get; set; } = false;
    }
}
