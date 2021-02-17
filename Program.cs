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
            int option = Convert.ToInt32(Console.ReadLine());
            return option;
        }
        public static void Main(String[] args)
        {
            SchoolServices service = new SchoolServices();
            Console.WriteLine("Enter school name:");
            String skool = Console.ReadLine();
            service.AddSchoool(skool);
            Console.WriteLine("Welcome to " + skool + " School Student information management");
            for (int i = 0; i < 75; i++)
                Console.Write("-");
            Console.WriteLine();
            while ( true )
            {
                PrintMenu();
                int option = GetOption();
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter student name:");
                        String name = Console.ReadLine();
                        Console.WriteLine("Enter student roll number:");
                        int rollnumber = -1;
                        int x = -1;
                        while (x != 0)
                        {
                            rollnumber = Convert.ToInt32(Console.ReadLine());
                            x = service.CheckDuplicates(rollnumber);
                            if (x == 0)
                                break;
                            Console.WriteLine("Student roll number already exists enter a valid one");
                            
                        }
                        service.AddStudent(name,rollnumber);
                        Console.WriteLine("Student details are added successfully");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadLine();
                        break;
                    case 2:
                        if (service.CheckStudent() == false)
                        {
                            Console.WriteLine("No student exists");
                        }
                        else
                        {
                            Console.WriteLine("Enter student roll number");
                            int rollNumber = Convert.ToInt32(Console.ReadLine());
                            service.AddMarks(rollNumber);
                        }
                        break;
                    case 3:
                        if(service.CheckStudent()== false)
                        {
                            Console.WriteLine("No student exists!");
                        }
                        else
                        {
                            Console.WriteLine("Enter roll number of student:");
                            int rolnumber = Convert.ToInt32(Console.ReadLine());
                            service.ProgressCard(rolnumber);
                        }      
                        break;
                    default:
                        Console.WriteLine("Incorrect Option!");
                        break;
                }
            }
        }
    }
    
}
