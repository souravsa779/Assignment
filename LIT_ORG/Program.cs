using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIT_ORG
{
    public class Employee
    {
        private int EmpNo { get; set; }
        private string EmpName { get; set; }
        private double Salary { get; set; }
        private double HRA { get; set; }
        private double TA { get; set; }
        private double DA { get; set; }
        private double PF { get; set; }
        private double TDS { get; set; }
        private double NetSalary { get; set; }
        private double GrossSalary { get; set; }

        public Employee(int x, string n, double s)
        {
            EmpNo = x;
            EmpName = n;
            Salary = s;

        }

        public void CalculatedSalary()
        {
            Console.WriteLine("EMPLOYEE NUMBER -->" + EmpNo);
            Console.WriteLine("EMPLOYEE NAME  --> " + EmpName);
            if (Salary < 5000)
            {
                HRA = Salary * 0.1;
                TA = Salary * 0.05;
                DA = Salary * 0.15;
                GrossSalary = Salary + HRA + TA + DA;
                PF = 0.1 * GrossSalary;
                TDS = 0.18 * GrossSalary;
                NetSalary = GrossSalary - (PF + TDS);
                Console.WriteLine("PF==" + PF);
                Console.WriteLine("TDS==" + TDS);
                Console.WriteLine("NETSALARY ==" + NetSalary);
            }
            else if (Salary < 10000)
            {
                HRA = Salary * 0.15;
                TA = Salary * 0.1;
                DA = Salary * 0.2;
                GrossSalary = Salary + HRA + TA + DA;
                PF = 0.1 * GrossSalary;
                TDS = 0.18 * GrossSalary;
                NetSalary = GrossSalary - (PF + TDS);
                Console.WriteLine("PF==" + PF);
                Console.WriteLine("TDS==" + TDS);
                Console.WriteLine("NETSALARY ==" + NetSalary);
            }
            else if (Salary < 15000)
            {
                HRA = Salary * 0.2;
                TA = Salary * 0.15;
                DA = Salary * 0.25;
                GrossSalary = Salary + HRA + TA + DA;
                PF = 0.1 * GrossSalary;
                TDS = 0.18 * GrossSalary;
                NetSalary = GrossSalary - (PF + TDS);
                Console.WriteLine("PF==" + PF);
                Console.WriteLine("TDS==" + TDS);
                Console.WriteLine("NETSALARY ==" + NetSalary);
            }
            else if (Salary < 20000)
            {
                HRA = Salary * 0.25;
                TA = Salary * 0.2;
                DA = Salary * 0.3;
                GrossSalary = Salary + HRA + TA + DA;
                PF = 0.1 * GrossSalary;
                TDS = 0.18 * GrossSalary;
                NetSalary = GrossSalary - (PF + TDS);
                Console.WriteLine("PF==" + PF);
                Console.WriteLine("TDS==" + TDS);
                Console.WriteLine("NETSALARY ==" + NetSalary);
            }
            else if (Salary >= 20000)
            {
                HRA = Salary * 0.3;
                TA = Salary * 0.25;
                DA = Salary * 0.35;
                GrossSalary = Salary + HRA + TA + DA;
                PF = 0.1 * GrossSalary;
                TDS = 0.18 * GrossSalary;
                NetSalary = GrossSalary - (PF + TDS);
                Console.WriteLine("PF==" + PF);
                Console.WriteLine("TDS==" + TDS);
                Console.WriteLine("NETSALARY ==" + NetSalary);
            }
            else
            {
                Console.WriteLine("INVALID INPUT");
            }

        }
    }





        internal class Program
        {
            static void Main(string[] args)
            {
            Console.WriteLine("WELCOME TO LITWARE ORGANIZATION");
            Console.WriteLine("========================================");

            Console.WriteLine("Enter EMPLOYEE NUMBER");
            int no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter EMPLOYEE NAME");
            string name = Console.ReadLine();

            Console.WriteLine("Enter EMPLOYEE SALARY");
            double sal = Convert.ToDouble(Console.ReadLine());

            Employee emp = new Employee(no, name, sal);
            emp.CalculatedSalary();
        }
        }
    
}
