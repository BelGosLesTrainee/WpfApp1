using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Entities
{
    class Question
    {
        
        public int id { get; set; }
        public string Subject { get; set; }
        public Speciality Speciality { get; set; }
        public string Questions { get; set; }
        public Answer Answer { get; set; }

        public List<Question> Specialitys { get; set; } = new List<Question>();

    }
}
