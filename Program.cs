using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_Version2
{
    class Employee
    {
        string EmpName;
        double Salary;
        string DepartmentName;

        public void setEmpDetails(string EmpName, double Salary, string DepartmentName)
        {
            this.EmpName = EmpName;
            this.Salary = Salary;
            this.DepartmentName = DepartmentName;
        }

        public void displayEmpDetails()
        {
            Console.WriteLine(EmpName+Salary+DepartmentName);
        }

        public void searchByDepartment(string DepartmentName)
        {
            if(this.DepartmentName==DepartmentName)
            {
                displayEmpDetails();
            }
        }
       
    }
    class Program
    {

        static void Main(string[] args)
        {
            Employee[] e;
            e = new Employee[3];
            e[0] = new Employee();
            e[1] = new Employee();
            e[2] = new Employee();

            for (int i=0;i<e.Length;i++)
            {
                string name = Console.ReadLine();
                double salary = Convert.ToDouble(Console.ReadLine());
                string Dname = Console.ReadLine();

                e[i].setEmpDetails(name,salary,Dname);
            }

            foreach (Employee data in e)
            {
                data.displayEmpDetails();
            }
            string dName = "MR";
            foreach(Employee data in e)
            {
                data.searchByDepartment(dName);
            }
            Console.ReadLine();

        }
    }
}
