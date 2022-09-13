using System;
using System.Collections.Generic;


namespace Crud
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>();
            DataSerializer dataserializer = new DataSerializer();
            Console.WriteLine("CRUD OPERATORS");
            bool condition = true;
            while (condition)
            {
                Console.WriteLine("1. create employee details:");
                Console.WriteLine("2. read employee details:");
                Console.WriteLine("3. update employee details:");
                Console.WriteLine("4. delete employee details:");
                Console.WriteLine("5. create Excelsheet:");
                Console.WriteLine("6. import data from excel:");
                Console.WriteLine("7.Serialization:");
                Console.WriteLine("8. Deserialzation:");
                Console.WriteLine("9.for sort by name");
                Console.WriteLine("10.sort by id:");
                Console.WriteLine("11.Exit");
                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            Create.CreateEmployee(ref employee);
                            break;
                        case 2:
                            Read.ReadEmployee(ref employee);
                            break;
                        case 3:
                            Update.UpdateEmployee(ref employee);
                            break;
                        case 4:
                            Delete.DeleteEmployee(ref employee);
                            break;
                        case 5:
                            CreateExcel.SaveToExcel(ref employee);
                            break;

                        case 6:
                            CreateExcel.ImportToList(ref employee);
                            break;
                        case 7:
                            string filepath = "save-path";
                            dataserializer.BinarySerialize(ref employee, filepath);
                            break;
                        case 8:
                            List<Employee> s = null;
                            string filepaths = "save-path";
                            s = dataserializer.BinaryDeserialize(filepaths);
                            foreach (var a in employee)
                            {
                                Console.WriteLine("{0} {1} {2}", a.id, a.firstname, a.lastname);
                            }
                            Console.ReadLine();
                            break;
                        case 9:
                            SortByName names = new SortByName();
                            employee.Sort(names);
                            foreach (var a in employee)
                            {
                                Console.WriteLine("{0} {1} {2}", a.id, a.firstname, a.lastname);
                            }
                            Console.ReadLine();
                            break;
                        case 10:
                            SortById Id = new SortById();
                            employee.Sort(Id);
                            foreach (var a in employee)
                            {
                                Console.WriteLine("{0} {1} {2}", a.id, a.firstname, a.lastname);
                            }
                            Console.ReadLine();
                            break;
                        case 11:
                            condition = false;
                            break;
                        default:
                            Console.WriteLine("invalid number");
                            break;
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
            Console.WriteLine("THANK YOU FOR USING APPLICATION");
        }
    }
}

           
