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
using System.IO;
using System.Diagnostics;

namespace BPA_State_2022
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int question_count = 0;
        public int question_count_correct = 0;
        public string[] question_list = System.IO.File.ReadAllLines(@".\quizquestion.txt");
        public MainWindow()
        {
            InitializeComponent();
            //MessageBox.Show("What up World?");

            #region Sample Read/Write from Text File.
            

            //MessageBox.Show(question_list[2]);
            #endregion
            if (question_count == 0)
            {
                btnNext.IsEnabled = false;
                string[] question = question_list[0].Split(',');
                txtQuestion.Content = question[0];
                rdoAnswer1.Content = question[1];
                rdoAnswer2.Content = question[2];
                rdoAnswer3.Content = question[3];
                rdoAnswer4.Content = question[4];
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            question_count++;
            if (question_count == 1)
            {
                resetquiz();
                string[] question = question_list[1].Split(',');
                txtQuestion.Content = question[0];
                rdoAnswer1.Content = question[1];
                rdoAnswer2.Content = question[2];
                rdoAnswer3.Content = question[3];
                rdoAnswer4.Content = question[4];
            }
            if (question_count == 2)
            {
                resetquiz();
                string[] question = question_list[2].Split(',');
                txtQuestion.Content = question[0];
                rdoAnswer1.Content = question[1];
                rdoAnswer2.Content = question[2];
                rdoAnswer3.Content = question[3];
                rdoAnswer4.Content = question[4];
            }
            if (question_count == 3)
            {
                resetquiz();
                string[] question = question_list[3].Split(',');
                txtQuestion.Content = question[0];
                rdoAnswer1.Content = question[1];
                rdoAnswer2.Content = question[2];
                rdoAnswer3.Content = question[3];
                rdoAnswer4.Content = question[4];
            }
            if (question_count == 4)
            {
                resetquiz();
                string[] question = question_list[4].Split(',');
                txtQuestion.Content = question[0];
                rdoAnswer1.Content = question[1];
                rdoAnswer2.Content = question[2];
                rdoAnswer3.Content = question[3];
                rdoAnswer4.Content = question[4];
            }
            if (question_count == 5)
            {
                resetquiz();
                string[] question = question_list[5].Split(',');
                txtQuestion.Content = question[0];
                rdoAnswer1.Content = question[1];
                rdoAnswer2.Content = question[2];
                rdoAnswer3.Content = question[3];
                rdoAnswer4.Content = question[4];
            }
            if (question_count == 6)
            {
                MessageBox.Show("Thanks for playing! You got " + question_count_correct + " questions correct.");
                Close();
            }
        }
        private void resetquiz() {
            btnNext.IsEnabled = false;
            btnSubmit.IsEnabled = true;
            rdoAnswer1.IsEnabled = true;
            rdoAnswer2.IsEnabled = true;
            rdoAnswer3.IsEnabled = true;
            rdoAnswer4.IsEnabled = true;
            rdoAnswer1.IsChecked = false;
            rdoAnswer2.IsChecked = false;
            rdoAnswer3.IsChecked = false;
            rdoAnswer4.IsChecked = false;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (question_count == 0) { 
                if(rdoAnswer1.IsChecked== true)
                {
                    question_count_correct++;
                }
                rdoAnswer2.IsEnabled = false;
                rdoAnswer3.IsEnabled = false;
                rdoAnswer4.IsEnabled = false;
                btnSubmit.IsEnabled = false;
                btnNext.IsEnabled= true;
            }
            if (question_count == 1)
            {
                if (rdoAnswer3.IsChecked == true)
                {
                    question_count_correct++;
                }
                rdoAnswer1.IsEnabled = false;
                rdoAnswer2.IsEnabled = false;
                rdoAnswer4.IsEnabled = false;
                btnSubmit.IsEnabled = false;
                btnNext.IsEnabled = true;
            }
            if (question_count == 2)
            {
                if (rdoAnswer4.IsChecked == true)
                {
                    question_count_correct++;
                }
                rdoAnswer1.IsEnabled = false;
                rdoAnswer2.IsEnabled = false;
                rdoAnswer3.IsEnabled = false;
                btnSubmit.IsEnabled = false;
                btnNext.IsEnabled = true;
            }
            if (question_count == 3)
            {
                if (rdoAnswer1.IsChecked == true)
                {
                    question_count_correct++;
                }
                rdoAnswer2.IsEnabled = false;
                rdoAnswer3.IsEnabled = false;
                rdoAnswer4.IsEnabled = false;
                btnSubmit.IsEnabled = false;
                btnNext.IsEnabled = true;
            }
            if (question_count == 4)
            {
                if (rdoAnswer2.IsChecked == true)
                {
                    question_count_correct++;
                }
                rdoAnswer1.IsEnabled = false;
                rdoAnswer3.IsEnabled = false;
                rdoAnswer4.IsEnabled = false;
                btnSubmit.IsEnabled = false;
                btnNext.IsEnabled = true;
            }
            if (question_count == 5)
            {
                if (rdoAnswer2.IsChecked == true)
                {
                    question_count_correct++;
                }
                rdoAnswer1.IsEnabled = false;
                rdoAnswer3.IsEnabled = false;
                rdoAnswer4.IsEnabled = false;
                btnSubmit.IsEnabled = false;
                btnNext.IsEnabled = true;
            }
        }
    }
}
