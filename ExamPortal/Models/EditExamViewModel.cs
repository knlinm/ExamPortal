using System.ComponentModel.DataAnnotations.Schema;

namespace ExamPortal.Models
{
    public class EditExamViewModel
    {
        public int Id { get; set; } 
        public DateTime ExamDate { get; set; }
        public int Score { get; set; }
    }
}
