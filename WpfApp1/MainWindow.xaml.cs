using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using WpfApp1.Entities;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    public partial class MainWindow : Window
    {

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            add_Question Add_Question = new add_Question();
            Add_Question.Show();

        }

        public Question MyQuestion { get; set; }

        public MainWindow()
        {

            InitializeComponent();



            MyQuestion = new Question
            {
                Id_Question = 1,
                Subject = "Охрана труда",
                Speciality = new Speciality {Name = "программист"},
                    Questions = "Как часто надо слушать лекцию по охране труда?",
                Answer = new Answer { False1_answer = "один раз в год",
                                      False2_answer = "каждый день",
                                      False3_answer = "каждый квартал",
                                      True_answer = "при начале работы"
                },
                
            };
            this.DataContext = MyQuestion;
        }
    }
}
