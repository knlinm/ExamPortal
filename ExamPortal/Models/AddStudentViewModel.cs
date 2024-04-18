using System.ComponentModel.DataAnnotations.Schema;

namespace ExamPortal.Models
{
    public class AddStudentViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Class { get; set; }
    }
}
