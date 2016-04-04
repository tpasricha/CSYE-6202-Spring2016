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
    public partial class EditStudentPage : Form
    {
        private Student student;
        private List<Student> studentList;
        private string[] departmentNames;
        public EditStudentPage(Student s, List<Student> sl, string[] depttNames)
        {
            this.student = s;
            this.studentList = sl;
            this.departmentNames = depttNames;
            InitializeComponent();
            LoadDepttComboBox();
            comboBoxDeptt.SelectedIndex = 0;
            txtBoxId.Text = student.studentId;
            txtBoxFirst.Text = student.firstName;
            txtBoxLast.Text = student.lastName;
            string deptt = student.departmentName;
            if (radioFull.Text.Equals(student.enrollmentType))
            {
                radioFull.Checked = true;
            }
            else
            {
                radioPart.Checked = true;
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
            comboBoxDeptt.Items.AddRange(departmentNames);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string studentId = txtBoxId.Text;
            string firstName = txtBoxFirst.Text;
            string lastName = txtBoxLast.Text;
            if (studentId == "" || studentId.Trim().Equals("") || firstName == "" || firstName.Trim().Equals("") || lastName == "" || lastName.Trim().Equals(""))
            {
                MessageBox.Show("Please fill in all the fields", "Edit Student Warning Page", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    DialogResult warning = MessageBox.Show("Are you sure you want to update this student?", "Edit Student Warning Page", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (warning == DialogResult.Yes)
                    {
                        student.studentId = studentId;
                        student.firstName = firstName;
                        student.lastName = lastName;
                        student.departmentName = comboBoxDeptt.Text;
                        student.enrollmentType = enrollmentType;
                        this.Close();
                    }
                    else if (warning == DialogResult.No)
                    {
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid format of the input!!", "New Student Warning Page", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
