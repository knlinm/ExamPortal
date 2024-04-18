using System.ComponentModel.DataAnnotations.Schema;

namespace ExamPortal.Models
{
    public class AddLessonViewModel
    {
        public string Name { get; set; }
        public int Class { get; set; }
        public string TeachersName { get; set; }
        public string TeachersSurname { get; set; }
    }
}
