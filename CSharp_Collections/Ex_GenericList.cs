using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Collections
{
    public class Dept_Cls
    {
        public int deptid { get; set; }
        public string deptname { get; set; }
        public string deptlocation { get; set; }
    }
    public class Ex_GenericList
    {
        public void AddListItem()
        {
            List<Dept_Cls> d1 = new List<Dept_Cls>();
            d1.Add(new Dept_Cls { deptid = 1, deptname = "Admin", deptlocation = "USA" });
            d1.Add(new Dept_Cls { deptid = 2, deptname = "Sales", deptlocation = "UK" });
            d1.Add(new Dept_Cls { deptid = 3, deptname = "Accounts", deptlocation = "IND" });
            d1.Add(new Dept_Cls { deptid = 4, deptname = "ForntOffice", deptlocation = "CHN" });
            d1.Add(new Dept_Cls { deptid = 5, deptname = "BackOffice", deptlocation = "SGN" });

            foreach(var d in d1)
            {
                Console.WriteLine("Result is {0},{1},{2}", d.deptid, d.deptname, d.deptlocation);
            }

            List<Dept_Cls> d2 = new List<Dept_Cls>()
            {
                new Dept_Cls{deptid=10,deptname="Admin",deptlocation ="USA"},
                new Dept_Cls{deptid=11,deptname="Sales",deptlocation ="UK"},
                new Dept_Cls{deptid=12,deptname="Tech",deptlocation ="IND"},
                new Dept_Cls{deptid=13,deptname="NonTech",deptlocation ="JAPAN"},
                new Dept_Cls{deptid=14,deptname="NewTech",deptlocation ="CHN"}
            };
        }
        public Dept_Cls Accept_Details(Dept_Cls dept)
        {
            List<Dept_Cls> d1 = new List<Dept_Cls>();
            Console.WriteLine("Enter Dept Id as integer value");
            dept.deptid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Dept Name as string value");
            dept.deptname = Console.ReadLine();
            Console.WriteLine("Enter Dept Location as string value");
            dept.deptlocation = Console.ReadLine();
            d1.Add(dept);
            Console.WriteLine("Result is {0},{1},{2}", dept.deptid, dept.deptname, dept.deptlocation);
            return dept;
        }
    }
}

