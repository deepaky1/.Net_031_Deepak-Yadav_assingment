using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        public static void Main()
        {
            Employee o1 = new Employee("Amol", 123465, 20);
            Employee o2 = new Employee("Amol", 12345);
            Employee o3 = new Employee("Amol");
            Employee o4 = new Employee();

            Console.WriteLine(o1.Empno);
            Console.WriteLine(o2.Empno);
            Console.WriteLine(o3.Empno);
            Console.WriteLine(o4.Empno);
        }
       
        public class Employee
        {
            static int counter =0;
            private string empName;
            public string Empname
            {
                set
                {
                    if (value != null || value == "")
                    {
                        empName = value;
                    }
                    else
                    {
                        Console.WriteLine("Employee Name Can not be Empty");
                    }
                }

            }
            private static int empNo;
            public int Empno
            {
                get { return empNo++; }
            }
            private decimal basic;
            public decimal Basic
            {
                set
                {
                    if (value > 4000 && value < 25000)
                    { basic = value; }
                    else
                    {
                        Console.WriteLine("Basic should be in 4000 to 25000 range");
                    }
                }
            }
            private short deptNo;
            public short Deptno
            {
                set
                {
                    if (value > 0)
                    {
                        deptNo = value;
                    }
                    else
                    {
                        Console.WriteLine("Department Number should be between 0 to 128");
                    }
                }
            }

            public Employee() { }

           public Employee(string name, decimal basicp, short depart)
            {
                this.empName = name;
                this.basic = basicp;
                this.deptNo = depart;
                empNo =++counter;
            }

            public Employee(string name, decimal basicp)
            {
                this.empName = name;
                this.basic = basicp;
                empNo = ++counter;
            }
            public Employee(string name)
            {
                this.empName = name;
                empNo = ++counter;
            }

            public decimal GetNetSalary()
            {
                return basic * 0.06m + 5000;
            }
            public string toString()
            {
                return "Name : " + this.empName + " Employee : " + empNo + "  Employee salary  : " + this.GetNetSalary();
            }
        }
    }
}