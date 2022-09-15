using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LITWARE_Class;


namespace LIT_WARE2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            bool a = true;

            Console.WriteLine("WELCOME TO LITWARE ORGANIZATION");
            Console.WriteLine("========================================");
            try
            {
                while (a)
                {


                    Console.WriteLine("Enter EMPLOYEE NUMBER");
                    int no = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("Enter EMPLOYEE NAME");
                    string name = Console.ReadLine();


                    Console.WriteLine("Enter EMPLOYEE SALARY");
                    double sal = Convert.ToDouble(Console.ReadLine());



                    Employee emp = new Employee(no, name, sal);
                    employees.Add(emp);

                    Console.WriteLine(" YOU HAVE SUCCESSFULLY REGISTERED");

                    Console.WriteLine("ENTER 0 TO EXIT");

                    int i = Convert.ToInt32(Console.ReadLine());
                    if (i == 0)
                    {
                        a = false;
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
