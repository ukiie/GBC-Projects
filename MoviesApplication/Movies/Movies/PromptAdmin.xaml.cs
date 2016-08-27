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
using System.Windows.Shapes;

namespace Movies
{
    /// <summary>
    /// Interaction logic for PromptAdmin.xaml
    /// </summary>
    public partial class PromptAdmin : Window
    {
        public PromptAdmin()
        {
            InitializeComponent();

            Prompt_Wrong.Visibility = System.Windows.Visibility.Hidden;
            Prompt_Password.Focus();

            
        }

        private void Prompt_Confirm_Click(object sender, RoutedEventArgs e)
        {
            string pass = Prompt_Password.Password;
            if (pass == "admin")
            {
                AdminView av = new AdminView();
                av.Show();
                Close();
                
            }
            else {
                Prompt_Password.Clear();
                Prompt_Wrong.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void Prompt_Back_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
