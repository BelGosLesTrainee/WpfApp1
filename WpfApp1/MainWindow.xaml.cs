using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Entities;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    public partial class MainWindow : Window
    {
     

        private void Button_Click(object sender, EventArgs e)
        {
          
        }

        public Question MyQuestion { get; set; }

        public MainWindow()
        {

            InitializeComponent();



            MyQuestion = new Question
            {
                id=1,
                Subject = "Охрана труда",
                Speciality = new Speciality {name = "программист"},
                    Questions = "Как часто надо слушать лекцию по охране труда?",
                Answer = new Answer { false1_answer = "один раз в год",
                                      false2_answer = "каждый день",
                                      false3_answer = "каждый квартал",
                                       true_answer = "при начале работы"
                },
                
            };
            this.DataContext = MyQuestion;
        }
    }
}
