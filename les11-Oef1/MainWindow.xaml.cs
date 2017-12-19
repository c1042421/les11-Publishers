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
            cmbJob.ItemsSource = dm.GetAllJob();
            cmbJob.DisplayMemberPath = "job_desc";
        }

        private void treePublishers_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            Employee employee = treePublishers.SelectedItem as Employee;

            if (employee != null)
            {
                txtId.Text = employee.emp_id;
                txtFirstName.Text = employee.fname;
                txtLastName.Text = employee.lname;
                cmbJob.SelectedIndex = employee.job_id;
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            dm.UpdateEmployee(GetEmployeeFromTextBoxes());
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            dm.InsertEmployee(GetEmployeeFromTextBoxes());
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            dm.DeleteEmployee(GetEmployeeFromTextBoxes());
        }

        private Employee GetEmployeeFromTextBoxes()
        {
            return new Employee()
            {
                emp_id = txtId.Text,
                fname = txtFirstName.Text,
                lname = txtLastName.Text,
                job_id = (short)cmbJob.SelectedIndex
            };
        }
    }
}
