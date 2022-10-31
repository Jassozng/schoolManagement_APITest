using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentsAPI_Test.Models
{
    public class Coordinator
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public string RFC { get; set; }
    }
}
