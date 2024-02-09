using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppStudent_Marks.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int SubjectId {  get; set; }
        public int Marks {  get; set; }

    }
}
