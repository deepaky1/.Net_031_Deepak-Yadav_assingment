using System;

namespace Assingnment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Manager");
            Manager mg = new Manager("Testing", "Deepak", 31, 10000);
            Console.WriteLine(mg.Name + "   " + mg.Basic);
            Console.WriteLine("Total sal : " + mg.CalcNetSalary());
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("General Manager");
            GeneralManager gmg = new GeneralManager("Testing", "Testing", "Suraj", 32, 20000);
            Console.WriteLine(gmg.Name + "   " + gmg.Basic);
            Console.WriteLine("Total sal : " + gmg.CalcNetSalary());
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("CEO");
            CEO c = new CEO("Ram", 33, 30000);
            Console.WriteLine(c.Name + "   " + c.Basic);
            Console.WriteLine("Total sal : " + c.CalcNetSalary());
            Console.ReadLine();
        }
    }

    public abstract class Employee
    {
        private string name;
        private int empNo;
        private short deptNo;
        private decimal basic;
        public static int id;
        public abstract decimal CalcNetSalary();


        public string Name
        {
            set
            {
                if (value != null) name = value;
                else Console.WriteLine("Name can Not Be Empty");
            }
            get
            { return name; }
        }


        public int EmpNo
        {
            get;
        }

        public short DeptNo
        {
            set
            {
                if (value > 0 && value < 128) deptNo = value;
                else Console.WriteLine("DeptNo can Not Be More than 128");
            }
            get { return deptNo; }
        }
        public abstract decimal Basic
        {
            get;
            set;
        }
        public Employee(string name, short deptNo, decimal basicSal)
        {
            id++;
            this.EmpNo = id;
            this.Name = name;
            this.DeptNo = deptNo;
            this.Basic = basicSal;
        }
    }
    public class Manager : Employee
    {

        private string designation;
        public string Designation
        {
            get { return designation; }
            set { if (value != null) designation = value; else Console.WriteLine("Name can Not Be Empty"); }
        }

        public override decimal Basic { get; set; }

        public Manager(string designation, string name, short deptNo, decimal basicSal) : base(name, deptNo, basicSal)
        {
            this.Designation = designation;
        }
        public override decimal CalcNetSalary()
        {
            double expense = 1000;
            decimal totalSal = Basic - (decimal)expense;
            return totalSal;
        }
    }

    public class GeneralManager : Manager
    {
        private string perks;
        public string Perks
        {
            get { return perks; }
            set { perks = value; }
        }

        public GeneralManager(string perks, string designation, string name, short deptNo, decimal basicSal) : base(designation, name, deptNo, basicSal)
        {
            this.Perks = perks;
        }
        public override decimal CalcNetSalary()
        {
            double expense = 2000;
            decimal netSal = Basic + (decimal)expense;
            return netSal;
        }
    }

    public class CEO : Employee
    {
        public CEO(string name, short deptNo, decimal basicSal) : base(name, deptNo, basicSal)
        {
         //   Console.WriteLine("CEO constructor ");
        }

        public override decimal Basic { get; set; }

        public sealed override decimal CalcNetSalary()
        {
            double expense = 3000;
            decimal netSal = Basic - (decimal)expense;
            return netSal;
        }

    }
}