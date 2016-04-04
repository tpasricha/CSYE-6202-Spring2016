using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistration
{
    public partial class NewStudentPage : Form
    {
        private List<Student> studentList;
        private string[] departmentNames;
        public NewStudentPage(string[] departmentNames)
        {
            InitializeComponent();
            LoadDepttComboBox();
            radioFull.Select();
            comboBoxDeptt.SelectedIndex = 0;
            this.departmentNames = departmentNames;
        }

        private void txtBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewStudentPage_Load(object sender, EventArgs e)
        {

        }

        public void LoadDepttComboBox()
        {
            departmentNames = new[] { "Information Systems", "International Affairs", "Nursing", "Pharmacy", "Professional Studies", "Psychology", "Public Administration" };
            comboBoxDeptt.Items.AddRange(departmentNames);
        }

        public void GetStudentList(List<Student> studentList)
        {
            this.studentList = studentList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string studentId = txtBoxId.Text;
            string firstName = txtBoxFirst.Text;
            string lastName = txtBoxLast.Text;
            if (studentId == "" || studentId.Trim().Equals("") || firstName == "" || firstName.Trim().Equals("") || lastName == "" || lastName.Trim().Equals(""))
            {
                MessageBox.Show("Please fill in all the fields", "New Student Warning Page", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                string enrollmentType;
                if (radioFull.Checked)
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
                    MessageBox.Show("Invalid format of the input!!", "New Student Warning Page", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
         }

              private void btnReset_Click(object sender, EventArgs e)
        {
            LoadDepttComboBox();
            radioFull.Select();
            comboBoxDeptt.SelectedIndex = 0;
            txtBoxId.Text = "";
            txtBoxFirst.Text = "";
            txtBoxLast.Text = "";
            txtBoxId.Focus();
        }
    }
}
