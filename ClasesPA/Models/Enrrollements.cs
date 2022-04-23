using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ClasesPA.Models
{
    public class Enrrollements
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EnrrollementId { get; set; }
        public int CourseId { get; set; }
        public int StudentId {get; set;}

        //permite accede a la información
        public Course Course { get; set; }

        public Students Student { get; set; }
    }
}
