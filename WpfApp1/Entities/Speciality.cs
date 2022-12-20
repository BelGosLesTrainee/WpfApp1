using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Entities
{
   public class Speciality
    {
        [Required, Key]
        public int Id_Speciality { get; set; }
        public string Name { get; set; }

        public List<Speciality> Questions { get; set; } = new List<Speciality>();


    }
}
