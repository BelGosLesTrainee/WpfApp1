using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Entities
{
    public class TestQuestion
    {
        [Required, Key]
        public int QuestionId { get; set; }
        public string NameQuestion { get; set; }
        public string NameSpeciality { get; set; }
        public string NameTheme { get; set; }
        public string NameAnswerIncorrect1 { get; set; }
        public string NameAnswerIncorrect2 { get; set; }
        public string NameAnswerIncorrect3 { get; set; }
        public string NameAnswerCorrect1 { get; set; }
    }
}
