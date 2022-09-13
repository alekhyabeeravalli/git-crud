using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;

namespace Crud
{
    public class DataSerializer
    {
        public void BinarySerialize(ref List<Employee> employee, string filepath)
        {
            FileStream filestream;
            BinaryFormatter binaryformatter = new BinaryFormatter();
            if (File.Exists(filepath)) File.Delete(filepath);
            filestream = File.Create(filepath);
            binaryformatter.Serialize(filestream, employee);
            filestream.Close();
            Console.WriteLine("Data is successfully Serialize");
            Console.ReadLine();
        }
        public List<Employee> BinaryDeserialize(string filepath)
        {
            List<Employee> obj = null;
            FileStream filestream;
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            if(File.Exists(filepath))
            {
                filestream = File.OpenRead(filepath);
                obj = (List<Employee>)binaryFormatter.Deserialize(filestream);
                filestream.Close();
            }
            return obj;
        }
                

        }
            
            
    }

