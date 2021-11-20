using System;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerableIQueryableDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            var datasource = @"(localdb)\MSSQLLocalDB";
            var database = "Practice";

            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=False;";
            var context = new EmployeeContext(connString);


            IEnumerable<Employee> _Employee = context.Employees.Where(x => x.Id > 0);
            _Employee = _Employee.Take(1);

            foreach (var item in _Employee)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.FirstName);
                Console.WriteLine(item.LastName);
                Console.WriteLine(item.Address);
            }
            Console.WriteLine("//////////////////////////////////////////");

            IQueryable<Employee> Employee = context.Employees.Where(x => x.Id > 0);
            Employee = Employee.Take(1);

            foreach (var item in Employee)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.FirstName);
                Console.WriteLine(item.LastName);
                Console.WriteLine(item.Address);
            }

            Console.ReadKey();
        }
    }
}
