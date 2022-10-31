using System.ComponentModel.DataAnnotations;

namespace StudentsAPI_Test.Models
{
    public class Group
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
