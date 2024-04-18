using ExamPortal.Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamPortal.Models
{
    public class AddExamViewModel
    {
        public int Id { get; set; }
        public string LessonId { get; set; }
        public int StudentId { get; set; }
        public DateTime ExamDate { get; set; }
        public int Score { get; set; }

    }
}
