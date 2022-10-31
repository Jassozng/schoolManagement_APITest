using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentsAPI_Test.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [ForeignKey("GroupId")]
        public virtual Group? Group { get; set; }
        public string SchoolarID { get; set; }
    }
}
