using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistration
{
    public partial class RemoveStudentPage : Form
    {
        private Student student;
        private List<Student> studentList;
        private string[] departmentNames;
        public RemoveStudentPage(Student s, List<Student> sl)
        {
            this.student = s;
            this.studentList = sl;
            InitializeComponent();
            LoadDepttComboBox();
            txtBoxId.Text = student.studentId;
            txtBoxFirst.Text = student.firstName;
            txtBoxLast.Text = student.lastName;
            comboBoxDeptt.Text = student.departmentName;
            if (radioFull.Text.Equals(student.enrollmentType))
            {
                radioFull.Checked = true;
            }
            else
            {
                radioPart.Checked = true;
            }
            radioFull.Enabled = false;
            txtBoxId.Enabled = false;
            comboBoxDeptt.Enabled = false;
            txtBoxFirst.Enabled = false;
            txtBoxLast.Enabled = false;
            radioPart.Enabled = false;
            }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult warning = MessageBox.Show("Are you sure you want to remove this student?", "Remove Student Warning Page", MessageBoxButtons.YesNo);
            if(warning == DialogResult.Yes)
            {
                studentList.Remove(student);
                this.Close();
            }
            else
            {
                this.Close();
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
    }
}
