using System.Security.Cryptography.X509Certificates;

using quiz.Student_Teacher;

using static quiz.Student_Teacher.Student;



namespace quiz

{

    public partial class Form1 : Form

    {

        //private List<Student_advisor> Advisors = new List<Student_advisor>();

        private List<Student> StudentsDAta = new List<Student>();

        public List<Professor> TeachersA = new List<Professor>();

        public List<Professor> TeachersB = new List<Professor>();

        public List<Professor> TeachersC = new List<Professor>();

        public List<Professor> TeachersD = new List<Professor>();

        public Form1()

        {

            InitializeComponent();
            TeachersA.Add(new Professor("Dr. John Smith", "Mathematics", "Physics"));  // อาจารย์ในกลุ่ม A
            TeachersB.Add(new Professor("Dr. Emily Johnson", "Computer Science", "Algorithms"));  // อาจารย์ในกลุ่ม B
            TeachersC.Add(new Professor("Prof. Michael Brown", "Biology", "Genetics"));  // อาจารย์ในกลุ่ม C
            TeachersD.Add(new Professor("Dr. Linda White", "Chemistry", "Organic Chemistry"));  // อาจารย์ในกลุ่ม D
        }



        private void button2_Click(object sender, EventArgs e)
        {
            List<Professor> selectedTeachers = null;

            // Get the selected advisor group from comboBox3
            string selectedGroup = comboBox3.Text;

            if (selectedGroup == "Dr_John") selectedTeachers = TeachersA;
            else if (selectedGroup == "Dr_Emily") selectedTeachers = TeachersB;
            else if (selectedGroup == "Prof_Michael") selectedTeachers = TeachersC;
            else if (selectedGroup == "Dr_Linda") selectedTeachers = TeachersD;

            if (selectedTeachers != null && selectedTeachers.Count > 0)
            {
                // Find the first teacher in the selected group
                var selectedTeacher = selectedTeachers.FirstOrDefault();

                if (selectedTeacher != null)
                {
                    // Display the advisor's name and subjects
                    label8.Text = $"Advisor: {selectedTeacher.Name}\n" +
                                  $"Subject 1: {selectedTeacher.Subject1}\n" +
                                  $"Subject 2: {selectedTeacher.Subject2}\n";  // Displaying the second subject

                    // Find students under this advisor group
                    var studentsUnderAdvisor = StudentsDAta
                        .Where(s => s.SAS.ToString() == selectedGroup)
                        .ToList();

                    if (studentsUnderAdvisor.Count > 0)
                    {
                        // Display the list of students
                        label8.Text += $"Students under {selectedTeacher.Name}:\n" +
                                       string.Join("\n", studentsUnderAdvisor.Select(s => s.name));
                    }
                    else
                    {
                        label8.Text += "No students found under this advisor.";
                    }
                }
            }
            else
            {
                label8.Text = "Please select a valid advisor group from ComboBox.";
            }
        }







        private void Form1_Load(object sender, EventArgs e)

        {


        }

        public (string name, string studentId, string major, double Gpx, string Advisor) Item(TextBox item1, TextBox item2, ComboBox item3, TextBox item4, ComboBox item7)

        {

            string inGpx = item4.Text;

            string name = item1.Text;

            string Student_id = item2.Text;

            string Major = item3.Text;

            double Gpx = 0;

            string advisor = item7.Text;

            try

            {

                Gpx = double.Parse(inGpx);



            }

            catch (FormatException) { }



            return (name, Student_id, Major, Gpx, advisor);

        }



        private void textBox1_TextChanged(object sender, EventArgs e)

        {

        }



        private void button1_Click(object sender, EventArgs e)

        {

            Student student = new Student();

            Professor TeacherAdd = new Professor("Dr. John Smith", "Math", "Physics");

            var InputDATA = Item(NameTextbox, ST_ID_Text, comboBox1, GpxText, comboBox2);

            while (true)

            {

                if (InputDATA.name != "")

                {

                    student.name = InputDATA.name;

                }

                else

                {

                    MessageBox.Show("error");

                    break;

                }

                if (InputDATA.studentId != "")

                {

                    student.ST_ID = InputDATA.studentId;

                }

                else

                {

                    MessageBox.Show("error");

                    break;

                }

                if (InputDATA.Gpx is double)

                {

                    student.Gpx = InputDATA.Gpx;

                }

                else

                {

                    MessageBox.Show("error");

                    break;

                }

                if (Enum.TryParse(InputDATA.major, out Major majorEnum))

                {

                    student.Major = majorEnum;

                }

                else

                {

                    MessageBox.Show("error");

                    break;

                }

                if (Enum.TryParse(InputDATA.Advisor, out Student_advisor_ForStudent advisor_enum))

                {
                    student.SAS = advisor_enum;

                    // ตั้งชื่อวิชาให้กับแต่ละอาจารย์ เช่น สมมติว่า "Subject1" กับ "Subject2" เป็นชื่อวิชา
                    string subject1 = "Subject1"; // เปลี่ยนเป็นชื่อวิชาที่เหมาะสม
                    string subject2 = "Subject2"; // เปลี่ยนเป็นชื่อวิชาที่เหมาะสม
                    if (advisor_enum == Student_advisor_ForStudent.Dr_John)
                    {
                        // เมื่อ advisor_enum เป็น TeacherA
                        Professor teacher = new Professor(student.name, subject1, subject2); // สร้าง Teacher โดยส่งชื่อวิชา
                        TeachersA.Add(teacher);
                    }
                    else if (advisor_enum == Student_advisor_ForStudent.Dr_Emily)
                    {
                        Professor teacher = new Professor(student.name, subject1, subject2);
                        TeachersB.Add(teacher);
                    }
                    else if (advisor_enum == Student_advisor_ForStudent.Prof_Michael)
                    {
                        Professor teacher = new Professor(student.name, subject1, subject2);
                        TeachersC.Add(teacher);
                    }
                }
                this.StudentsDAta.Add(student); // เพิ่มนักเรียนลงใน List ทั้งหมด

                break;

            }

            var latestStudent = StudentsDAta.LastOrDefault(); // หรือใช้ StudentsDAta[StudentsDAta.Count - 1]



            if (latestStudent != null)

            {

                // แสดงข้อมูลของนักเรียนล่าสุดที่เพิ่มเข้ามาใน List

                label1.Text = $"Latest Added Student:\n" +

               $"Name: {latestStudent.name}\n" +

               $"Student ID: {latestStudent.ST_ID}\n" +

               $"Major: {latestStudent.Major}\n" +

               $"Gpx: {latestStudent.Gpx}";

            }

            else

            {

                MessageBox.Show("No students found.");

            }

            var highestGradeStudent = StudentsDAta.OrderByDescending(s => s.Gpx).FirstOrDefault();



            if (highestGradeStudent != null)

            {

                // แสดงข้อมูลของนักเรียนที่ได้คะแนนสูงสุด

                label2.Text = $"Name: {highestGradeStudent.name}\n" +

               $"Gpx: {highestGradeStudent.Gpx}\n" +

               $"Major: {highestGradeStudent.Major}";

            }

            else

            {

                MessageBox.Show("No students found.");

            }

        }



        private void label5_Click(object sender, EventArgs e)

        {



        }



        private void label7_Click(object sender, EventArgs e)

        {



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }

}