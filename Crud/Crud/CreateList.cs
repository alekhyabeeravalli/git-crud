using System;
using System.Collections.Generic;
using System.Text;

namespace Crud
{
    public static class Create
    {
        public static void CreateEmployee(ref List<Employee> employee)
        {
            Console.WriteLine("enter a number for no of employees:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Employee emp = new Employee();
                Console.WriteLine("enter id:");
                emp.id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter firstname:");
                emp.firstname = Console.ReadLine();
                Console.WriteLine("enter lastname:");
                emp.lastname = Console.ReadLine();
                employee.Add(emp);
            }
            Console.WriteLine("data is successfully updated");
            Console.WriteLine("employee details are");
            foreach (var i in employee)
            {
                Console.WriteLine("id:{0} firstname:{1} lastname:{2}", i.id, i.firstname, i.lastname);
            }
            Console.ReadLine();
        }
    }
}
    

