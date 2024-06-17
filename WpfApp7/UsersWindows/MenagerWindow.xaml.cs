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

namespace WpfApp7.UsersWindows
{
    /// <summary>
    /// Логика взаимодействия для MenagerWindow.xaml
    /// </summary>
    public partial class MenagerWindow : Window
    {
        public MenagerWindow()
        {
            InitializeComponent();
        }

        private void btnAddRequest_Click(object sender, RoutedEventArgs e)
        {
            ToolWindows.AddRequest addRequest = new ToolWindows.AddRequest();
            addRequest.Show();
            Close();
        }

        private void bntChangeRequest_Click(object sender, RoutedEventArgs e)
        {
            ToolWindows.ChahgeRequest chahgeRequest = new ToolWindows.ChahgeRequest();
            chahgeRequest.Show();   
            Close();
        }

        private void btnSatistics_Click(object sender, RoutedEventArgs e)
        {
            //DB.MyContext mc = new DB.MyContext();
            //foreach(int val in mc.requests.Status.Distinct)
            //{ }
            //foreach (int val in a.Distinct())
            //{
            //    Console.WriteLine(val + " - " + a.Where(x => x == val).Count() + " раз");
            //}

        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            ToolWindows.RequestList requestList = new ToolWindows.RequestList();
            requestList.Show();
            Close();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
