using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Management_System
{
    class Helper
    {
        
        public String  GetSubjectName(int index)
        {
            Console.WriteLine("Enter marks for " + (Subjects)index);
            String subjectname = ((Subjects)index).ToString();
            return subjectname;
        }

        public bool isNullable<Student>(Student student)
        {
            if (student == null)
                return true;
            return false;
        }

        public bool CheckStudent(Student student)
        {
            if (student==null)
                return false;
            return true;
        }

        public void NoStudent()
        {
            Console.WriteLine("No student with given Roll Number");
            Console.WriteLine();
        }

        public void DisplayStudentDetails(Student student, int rollnumber)
        {
            Console.WriteLine("Student Roll Number:" + student.rollnumber);
            Console.WriteLine("Student Name:" + student.name);
            Console.WriteLine("Student marks\n");
            for (int i = 0; i < 20; i++)
                Console.Write("-");
            Console.WriteLine();
            int c = -1;
            foreach (Subjects s in Enum.GetValues(typeof(Subjects)))
            {
                Console.WriteLine(s + ":" + student.marks[c + 1]);
                c++;
            }
            for (int i = 0; i < 30; i++)
                Console.Write("-");
            Console.WriteLine();
            Console.WriteLine("Total Marks :" + student.totalMarks);
            Console.WriteLine("Percentage :" + String.Format("{0:0.00}", student.percentage));
            for (int i = 0; i < 30; i++)
                Console.Write("-");
            Console.WriteLine();

        }

    }
}
