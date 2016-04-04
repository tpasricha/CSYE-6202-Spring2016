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
    public partial class MainPage : Form
    {
        private List<Student> randomStudentList;
        private string[] departmentNames;
        public delegate void NewStudentList(List<Student> studentList);
        public MainPage()
        {
            randomStudentList = new List<Student>();
            InitializeComponent();
            LoadDepttComboBox();
            comboBoxDeptt.SelectedIndex = 0;
            radioFull.Enabled = false;
            txtBoxId.Enabled = false;
            comboBoxDeptt.Enabled = false;
            txtBoxFirst.Enabled = false;
            txtBoxLast.Enabled = false;
            radioPart.Enabled = false;
            radioFull.Checked = false;
            radioPart.Checked = false;
            LoadRandomDataGridView();            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioFull_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void txtBoxFirst_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBoxLast_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioPart_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            NewStudentPage nsp = new NewStudentPage(departmentNames);
            NewStudentList nsl = new NewStudentList(nsp.GetStudentList);
            nsl(randomStudentList);
            nsp.ShowDialog();

            var bindingList = new BindingList<Student>(randomStudentList);
            var dataSource = new BindingSource(bindingList, null);
            dataGridViewStudents.DataSource = null;
            dataGridViewStudents.DataSource = dataSource;
            SetColumnsInDataGrid();
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if(dataGridViewStudents.RowCount>0)
            {
                Student selectedStudent = (Student)dataGridViewStudents.CurrentRow.DataBoundItem;
                RemoveStudentPage rsp = new RemoveStudentPage(selectedStudent,randomStudentList);
                rsp.ShowDialog();
                var bindingList = new BindingList<Student>(randomStudentList);
                var dataSource = new BindingSource(bindingList, null);
                dataGridViewStudents.DataSource = null;
                dataGridViewStudents.DataSource = dataSource;
                SetColumnsInDataGrid();
                radioFull.Select();
                comboBoxDeptt.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Please select a student to remove from the list", "Student Remove Warning");
            }           
            
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.RowCount > 0)
            {
                Student selectedStudent = (Student)dataGridViewStudents.CurrentRow.DataBoundItem;
                EditStudentPage esp = new EditStudentPage(selectedStudent, randomStudentList, departmentNames);
                esp.ShowDialog();
                var bindingList = new BindingList<Student>(randomStudentList);
                var dataSource = new BindingSource(bindingList, null);
                dataGridViewStudents.DataSource = null;
                dataGridViewStudents.DataSource = dataSource;
                SetColumnsInDataGrid();
                radioFull.Select();
                comboBoxDeptt.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Please select a student to edit from the list", "Student Update Warning");
            }
        }                   

        public void LoadDepttComboBox()
        {
            departmentNames = new[] { "Information Systems", "International Affairs", "Nursing", "Pharmacy", "Professional Studies", "Psychology", "Public Administration" };
            comboBoxDeptt.Items.AddRange(departmentNames);
         }

       public void LoadRandomDataGridView()
        {
            string[] studentId = new string[10];
            for(int i=0;i<10;i++)
            {
                string randomId = RandomGenerator.RandomStudentId();
                int position = Array.IndexOf(studentId, randomId);
                while(position > -1)
                {
                    randomId = RandomGenerator.RandomStudentId();
                    position = Array.IndexOf(studentId, randomId);
                }
                studentId[i] = randomId;
            }
            for(int i =0; i<10; i++)
            {
                randomStudentList.Add(new Student(studentId[i], RandomGenerator.randomFirstName(), RandomGenerator.randomLastName(), RandomGenerator.randomDepartment(), RandomGenerator.enrollmentType()));
            }
            var bindingList = new BindingList<Student>(randomStudentList);
            var dataSource = new BindingSource(bindingList, null);
            dataGridViewStudents.DataSource = dataSource;
            SetColumnsInDataGrid();
        }

        public void SetColumnsInDataGrid()
        {
            dataGridViewStudents.Columns["StudentID"].DisplayIndex = 0;
            dataGridViewStudents.Columns["FirstName"].DisplayIndex = 1;
            dataGridViewStudents.Columns["LastName"].DisplayIndex = 2;
            dataGridViewStudents.Columns["DepartmentName"].DisplayIndex = 3;
            dataGridViewStudents.Columns["EnrollmentType"].DisplayIndex = 4;
        }
    }
}
