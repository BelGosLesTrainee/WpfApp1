using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Entities
{
   public class Answer
    {
        [Required, Key]
        public int Id_Answer { get; set; }
        public string False1_answer { get; set; }
        public string True_answer { get; set; }
        public string False2_answer { get; set; }
        public string False3_answer { get; set; }
    }
}

