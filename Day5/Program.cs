using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_5
{
    
    class Program
    {
        static void Main1(string[] args)
        {
            Employees[] arr = new Employees[3];
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter Employee {i} Id  : ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Enter Employee {i} Name : ");
                string name = Console.ReadLine();
                Console.Write($"Enter Employee {i} Sal : ");
                decimal sal = Convert.ToDecimal(Console.ReadLine());
                arr[0] = new Employees(id,name,sal);
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].EmpSal > arr[j + 1].EmpSal)
                    {

                        Employees temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].EmpSal == arr[arr.Length - 1].EmpSal)
                    Console.WriteLine(arr[i].EmpId + " " + arr[i].EmpName + "  " + arr[i].EmpSal);
            }


            int eno = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].EmpId == eno)
                    Console.WriteLine(arr[i].EmpId + " " + arr[i].EmpName + "  " + arr[i].EmpSal);
            }
            Console.ReadLine();
        }

    }
    class Employees
    {
        private int empId;
        public int EmpId
        {
            get;
            set;
        }
        private string empName;
        public string EmpName { get; set; }
        private decimal empSal;
        public decimal EmpSal { get; set; }

        public Employees(int empId, string empName, decimal empSal)
        {
            this.EmpId = empId;
            this.EmpName = empName;
            this.EmpSal = empSal;
        }
       
    }
}


namespace Question2
{
    class Que2
    {
        static void Main2()
        {
            Console.Write("Enter Number of Batches : ");
            int b = Convert.ToInt32(Console.ReadLine());
            int[][] arr = new int[b][];
            for (int i = 0; i < b; i++)
            {
                Console.Write($"Enter Number of Student in {i + 1} : ");
                int s = Convert.ToInt32(Console.ReadLine());
                arr[i] = new int[s];
                for (int j = 0; j < s; j++)
                {
                    Console.Write($"Enter Marks Batch {i + 1} Student {j + 1} : ");
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());

                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine($"Batch {i + 1} Stuendt {j + 1} Marks are :" + arr[i][j]);
                }
            }
            Console.ReadLine();
        }
    }
}

namespace Question3
{
    class Que3 { 
        
        static void Main()
      {
        Student s1 = new Student("Mani", 1, 350);
        Student s2 = new Student("ganesh", 2, 400);
        Student s3 = new Student("Abhi", 3, 500);
        Student s4 = new Student("rasmi", 4, 400);
        Student s5 = new Student("Nikita", 5, 800);

        Student[] arr = { s1, s2, s3, s4, s5 };
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i].Name + "  " + arr[i].RollNo + "  " + arr[i].Marks);
        }
        Console.ReadLine();
    }

        public struct Student
        {
            private string name;
            private int rollNo;
            private decimal marks;
            private string naw;
            public string Name { get { return name; } set { if (value == null) Console.WriteLine("Invalid Name "); else name = value; } }
            public string Naw { get { return naw; } set { if (value == null) Console.WriteLine("Invalid Name "); else naw = value; } }
            public int RollNo { get { return rollNo; } set { if (value > 0) rollNo = value; else Console.WriteLine("Invalid RollNo"); } }

            public decimal Marks { get; set; }

           public Student(string name,int rollNo,decimal marks)
            {
                //this.Naw = naw;
                this.Name = name;
                this.RollNo = rollNo;
                this.Marks = marks;

            }
        }

    }
}

