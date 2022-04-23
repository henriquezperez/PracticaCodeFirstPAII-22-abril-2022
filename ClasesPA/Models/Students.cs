using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClasesPA.Models
{
    public class Students
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }

        public string FirtsName { get; set; }

        public string LastName { get; set; }

        public DateTime EnrrollementDate { get; set; }

        public ICollection<Enrrollements> Enrrollements { get; set; }


    }
}
