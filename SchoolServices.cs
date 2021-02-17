using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Management_System
{
    class SchoolServices
    {
        School school = new School();
        public void AddStudent(String name,int rollnumber)
        {
            Student student=new Student();
            student.name = name;
            student.rollnumber = rollnumber;
            school.StudentList.Add(student);
            
        }

        public void AddMarks()
        {
            if (school.StudentList.Count == 0)
            {
                Console.WriteLine("NO student exists");
            }
            else
            {
                Console.WriteLine("Enter student roll number:");
                int rollnumber = Convert.ToInt32(Console.ReadLine());
                foreach (Student student in school.StudentList)
                {
                    if (student.rollnumber == rollnumber)
                    {
                        student.totalMarks = 0;
                        student.percentage = 0.0;
                        int cnt = 0;
                        foreach (Subjects s in Enum.GetValues(typeof(Subjects)))
                        {
                            Console.WriteLine("Enter marks for " + s + " Subject");
                            student.marks[cnt] = Convert.ToInt32(Console.ReadLine());
                            student.totalMarks = student.totalMarks + student.marks[cnt];
                            cnt++;
                        }
                        student.percentage = student.totalMarks / (double)6;
                        student.percentage = (double)System.Math.Round(student.percentage, 3);

                    }
                }
            }
        }
        public void ProgressCard()
        {
            if (school.StudentList.Count == 0)
            {
                Console.WriteLine("NO student exists");
            }
            else
            {
                Console.WriteLine("Enter student roll number:");
                int roll = Convert.ToInt32(Console.ReadLine());
                foreach (Student student in school.StudentList)
                {
                    if (student.rollnumber == roll)
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
        }
 
        public int CheckDuplicates(int a)
        {
            int flag = 0;
            foreach ( var student in school.StudentList )
            {
                if ( student.rollnumber == a )
                    flag = 1;
            }
            return flag;
        }
    } 
}
