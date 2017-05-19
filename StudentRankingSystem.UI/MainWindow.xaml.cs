using StudentRankingSystem.DAL;
using StudentRankingSystem.DAL.Context;
using StudentRankingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace StudentRankingSystem.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var loginWindow = new Login();
            loginWindow.ShowDialog();

            if (!(loginWindow.DialogResult.HasValue && loginWindow.DialogResult.Value))
            {
                this.Close();
                return;
            }
        }
      
        private void button_Click(object sender, RoutedEventArgs e)
        {

            using (StudentRankingSystemContext db = new StudentRankingSystemContext())
            {

                
                var users = db.Users;
                

                foreach (var u in users)
                {
                    MessageBox.Show(u.Login.ToString() + $" {u.Password} ");
                }
            }
        }
        
    }
}
