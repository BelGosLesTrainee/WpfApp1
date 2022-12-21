using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Entities
{
    public class Question
    {
        [Required, Key]
        public int Id_Question { get; set; }
        public string Subject { get; set; }
        //public Speciality Speciality { get; set; }
        public string Questions { get; set; }
        public Answer Answer { get; set; }

        public List<Question> Specialitys { get; set; } = new List<Question>();

    }
}
