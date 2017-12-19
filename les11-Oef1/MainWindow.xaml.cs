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

namespace les11_Oef1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DataManager dm = new DataManager();
        public MainWindow()
        {
            InitializeComponent();

            treePublishers.ItemsSource = dm.GetAllPublishers();
        }

        private void treePublishers_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            Employee employee = treePublishers.SelectedItem as Employee;

            if (employee != null)
            {
                txtFirstName.Text = employee.fname;
                txtLastName.Text = employee.lname;
                txtJob.Text = dm.GetJobByID(employee.job_id).job_desc;
            }
        }
    }
}
