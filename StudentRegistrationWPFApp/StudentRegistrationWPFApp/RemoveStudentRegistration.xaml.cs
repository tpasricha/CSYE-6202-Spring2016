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

namespace StudentRegistrationWPFApp
{
    /// <summary>
    /// Interaction logic for RemoveStudentRegistration.xaml
    /// </summary>
    public partial class RemoveStudentRegistration : Window
    {
        private Student student;
        private List<Student> studentList;
        private string[] departmentNames;
        public RemoveStudentRegistration(Student s, List<Student> sl)
        {
            this.student = s;
            this.studentList = sl;
            InitializeComponent();
            LoadDepttComboBox();
            txtStuId.Text = student.studentId;
            txtFirst.Text = student.firstName;
            txtLast.Text = student.lastName;
            comboBoxDepptt.Text = student.departmentName;
            if (radioFull.Content.Equals(student.enrollmentType))
            {
                radioFull.IsChecked = true;
            }
            else
            {
                radioPart.IsChecked = true;
            }
            radioFull.IsEnabled = false;
            txtStuId.IsEnabled = false;
            comboBoxDepptt.IsEnabled = false;
            txtFirst.IsEnabled = false;
            txtLast.IsEnabled = false;
            radioPart.IsEnabled = false;
        }

        public void LoadDepttComboBox()
        {
            departmentNames = new[] { "Information Systems", "International Affairs", "Nursing", "Pharmacy", "Professional Studies", "Psychology", "Public Administration" };
            foreach(string str in departmentNames)
            {
                comboBoxDepptt.Items.Add(str);
            }
        }

       private void btnRemove_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult warning = MessageBox.Show("Are you sure you want to remove this student?", "Remove Student Warning Page", MessageBoxButton.YesNo);
            if (warning == MessageBoxResult.Yes)
            {
                studentList.Remove(student);
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void btnCancel_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

