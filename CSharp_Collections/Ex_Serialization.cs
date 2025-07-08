using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CSharp_Collections
{
    public class Emp_Cls
    {
        public int empid { get; set; }          
        public string empname { get; set; }
        public string empaddress { get; set; }
        public int empsalary { get; set; }
    }
    public class Ex_Serialization
    {
        public void Ex_New_JsonSeralizationAndDeseralization()
        {
            Emp_Cls e1 = new Emp_Cls();
            Console.WriteLine("Enter EmpID as integer");
            e1.empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter EmpName as string");
            e1.empname = Console.ReadLine();
            Console.WriteLine("Enter empAddress as string");
            e1.empaddress = Console.ReadLine();
            Console.WriteLine("Enter EmpSalary as integer");
            e1.empsalary = Convert.ToInt32(Console.ReadLine());
            string ex_json = JsonConvert.SerializeObject(e1, Formatting.Indented);
            using (FileStream fs = new FileStream(@"C:\Demo\pp1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(ex_json);
                sw.Flush();
                sw.Close();
            }
            object final_result = JsonConvert.DeserializeObject(ex_json);
            Console.WriteLine(final_result.ToString());

           


        }
    }
}
