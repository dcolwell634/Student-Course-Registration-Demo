using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Course_Registration_Demo
{
    public partial class Form1 : Form
    {
        List<Course> courses = new List<Course>();
        List<Student> students = new List<Student>();
        List<String> registeredCourses = new List<String>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;

            courses = SeedInformation.SeedCourses();
            students = SeedInformation.SeedStudents();

            foreach (Student s in students)
            {
                studentsComboBox.Items.Add(s.LastName + ", " + s.FirstName);
            }
            studentsComboBox.SelectedIndex = 0;

            foreach (Course c in courses)
            {
                lstBoxCourses.Items.Add(c.CourseName);
            }

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void studentsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reset radio buttons
            maleRadioBtn.Checked = false;
            femaleRadioBtn.Checked = false;
            nonbinaryRadioBtn.Checked = false;

            var item = sender as ComboBox;
            var studentName = item.Text;
            Student student = (Student)students.First(ln => ln.LastName == studentName.Substring(0, studentName.IndexOf(",")));
            string studentDescription = $"Phone: {student.PhoneNumber}\nAddress:{student.Address}\nEmail:{student.Email}";
            pictureBox1.Load(student.ImageLocation);
            txtBoxStudentInfo.Text = studentDescription;

            if (student.Gender == Gender.Male)
                maleRadioBtn.Checked = true;
            if (student.Gender == Gender.Female)
                femaleRadioBtn.Checked = true;
            if (student.Gender == Gender.NonBinary)
                nonbinaryRadioBtn.Checked = true;
        }

        private void lstBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = sender as ListBox;
            var courseName = item.SelectedItem as string;

            Course course = (Course)courses.First(c => c.CourseName == courseName);

            txtBoxCourseInfo.Text = course.CourseDescription;
        }

        private void lstBoxRegisteredCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstBoxCourses.SelectedItems.Count > 0)
                lstBoxRegisteredCourses.Items.Add(lstBoxCourses.SelectedItem);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            lstBoxRegisteredCourses.Items.Clear();
            //TODO: Make Delete button only remove one course at a time
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Courses successfully registered!");
        }
    }
}
