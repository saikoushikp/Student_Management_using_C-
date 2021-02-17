using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Management_System
{
    class SchoolServices
    {
        School school = new School();
        Helper help = new Helper();

        public void AddSchoool(String skool)
        {
            school.SchoolName = skool;
        }

        public bool CheckStudent()
        {
            if (school.StudentList.Count == 0)
                return false;
            return true;
        }



        public void AddStudent(String name,int rollnumber)
        {
            Student student=new Student();
            student.name = name;
            student.rollnumber = rollnumber;
            school.StudentList.Add(student);
        }


        public void AddMarks(int rollNumber)
        {
            foreach (Student student in school.StudentList)
            {
                if (student.rollnumber == rollNumber)
                {
                    student.totalMarks = 0;
                    student.percentage = 0.0;
                    int cnt = 0;
                    foreach (Subjects s in Enum.GetValues(typeof(Subjects)))
                    {
                        help.GetSubjectName(cnt);
                        student.marks[cnt] = Convert.ToInt32(Console.ReadLine());
                        student.totalMarks = student.totalMarks + student.marks[cnt];
                        cnt++;
                    }
                    student.percentage = student.totalMarks / (double)6;
                    student.percentage = (double)System.Math.Round(student.percentage, 3);
                }
            }
        }
        public void ProgressCard(int rolnumber)
        {
            foreach (Student student in school.StudentList)
            {
                if (student.rollnumber == rolnumber)
                {
                    help.DisplayStudentDetails(student,rolnumber);
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
