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
using WpfApp7.DB;
using WpfApp7.UsersWindows;

namespace WpfApp7.ToolWindows
{
    /// <summary>
    /// Логика взаимодействия для AddRequest.xaml
    /// </summary>
    public partial class AddRequest : Window
    {
 
        public AddRequest()
        {
            InitializeComponent();

        }

        private void btnAddRequest_Click(object sender, RoutedEventArgs e)
        {
            try
                {
                    DB.MyContext mc = new DB.MyContext();
                    DB.Request newrequest = new DB.Request()
                    {
                        Client = tbClent.Text,
                        TypeOfMalfunction = tbTypeOfMalfunction.Text,
                        Description = tbDescription.Text,
                        Device = tbDevice.Text,
                        Date = tbDate.Text,
                        Status = tbStatus.Text,
                        DepartmentId =Convert.ToInt32(tbDepartment.Text)
                    };
                    try
                    {
                        mc.requests.Add(newrequest);
                        mc.SaveChanges();
                        MessageBox.Show("Request was added");
                    }
                    catch { MessageBox.Show("Request wasnt added"); }

                }
                catch (Exception ex)
                { MessageBox.Show(ex.ToString()); }

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MenagerWindow menagerWindow = new MenagerWindow();
            menagerWindow.Show();
            Close();
        }   
    }
}
