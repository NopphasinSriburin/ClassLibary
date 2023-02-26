using StudentClassLibrary;

namespace _2022566
{
    public partial class Form1 : Form
    {
        List<Student> listStudents = new List<Student>();
        StudentController controllor = new StudentController ();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input_name = this.textBox1.Text;
            string input_student_id = this.textBox2.Text;
            controllor.addStudent2List(input_student_id,input_name);
            Student newStudent = new Student(input_name, input_student_id); 
            this.listStudents.Add(newStudent);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controllor.saveFile();
            displayData();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controllor.opneFile();
            displayData();
        }
        private void displayData()
        {
            for (int i = 0; i < this.listStudents.Count; i++)
            {
                Student currentStudent = this.listStudents[i];
                string display = currentStudent.displayInfo();
                this.tblistStudent.Text += display;
                //TODO
                //[] Fix display data form List
            }
        }
    }
}