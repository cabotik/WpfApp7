using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfApp7.View;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WpfApp7.ToolWindows
{
    /// <summary>
    /// Логика взаимодействия для RequestList.xaml
    /// </summary>
    public partial class RequestList 
    {
        public ObservableCollection<View.RequestView> RequestViews { get; set; }
        public RequestList()
        {
            InitializeComponent();
            BindDataGridRequests();
        }
        public void BindDataGridRequests()
        {          
            DB.MyContext mc = new DB.MyContext();
            RequestViews = new ObservableCollection<RequestView>();
            foreach (var i in mc.requests)
            {
                RequestViews.Add(new RequestView()
                {
                    RequestId = i.RequestId,
                    Client = i.Client,
                    TypeOfMalfunction = i.TypeOfMalfunction,
                    Description = i.Description,
                    Device = i.Device,
                    Date = i.Date,
                    Status = i.Status,
                    DepartmentId = i.DepartmentId
                });
            }
            dgRequests.ItemsSource = RequestViews;
        }
        private void btnRefreash_Click(object sender, RoutedEventArgs e)
        {
            BindDataGridRequests();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            UsersWindows.MenagerWindow menagerWindow = new UsersWindows.MenagerWindow();
            menagerWindow.Show();   
            Close();
        }
    }
}
