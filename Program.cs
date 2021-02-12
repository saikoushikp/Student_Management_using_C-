using System;
using System.Collections.Generic;
namespace Student_Management_System
{
    class Program
    {
        public static void PrintMenu()
        {
            Console.WriteLine("1.Add Student");
            Console.WriteLine("2.Add marks for student");
            Console.WriteLine("3.Show progress card");
            Console.WriteLine();
            Console.WriteLine("Please provide valid input from menu options");
        }

        public static int GetOption()
        {
            int v = Convert.ToInt32(Console.ReadLine());
            return v;
        }
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter school name");
            School s = new School();
            s.SchoolName = Console.ReadLine();
            Console.WriteLine("Welcome to " + s.SchoolName + " School Student information management");
            for (int i = 0; i < 75; i++)
                Console.Write("-");
            Console.WriteLine();
            while (true)
            {
                PrintMenu();
                int x = GetOption();
                switch (x)
                {
                    case 1:
                        Services.AddStudent();
                        break;
                    case 2:
                        Services.AddMarks();
                        break;
                    case 3:
                        Services.ProgressCard();
                        break;
                    default:
                        Console.WriteLine("Incorrect Option!");
                        break;
                }
            }
        }
    }
    
}
