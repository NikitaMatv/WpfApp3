using FormaEmp.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FormaEmp
{
    /// <summary>
    /// Логика взаимодействия для EmployeeList.xaml
    /// </summary>
    public partial class EmployeeList : Page
    {
        public EmployeeList()
        {
            InitializeComponent();
            EmpList.ItemsSource = DbConnect.db.Employee.ToList();
        }
        private void EmpList_SelectedItem(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
                selected.Text = e.SelectedItem.ToString();
            ((ListView)sender).SelectedItem = null;
        }

    }
}
