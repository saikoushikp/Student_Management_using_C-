using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Management_System
{
    class SchoolServices
    {
        School ss = new School();
       public void AddStudent()
        {
            Student s1=new Student();
            Console.WriteLine("Enter Student name:");
            s1.name = Console.ReadLine();
            Console.WriteLine("Enter student roll number:");
            int result = -1;
            int x = -1;
            while (x != 0)
            {
                result = Convert.ToInt32(Console.ReadLine());
                x = CheckDuplicates(result);
                if (x == 0)
                    break;
                Console.WriteLine("Student roll number already exists enter a valid one");
            }
            s1.rollnumber = result;
            ss.StudentList.Add(s1);
            Console.WriteLine("Student details are added successfully");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }

        public void AddMarks()
        {
            if (ss.StudentList.Count == 0)
            {
                Console.WriteLine("NO Student Exist");
            }
            else
            {
                Console.WriteLine("Enter student roll number:");
                int roll = Convert.ToInt32(Console.ReadLine());
                foreach (Student y in ss.StudentList)
                {
                    if (y.rollnumber == roll)
                    {
                        y.totalMarks = 0;
                        y.percentage = 0.0;
                        int cnt = 0;
                        foreach (Subjects s in Enum.GetValues(typeof(Subjects)))
                        {
                            Console.WriteLine("Enter marks for " + s + " Subject");
                            y.marks[cnt] = Convert.ToInt32(Console.ReadLine());
                            y.totalMarks = y.totalMarks + y.marks[cnt];
                            cnt++;
                        }
                        y.percentage = y.totalMarks / (double)6;
                        y.percentage = (double)System.Math.Round(y.percentage, 3);

                    }
                }
                Console.WriteLine("Student marks are added successfully");
                Console.WriteLine("Enter any key to continue");
                Console.WriteLine();
            }
        }
        public void ProgressCard()
        {
            if (ss.StudentList.Count == 0)
            {
                Console.WriteLine("NO Student Exist");
            }
            else
            {
                Console.WriteLine("Enter student roll number");
                int rol = Convert.ToInt32(Console.ReadLine());
                foreach (Student z in ss.StudentList)
                {
                    if (z.rollnumber == rol)
                    {
                        Console.WriteLine("Student Roll Number:" + z.rollnumber);
                        Console.WriteLine("Student Name:" + z.name);
                        Console.WriteLine("Student marks\n");
                        for (int i = 0; i < 20; i++)
                            Console.Write("-");
                        Console.WriteLine();
                        int c = -1;
                        foreach (Subjects s in Enum.GetValues(typeof(Subjects)))
                        {
                            Console.WriteLine(s + ":" + z.marks[c + 1]);
                            c++;
                        }
                        for (int i = 0; i < 30; i++)
                            Console.Write("-");
                        Console.WriteLine();
                        Console.WriteLine("Total Marks :" + z.totalMarks);
                        Console.WriteLine("Percentage :" + String.Format("{0:0.00}", z.percentage));
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
            foreach (var item in ss.StudentList)
            {
                if (item.rollnumber == a)
                    flag = 1;
            }
            return flag;
        }
    } 
}
