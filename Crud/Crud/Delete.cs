using System;
using System.Collections.Generic;
using System.Text;

namespace Crud
{
    public static class Delete
    {
        public static void DeleteEmployee(ref List<Employee> employee)
        {
            Console.WriteLine("enter the employee id to delete from the database");
            int id = Convert.ToInt32(Console.ReadLine());
            var find = employee.Find(x => x.id == id);
            if (find != null)
            {
                Console.WriteLine("enter the number to delete \n 1.particular row \n 2.total data");
                int number = Convert.ToInt32(Console.ReadLine());
                foreach (var i in employee)
                {
                    if (number == 1)
                    {
                        employee.RemoveAt(0);
                        Console.WriteLine("data is removed");
                    }
                    else if (number == 2)
                    {
                        employee.Clear();
                        Console.WriteLine("total data is removed from database");
                    }
                }
            }
            else
            {
                throw new Exception("id not found");
            }
            Console.ReadLine();
        }
    }
}
                        

            
