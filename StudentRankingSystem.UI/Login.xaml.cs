using StudentRankingSystem.DAL.Context;
using StudentRankingSystem.Entities;

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

namespace StudentRankingSystem.UI
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            var login = textBoxLogin.Text;
            var password = Other.Hashing.Encryptor.GetMD5Hash(textBoxPassword.Text);
        
            using (StudentRankingSystemContext db = new StudentRankingSystemContext())
            {              
                var users = db.Users;
                foreach (var u in users)
                {
                 //   MessageBox.Show(u.Login.ToString() + $" {u.Password} ");
                }
                foreach (var s in db.Scores)
                {
                  //  MessageBox.Show(s.ScoreId.ToString() + $"{s.CourseId}, { s.FinalScore}, {s.StudentId}  ");
                }
                User user = users.Where(u => (u.Login == login) && (u.Password == password)).Select(u => u).SingleOrDefault<User>();

                if (user == null)
                {
                    MessageBox.Show(this, "Invalid user name or password", "Authentication Error");
                }
                else
                {                    
                    DialogResult = true;
                }
                
            }
          
        }
    }
}
