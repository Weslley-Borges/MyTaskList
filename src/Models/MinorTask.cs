using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTaskList.src.Models
{
    internal class MinorTask
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public required string Title { get; set; }
        public bool Done { get; set; } = false;
        public required MajorTask MajorTask { get; set; }
    }
}
