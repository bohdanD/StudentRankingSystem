using StudentRankingSystem.DAL;
using StudentRankingSystem.DAL.Context;
using StudentRankingSystem.DAL.RetrievingData;
using StudentRankingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data;
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Retriever retriever = new Retriever();
            dataGrid.ItemsSource = retriever.GetAverageScores();
            dataGrid_2.ItemsSource = retriever.GetStudentsData();     
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
