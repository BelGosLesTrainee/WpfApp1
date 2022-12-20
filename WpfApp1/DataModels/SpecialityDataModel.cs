using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DataModels
{
    class SpecialityDataModel
    {
        public string name { get; set; }

        public List<SpecialityDataModel> Questions { get; set; } = new List<SpecialityDataModel>();

    }
}
