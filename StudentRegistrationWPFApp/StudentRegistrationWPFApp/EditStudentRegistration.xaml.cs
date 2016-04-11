using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for EditStudentRegistration.xaml
    /// </summary>
    public partial class EditStudentRegistration : Window
    {
        private Student student;
        private List<Student> studentList;
        private string[] departmentNames;
        public EditStudentRegistration(Student s, List<Student> sl, string[] depttNames)
        {
            this.student = s;
            this.studentList = sl;
            this.departmentNames = depttNames;
            InitializeComponent();
            LoadDepttComboBox();
            comboBoxDeptt.SelectedIndex = 0;
            txtStuId.Text = student.studentId;
            txtFirst.Text = student.firstName;
            txtLast.Text = student.lastName;
            string deptt = student.departmentName;
            if (radioFull.Content.Equals(student.enrollmentType))
            {
                radioFull.IsChecked = true;
            }
            else
            {
                radioPart.IsChecked = true;
            }
            for (int i = 0; i < departmentNames.Count(); i++)
            {
                if (departmentNames[i].Equals(deptt))
                {
                    comboBoxDeptt.SelectedIndex = i;
                    break;
                }
            }
        }

        public void LoadDepttComboBox()
        {
            departmentNames = new[] { "Information Systems", "International Affairs", "Nursing", "Pharmacy", "Professional Studies", "Psychology", "Public Administration" };
            foreach (string str in departmentNames)
            {
                comboBoxDeptt.Items.Add(str);
            }
        }

          private void btnUpdate_Click_1(object sender, RoutedEventArgs e)
        {
            string studentId = txtStuId.Text;
            string firstName = txtFirst.Text;
            string lastName = txtLast.Text;
            if (studentId == "" || studentId.Trim().Equals("") || firstName == "" || firstName.Trim().Equals("") || lastName == "" || lastName.Trim().Equals(""))
            {
                MessageBox.Show("Please fill in all the fields", "Edit Student Warning Page", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                string enrollmentType;
                if ((bool)radioFull.IsChecked)
                {
                    enrollmentType = "Full Time";
                }
                else enrollmentType = "Part Time";
                if (Regex.IsMatch(studentId, @"^\d{3}-\d{2}-\d{4}$") && Regex.IsMatch(firstName, @"^[A-Za-z]+$") && Regex.IsMatch(firstName, @"^[A-Za-z]+$"))
                {
                    MessageBoxResult warning = MessageBox.Show("Are you sure you want to update this student?", "Edit Student Warning Page", MessageBoxButton.YesNo, MessageBoxImage.Information);
                    if (warning == MessageBoxResult.Yes)
                    {
                        student.studentId = studentId;
                        student.firstName = firstName;
                        student.lastName = lastName;
                        student.departmentName = comboBoxDeptt.Text;
                        student.enrollmentType = enrollmentType;
                        this.Close();
                    }
                    else if (warning == MessageBoxResult.No)
                    {
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid format of the input!!", "New Student Warning Page", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        private void btnCancel_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
    }


