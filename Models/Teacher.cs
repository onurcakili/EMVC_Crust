namespace EFMVC_odev.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public int TeacherName { get; set;}
        public int TeacherAddress { get; set; } 
        public int TeacherAge { get; set; }

        // ögrt - ögr ilişkileri tanımlandı -> N:N
        // public List<Subject> TeacherSubjects { get; set; } = new List<Subject>();  

        public Subject Subject { get; set; }    // N:1
    }
}
