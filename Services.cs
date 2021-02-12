using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Management_System
{
    class Services: School
    {
       public static void AddStudent()
        {
            StudentList.Add(new Student());
            Console.WriteLine("Student details are added successfully");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
        public static void AddMarks()
        {
            if (StudentList.Count == 0)
            {
                Console.WriteLine("NO Student Exist");
            }
            else
            {
                Console.WriteLine("Enter student roll number:");
                int roll = Convert.ToInt32(Console.ReadLine());
                foreach (var item in StudentList)
                {
                    if (item.rollnumber == roll)
                    {
                        item.setMarks();

                    }
                }
                Console.WriteLine("Student marks are added successfully");
                Console.WriteLine("Enter any key to continue");
                Console.WriteLine();
            }
        }
        public static void ProgressCard()
        {
            if (StudentList.Count == 0)
            {
                Console.WriteLine("NO Student Exist");
            }
            else
            {
                Console.WriteLine("Enter student roll number");
                int rol = Convert.ToInt32(Console.ReadLine());
                foreach (var item in StudentList)
                {
                    if (item.rollnumber == rol)
                    {
                        Console.WriteLine("Student Roll Number:" + item.rollnumber);
                        Console.WriteLine("Student Name:" + item.Name);
                        Console.WriteLine("Student marks\n");
                        for (int i = 0; i < 20; i++)
                            Console.Write("-");
                        Console.WriteLine();
                        item.displayMarks();
                    }
                }
            }
        }
        public static int checkduplicates(int a)
        {
            int flag = 0;
            foreach (var item in School.StudentList)
            {
                if (item.rollnumber == a)
                    flag = 1;
            }
            return flag;
        }
    } 
}
