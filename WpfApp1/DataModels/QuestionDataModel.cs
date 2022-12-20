using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DataModels
{
    class QuestionDataModel
    {
        public int id { get; set; }
        public string Subject { get; set; }
        public SpecialityDataModel Speciality { get; set; }
        public string Questions { get; set; }
        public AnswerDataModel Answer { get; set; }

        public List<QuestionDataModel> Specialitys { get; set; } = new List<QuestionDataModel>();

    }
}
