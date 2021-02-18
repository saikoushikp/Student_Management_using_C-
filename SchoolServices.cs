using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Management_System
{
    class SchoolServices
    {
        School school = new School();
        Helper helper = new Helper();
        public int cnt = 0;

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


        public void AddMarks(int rollNumber,String subjectName,int marks)
        {
            
            Student student = GetStudent(rollNumber);
            if (helper.isNullable(student) == false)
            {
                if (cnt >= 6)
                    cnt = 0;
                student.marks[cnt] = marks;
                student.totalMarks = student.totalMarks + student.marks[cnt];
                cnt++;             
                student.percentage = student.totalMarks / (double)6;
                student.percentage = (double)System.Math.Round(student.percentage, 3);
            }
            else
                helper.NoStudent();
        }

        
            
        

        public Student GetStudent(int rolnumber)
        {
            #nullable enable
            Student? student = null;
            foreach(Student student1 in school.StudentList)
            {
                if (student1.rollnumber == rolnumber)
                    student=student1;
            }
            return student;
        }


        public void ProgressCard(int rolnumber)
        {
            Student student = GetStudent(rolnumber);
            if (helper.CheckStudent(student))
            {
                helper.DisplayStudentDetails(student, rolnumber);
            }
            else
                helper.NoStudent();
         }

            
        

        public int CheckDuplicates(int a)
        {
            int flag = 0;
            Student student = GetStudent(a);
            if (helper.isNullable(student) == false)
            {


                if (student.rollnumber == a)
                    flag = 1;
                else
                    flag = 0;
                
            }
            return flag;
        }
    } 
}
