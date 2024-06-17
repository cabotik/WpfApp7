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

namespace WpfApp7.ToolWindows
{
    /// <summary>
    /// Логика взаимодействия для ChahgeRequest.xaml
    /// </summary>
    public partial class ChahgeRequest : Window
    {
        public ChahgeRequest()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try 
            { 
            DB.MyContext mc= new DB.MyContext();
                var pr = mc.requests.SingleOrDefault(x => x.RequestId == Convert.ToInt32(tbRequestId.Text));
                if (pr != null) 
                { 
                    mc.requests.Remove(pr);
                    mc.SaveChanges();
                    MessageBox.Show("Request was delete");
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void btnFoundRequest_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DB.MyContext mc = new DB.MyContext();
                var pr = mc.requests.SingleOrDefault(x => x.RequestId == Convert.ToInt32(tbRequestId.Text));
                tbClent.Text = pr.Client.ToString();
                tbTypeOfMalfunction.Text = pr.Client.ToString();
                tbDescription.Text = pr.Description.ToString(); ;
                tbDevice.Text = pr.Device.ToString(); ;
                tbDate.Text = pr.Date.ToString(); ;
                tbStatus.Text = pr.Status.ToString(); 
                tbDepartment.Text = pr.DepartmentId.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnChangeRequest_Click(object sender, RoutedEventArgs e)
        {
            DB.MyContext mc = new DB.MyContext();
            var pr = mc.requests.SingleOrDefault(x => x.RequestId == Convert.ToInt32(tbRequestId.Text));
            if (pr != null) 
            { 
                pr.Client = tbClent.Text;
                pr.TypeOfMalfunction = tbTypeOfMalfunction.Text;
                pr.Description = tbDescription.Text;
                pr.Device = tbDevice.Text;
                pr.Date = tbDate.Text;
                pr.Status = tbStatus.Text;
                pr.DepartmentId = Convert.ToInt32(tbDepartment.Text);
                mc.requests.Update(pr);
                mc.SaveChanges();
                MessageBox.Show("Request was changed");
            }
        }
    }
}
