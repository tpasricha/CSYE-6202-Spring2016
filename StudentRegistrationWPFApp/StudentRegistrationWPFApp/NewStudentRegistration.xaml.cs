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
    /// Interaction logic for NewStudentRegistration.xaml
    /// </summary>
    public partial class NewStudentRegistration : Window
    {
        private List<Student> studentList;
        private string[] departmentNames;
        private bool isChanged = false;
        public NewStudentRegistration(List<Student> studentList, string[] departmentNames)
        {
            this.studentList = studentList;
            this.departmentNames = departmentNames;
            InitializeComponent();
            LoadDepttComboBox();
            radioFull.IsChecked = true;
            comboBoxDeptt.SelectedIndex = -1;
            if (isChanged)
            {
                btnAdd.IsEnabled = true;
                btnReset.IsEnabled = true;
            }
            else
            {
                btnAdd.IsEnabled = false;
                btnReset.IsEnabled = false;
            }

        }
        public void LoadDepttComboBox()
        {
            foreach (string str in departmentNames)
            {
                comboBoxDeptt.Items.Add(str);
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
                string studentId = txtStuId.Text;
                string firstName = txtFirst.Text;
                string lastName = txtLast.Text;

                if (studentId == "" || studentId.Trim().Equals("") || firstName == "" || firstName.Trim().Equals("") || lastName == "" || lastName.Trim().Equals(""))
                {
                    MessageBox.Show("Please fill in all the fields", "New Student Warning Page", MessageBoxButton.OK, MessageBoxImage.Warning);
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
                        Student s = new Student(studentId, firstName, lastName, comboBoxDeptt.Text, enrollmentType);
                        studentList.Add(s);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid format of the input!!", "New Student Warning Page", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
            }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            radioFull.IsChecked = true;
            comboBoxDeptt.SelectedIndex = -1;
            LoadDepttComboBox();
            txtStuId.Text = "";
            txtFirst.Text = "";
            txtLast.Text = "";
            txtStuId.Focus();
        }

        private void txtStuId_TextChanged(object sender, TextChangedEventArgs e)
        {
            isChanged = true;
            btnAdd.IsEnabled = true;
            btnReset.IsEnabled = true;
        }

        private void txtFirst_TextChanged(object sender, TextChangedEventArgs e)
        {
            isChanged = true;
            btnAdd.IsEnabled = true;
            btnReset.IsEnabled = true;
        }

        private void txtLast_TextChanged(object sender, TextChangedEventArgs e)
        {
            isChanged = true;
            btnAdd.IsEnabled = true;
            btnReset.IsEnabled = true;
        }

        private void comboBoxDeptt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            isChanged = true;
            btnAdd.IsEnabled = true;
            btnReset.IsEnabled = true;
        }
    }
    }

