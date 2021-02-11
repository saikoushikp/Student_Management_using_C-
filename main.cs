using System;
using System.Collections.Generic;
namespace task1
{
    public class main:school
    {
     public static void PrintMenu()
    {
        Console.WriteLine("1.Add Student");
        Console.WriteLine("2.Add marks for student");
        Console.WriteLine("3.Show progress card");
        Console.WriteLine();
        Console.WriteLine("Please provide valid input from menu options");
    }

    public static int  GetOption()
    {
        int v=Convert.ToInt32(Console.ReadLine());
        return v;
    }
    public static void  Main(String[] args)
    {
        Console.WriteLine("Enter school name");
        String schoolname=Console.ReadLine();
        Console.WriteLine("Welcome to "+schoolname+" School Student information management");
        for(int i=0;i<75;i++)
        Console.Write("-");
        Console.WriteLine();
        while(true)
        {
        PrintMenu();
        int x=GetOption();
        switch(x)
        {
            case 1:
                    
                    StudentList.Add(new Student());
                    Console.WriteLine("Student details are added successfully");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine();
                    break;
            case 2:
                    if(StudentList.Count==0)
                    {
                        Console.WriteLine("NO Student Exist");
                        break;
                    }
                    else{
                    Console.WriteLine("Enter student roll number:");
                    int roll=Convert.ToInt32(Console.ReadLine());
                    foreach(var item in StudentList)
                    {
                        if(item.rollnumber==roll)
                        {
                            item.setMarks();
                        }
                    }
                    Console.WriteLine("Student marks are added successfully");
                    Console.WriteLine("Enter any key to continue");
                    Console.WriteLine();
                    break;
                    }
            case 3:
                    if(StudentList.Count==0)
                    {
                        Console.WriteLine("NO Student Exist");
                        break;
                    }
                    else{
                    Console.WriteLine("Enter student roll number");
                    int rol=Convert.ToInt32(Console.ReadLine());
                    foreach(var item in StudentList)
                    {
                        if(item.rollnumber==rol)
                        {
                            Console.WriteLine("Student Roll Number:"+item.rollnumber);
                            Console.WriteLine("Student Name:"+item.Name);
                            Console.WriteLine("Student marks\n");
                            for(int i=0;i<20;i++)
                            Console.Write("-");
                            Console.WriteLine();
                            item.displayMarks();
                        }
                    }
                    break;
                    }
            default:
                    Console.WriteLine("Incorrect Option!");
                    break;
        }
    } 
    }   
    }
}
