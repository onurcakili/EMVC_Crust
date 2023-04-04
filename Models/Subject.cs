using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFMVC_odev.Models
{
    

    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }  //minlenght veya notnull vb. için "required" gibi seçenekler eklenebilir
        public string SubjectTerm { get; set; }
        public string SubjectCredets { get; set; }

        //public List<Teacher> SubjectTeachers { get; set; } = new List<Teacher>();  //ilişkiler tanımlandı ogr-ogretmen - > N:N  

        public Teacher Teacher{ get; set; }    // N:1

    }
}
