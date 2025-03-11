using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace quiz.Student_Teacher
{
    public class Professor :BAseDAta
    {


        public string Name;  // ชื่ออาจารย์
            public List<Student> Students { get; set; }  // รายชื่อนักศึกษาที่ดูแล
        public string Subject1 { get; set; }
        public string Subject2 { get; set; }
        public Professor(string name, string subject1, string subject2)
        {
            Name = name;
            Subject1 = subject1;
            Subject2 = subject2;
        }
    }



}

