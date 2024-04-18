using System.ComponentModel.DataAnnotations.Schema;

namespace ExamPortal.Models.Entities
{
    public class Student
    {
        [Column(TypeName = "numeric(5,0)")]
        public int Id { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string Name { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string Surname { get; set; }
        [Column(TypeName = "numeric(2,0)")]
        public int Class { get; set;}

    }
}
