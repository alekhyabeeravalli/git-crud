using System;
using System.Collections.Generic;
using System.Text;

namespace Crud
{
   public static class Update
    {
        public static void UpdateEmployee(ref List<Employee> employee)
        {
            Console.WriteLine("enter the employee id tou want to update");
            int id = Convert.ToInt32(Console.ReadLine());
            var find = employee.Find(x => x.id == id);
            if(find != null)
            {
                Console.WriteLine("enter the number to update \n 1.firstname \n 2.lastname");
                int number = Convert.ToInt32(Console.ReadLine());
                if(number == 1)
                {
                    Console.WriteLine("enter firstname");
                    find.firstname = Console.ReadLine();

                }
                else if(number == 2)
                {
                    Console.WriteLine("enter lastname");
                    find.lastname = Console.ReadLine();
                }
                else
                {
                    throw new Exception("invalid number");
                }
                    
            }
            else
            {
                throw new Exception("id not found");
            }
        }
    }
}
