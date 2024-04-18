using System.ComponentModel.DataAnnotations.Schema;

namespace ExamPortal.Models.Entities
{
    public class Lesson
    {
        [Column(TypeName = "char(3)")]
        public string Id {  get; set; }
        [Column(TypeName = "varchar(30)")]
        public string Name { get; set; }
        [Column(TypeName = "numeric(2,0)")]
        public int Class {  get; set; }
        [Column(TypeName = "varchar(20)")]
        public string TeachersName { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string TeachersSurname { get; set; }

        public Lesson()
        {
            Id = Guid.NewGuid().ToString().Substring(1,3);
        }
    }
}
