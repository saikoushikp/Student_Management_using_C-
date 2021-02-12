using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Management_System
{
    public class Student
    {
        public String Name;
        public int rollnumber;
        public int totalMarks = 0;
        public double percentage = 0.0;

        public int[] marks = new int[6];

        

        public Student()
        {
            Console.WriteLine("Enter student name:");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter student roll number:");
            int result = -1;
            int x = -1;
            while (x != 0)
            {
                result = Convert.ToInt32(Console.ReadLine());
                x = Services.checkduplicates(result);
                if (x == 0)
                    break;
                Console.WriteLine("Student roll number already exists enter a valid one");
            }
            this.rollnumber = result;
        }
        public void setMarks()
        {
            int cnt = 0;
            foreach (Subjects s in Enum.GetValues(typeof(Subjects)))
            {
                Console.WriteLine("Enter marks for " + s + " Subject");
                marks[cnt] = Convert.ToInt32(Console.ReadLine());
                totalMarks = totalMarks + marks[cnt];
                cnt++;
            }
            percentage = totalMarks / (double)6;
            percentage = (double)System.Math.Round(percentage, 3);
        }

        public void displayMarks()
        {
            int c = -1;
            foreach (Subjects s in Enum.GetValues(typeof(Subjects)))
            {
                Console.WriteLine(s + ":" + marks[c + 1]);
                c++;
            }
            for (int i = 0; i < 30; i++)
                Console.Write("-");
            Console.WriteLine();
            Console.WriteLine("Total Marks :" + totalMarks);
            Console.WriteLine("Percentage :" + String.Format("{0:0.00}", percentage));
            for (int i = 0; i < 30; i++)
                Console.Write("-");
            Console.WriteLine();
        }
    }
}
