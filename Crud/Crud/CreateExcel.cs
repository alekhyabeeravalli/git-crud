using System;
using System.Collections.Generic;
using System.Text;
using Ganss.Excel;
namespace Crud
{
   public static class CreateExcel
    {
        public static void SaveToExcel(ref List<Employee> employee)
        {
            ExcelMapper mapper = new ExcelMapper();
            var BookFilepath = @"C:\Users\mindc1july29.xlsx";
            mapper.Save(BookFilepath, employee, "employeedetails", true);
            Console.WriteLine("data is stored to excel");
        }
        public static void ImportToList(ref List<Employee> employee)
        {
            string filepath = @"C:\Users\mindc1july29.xlsx";
            var ListDetails = new ExcelMapper(filepath).Fetch<Employee>();
            foreach(var a in ListDetails)
            {
                Console.WriteLine("{0} {1} {2}", a.id, a.firstname, a.lastname);
            }
        }

    }
}
