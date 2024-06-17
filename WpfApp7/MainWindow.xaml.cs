using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbLogin.Text))
            {
                MessageBox.Show("Enter login");
                return;
            }
            if (string.IsNullOrWhiteSpace(pbPass.Password))
            {
                MessageBox.Show("Enter password");
                return;
            }
            Authorization();
        }
        private void Authorization()
        {
            try
            { 
                DB.MyContext mc = new DB.MyContext();
                if(mc.users.Any(x=> x.UserLogin == tbLogin.Text && x.UserPassword == pbPass.Password))
                {
                    var user = mc.users.SingleOrDefault(x => x.UserLogin == tbLogin.Text && x.UserPassword == pbPass.Password);
                        switch (user.UserRole)
                        {
                        case "admin":
                            MessageBox.Show($"{user.UserName}, welcome to system");
                            break;
                        case "menager":
                            MessageBox.Show($"{user.UserName}, welcome to system");
                            UsersWindows.MenagerWindow menagerWindow = new UsersWindows.MenagerWindow();
                            menagerWindow.Show();
                            Close();
                            break;
                        case "user":
                            MessageBox.Show($"{user.UserName}, welcome to system");
                            break;
                    }
                }
                else { MessageBox.Show("User dont found of inccorect data. Try again."); }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}