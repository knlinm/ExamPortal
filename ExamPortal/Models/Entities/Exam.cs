using System.ComponentModel.DataAnnotations.Schema;

namespace ExamPortal.Models.Entities
{
    public class Exam
    {
        public int Id { get; set; }
        [Column(TypeName = "char(3)")]
        public string LessonId { get; set; }
        public virtual Lesson Lesson { get; set; }
        [Column(TypeName = "numeric(5,0)")]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public DateTime ExamDate { get; set; }
        [Column(TypeName = "numeric(1,0)")]
        public int Score { get; set; }

        
    }
}
