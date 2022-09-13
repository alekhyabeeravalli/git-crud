using System;
using System.Collections.Generic;
using System.Text;

namespace Crud
{
    public static class Read
    {
        public static void ReadEmployee(ref List<Employee> employee)
        { 
            Console.WriteLine("enter the student id to get info");
            int id = Convert.ToInt32(Console.ReadLine());
            var find = employee.Find(x => x.id == id);
            bool condition = true;
            foreach(var i in employee)
            {
                if(id == i.id)
                {
                    Console.WriteLine("{0} {1} {2}", i.id, i.firstname, i.lastname);
                    condition = false;

                }
            }
            if(condition)
            {
                throw new Exception("id not found");
            }
            Console.ReadLine();
        }
    }
}
