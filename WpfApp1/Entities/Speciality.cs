using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Entities
{
    class Speciality
    {

        public string name { get; set; }

        public List<Speciality> Questions { get; set; } = new List<Speciality>();


    }
}
