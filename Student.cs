using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Management_System
{
    public class Student
    {
        public String name { get; set; }
        public int rollnumber { get; set; }
        public int totalMarks { get; set; } 
        public double percentage { get; set; } 

        public int[] marks { get; set; } = new int[6];


    }
}
