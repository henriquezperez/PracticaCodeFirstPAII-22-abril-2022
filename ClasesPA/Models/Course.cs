using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClasesPA.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int CourseId { get; set; }

        public string Title { get; set; }

        public int Credit { get; set; }

        public ICollection<Enrrollements> Enrrollements { get; set; }
    }
}
