using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for StudentRegistrationWindow.xaml
    /// </summary>
    public partial class StudentRegistrationWindow : Window
    {

        private List<Student> randomStudentList;
        private string[] departmentNames;
       
        public StudentRegistrationWindow()
        {
           
            InitializeComponent();
            randomStudentList = new List<Student>();
            LoadDepttComboBox();
            comboBoxDeptt.SelectedIndex = 0;
            radioFull.IsEnabled = false;
            txtStudentId.IsEnabled = false;
            comboBoxDeptt.IsEnabled = false;
            txtFirst.IsEnabled = false;
            txtLast.IsEnabled = false;
            radioPart.IsEnabled = false;
            radioFull.IsChecked = false;
            radioPart.IsChecked = false;
            LoadRandomDataGridView();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {

            NewStudentRegistration nsr = new NewStudentRegistration(randomStudentList, departmentNames);
            nsr.ShowDialog();
            ObservableCollection<Student> list = new ObservableCollection<Student>(randomStudentList);
            RandomDataGrid.ItemsSource = null;
            RandomDataGrid.ItemsSource = list;
            comboBoxDeptt.SelectedIndex = 0;
            radioFull.IsEnabled = false;
            txtStudentId.IsEnabled = false;
            comboBoxDeptt.IsEnabled = false;
            txtFirst.IsEnabled = false;
            txtLast.IsEnabled = false;
            radioPart.IsEnabled = false;
            radioFull.IsChecked = false;
            radioPart.IsChecked = false;
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {

                Student selectedStudent = RandomDataGrid.SelectedItem as Student;
                if(selectedStudent!=null)
            {
                RemoveStudentRegistration rsr = new RemoveStudentRegistration(selectedStudent, randomStudentList);
                rsr.ShowDialog();
                ObservableCollection<Student> list = new ObservableCollection<Student>(randomStudentList);
                RandomDataGrid.ItemsSource = null;
                RandomDataGrid.ItemsSource = list;
                comboBoxDeptt.SelectedIndex = 0;
                radioFull.IsEnabled = false;
                txtStudentId.IsEnabled = false;
                comboBoxDeptt.IsEnabled = false;
                txtFirst.IsEnabled = false;
                txtLast.IsEnabled = false;
                radioPart.IsEnabled = false;
                radioFull.IsChecked = false;
                radioPart.IsChecked = false;
            }           
                else
            {
                MessageBox.Show("Please select a student to remove from the list", "Student Remove Warning");
            }

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
                Student selectedStudent = RandomDataGrid.SelectedItem as Student;
            if(selectedStudent!=null)
            {
                EditStudentRegistration esr = new EditStudentRegistration(selectedStudent, randomStudentList, departmentNames);
                esr.ShowDialog();
                ObservableCollection<Student> list = new ObservableCollection<Student>(randomStudentList);
                RandomDataGrid.ItemsSource = null;
                RandomDataGrid.ItemsSource = list;
                comboBoxDeptt.SelectedIndex = 0;
                radioFull.IsEnabled = false;
                txtStudentId.IsEnabled = false;
                comboBoxDeptt.IsEnabled = false;
                txtFirst.IsEnabled = false;
                txtLast.IsEnabled = false;
                radioPart.IsEnabled = false;
                radioFull.IsChecked = false;
                radioPart.IsChecked = false;
            }
            else
            {
                MessageBox.Show("Please select a student to edit from the list", "Student Update Warning");
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

        public void LoadRandomDataGridView()
        {
            string[] studentId = new string[10];
            for (int i = 0; i < 10; i++)
            {
                string randomId = RandomGenerator.RandomStudentId();
                int position = Array.IndexOf(studentId, randomId);
                while (position > -1)
                {
                    randomId = RandomGenerator.RandomStudentId();
                    position = Array.IndexOf(studentId, randomId);
                }
                studentId[i] = randomId;
            }
            for (int i = 0; i < 10; i++)
            {
                randomStudentList.Add(new Student(studentId[i], RandomGenerator.randomFirstName(), RandomGenerator.randomLastName(), RandomGenerator.randomDepartment(), RandomGenerator.enrollmentType()));
            }
            ObservableCollection<Student> list = new ObservableCollection<Student>(randomStudentList);
            RandomDataGrid.ItemsSource = null;
            RandomDataGrid.ItemsSource = list;
            }

        public void SetColumnsInDataGrid(Object sender, EventArgs e)
        {
            if (RandomDataGrid.Columns.Count == 5)
            {
                RandomDataGrid.Columns[0].DisplayIndex = 0;
                RandomDataGrid.Columns[1].DisplayIndex = 1;
                RandomDataGrid.Columns[2].DisplayIndex = 2;
                RandomDataGrid.Columns[3].DisplayIndex = 3;
                RandomDataGrid.Columns[4].DisplayIndex = 4;
            }
        }
    }
}
