using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz.Student_Teacher
{
    public class Student : BAseDAta
    {
        public enum Student_advisor_ForStudent
        {
            Dr_John,
            Dr_Emily,
            Prof_Michael,
            Dr_Linda
        }
        public Student_advisor_ForStudent SAS;
        public string ST_ID;
        public double Gpx;
      
        
            public string Name { get; set; }
    
            public Major Major { get; set; }
            public Professor Advisor { get; set; } // อาจารย์ที่ปรึกษา
        

        public Student() 
        {
        }
    }

}