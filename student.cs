using System;
using System.Collections.Generic;
namespace task1
{
    public class Student:school
    {
        public String Name;
        public int rollnumber;
        public int totalMarks=0;
        public double percentage=0.0;
         
         public int[] marks=new int[6];

         public  int checkduplicates(int a)
         {
             int flag=0;
             foreach(var item in StudentList)
             {
                 if(item.rollnumber==a)
                 flag=1;
             }
             return flag;
         }

        public Student()
        {        
            Console.WriteLine("Enter student name:");
            this.Name=Console.ReadLine();
            Console.WriteLine("Enter student roll number:");
            int result=-1;
            int x=-1;
            while(x!=0)
            {
                result=Convert.ToInt32(Console.ReadLine());
                x=checkduplicates(result);
                if(x==0)
                break;
                Console.WriteLine("Student roll number already exists enter a valid one");
            }
            this.rollnumber=result;
        }
        public string getname()
        {
             return Name;
        }
        public int getNumber()
        {
            return rollnumber;
        }
        public void setMarks()
        {
            int cnt=0;
            foreach(subjects s in Enum.GetValues(typeof(subjects)))
            {
            Console.WriteLine("Enter marks for "+s+" Subject");
            marks[cnt]=Convert.ToInt32(Console.ReadLine());
            totalMarks=totalMarks+marks[cnt];
            cnt++;
            }
            percentage=totalMarks/(double)6;
            percentage=(double)System.Math.Round(percentage,3);
        }

        public void displayMarks()
        {
            int c=-1;
            foreach(subjects s in Enum.GetValues(typeof(subjects)))
            {
                Console.WriteLine(s+":"+marks[c+1]);
                c++;
            }
            for(int i=0;i<30;i++)
            Console.Write("-");
            Console.WriteLine();
            Console.WriteLine("Total Marks :"+totalMarks);
            Console.WriteLine("Percentage :"+String.Format("{0:0.00}", percentage));
            for(int i=0;i<30;i++)
            Console.Write("-");
            Console.WriteLine();
        }
    }
}
