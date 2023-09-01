using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTaskList.src.Models
{
	internal class MajorTask
	{
		[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public required string Title { get; set; }

        [Required]
        [MaxLength(300)]
        public required string Description { get; set; }
		public bool Done { get; set; } = false;
		public List<MinorTask> MinorTasks { get; set; } = new List<MinorTask> { };
	}
}
