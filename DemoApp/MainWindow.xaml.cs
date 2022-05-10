using DemoApp.Models;
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

namespace DemoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Student>? listStd;
        private List<Faculty>? listFac;

        public MainWindow()
        {
            InitializeComponent();
            SeedData();
        }

        public void SeedData()
        {
            listStd = Student.GetStudents();
            tblStudent.ItemsSource = listStd;
            listFac = Faculty.GetFaculties();
            cbFaculty.ItemsSource = listFac;

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void cbFaculty_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cbFaculty.SelectedIndex == 0)
            {
                tblStudent.ItemsSource = listStd;
                return;
            }
            string facultyName = Convert.ToString(cbFaculty.SelectedValue)!;
            tblStudent.ItemsSource = listStd!.Where(s => s.Faculty!.Name == facultyName);
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            string name = txtName.Text;
            if(name == "")
            {
                tblStudent.ItemsSource = listStd;
                return;
            }
            tblStudent.ItemsSource = listStd!.Where(s => s.FirstName!.ToLower().Contains(name)).ToArray();
        }
    }
}
