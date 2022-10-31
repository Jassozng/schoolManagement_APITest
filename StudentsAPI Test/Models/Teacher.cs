namespace StudentsAPI_Test.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public string RFC { get; set; }
    }
}
