using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_03
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




            Console.WriteLine("----------------------------------------");
            IDbfunction i1 = new Manager();
            i1.Delete();
            i1.Update();
            i1.Insert();
            Console.WriteLine("----------------------------------------");
            IDbfunction i2 = new GeneralManager();
            i2.Insert();
            i2.Delete();
            i2.Update();
            Console.WriteLine("----------------------------------------");
            IDbfunction i3 = new CEO();
            i3.Delete();
            i3.Update();
            i3.Insert();
            Console.ReadLine();

            Console.ReadLine();
        }


        public interface IDbfunction
        {
            void Insert();
            void Update();
            void Delete();
        }


        public abstract class Employee : IDbfunction
        {
            private string name;
            private int empNo;
            private short deptNo;
            private decimal basic;
            public static int id;
            public abstract decimal CalcNetSalary();

            public void Insert()
            {
                Console.WriteLine("Employee class Insert Method ");
            }

            public void Update()
            {
                Console.WriteLine("Employee class Update Method ");
            }

            public void Delete()
            {
                Console.WriteLine("Employee class Delete Method ");
            }

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

            public Employee()
            {
               // Console.WriteLine("Employee class Without Parameter Method ");
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
        public class Manager : Employee, IDbfunction
        {

            void IDbfunction.Insert()
            {
                Console.WriteLine("Manager class Update Method ");
            }

            public new void Update()
            {
                Console.WriteLine("Employee class Update Method ");
            }

            public new void Delete()
            {
                Console.WriteLine("Employee class Delete Method ");
            }

            public Manager()
            {
                //Console.WriteLine("Manager class non Parameter constructor Method ");
            }
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

        public class GeneralManager : Manager ,IDbfunction
        {
           public new void Insert()
            {
                Console.WriteLine(" General Manager class Insert Method ");
            }

            public new void Update()
            {
                Console.WriteLine("General Manager class Update Method ");
            }

            public new void Delete()
            {
                Console.WriteLine("General Manager class Delete Method ");
            }

            public GeneralManager()
            {
               // Console.WriteLine("General Manager non parameter constructor");
            }

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

        public class CEO : Employee ,IDbfunction
        {

            public CEO()
            {
               // Console.WriteLine("CEO Constructor non param call");
            }
            public new void Insert()
            {
                Console.WriteLine("CEO class Insert method ");
            }

            public new void Update()
            {
                Console.WriteLine("CEO class Update method ");
            }

            public new void Delete()
            {
                Console.WriteLine("CEO class Delete method ");
            }

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
}