using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Collections
{

    public class Employee_Cls
    {
        public int empid { get; set; }
        public string empname { get; set; }
        public string empaddress { get; set; }
        public int empsalary { get; set; }
    }
    public class Ex_NewGnericCls<T>
    {
        public void Swap(T t1, T t2)
        {
            T temp;
            temp = t1;
            t1 = t2;
            t2 = temp;
            Console.WriteLine(t1 + "    " + t2);
        }
    }
    public class Ex_Generic
    {
        public void add2<T>(T t1, T t2)
        {
            Console.WriteLine(t1);
            Console.WriteLine(t2);
        }
        public T add3<T>(T t1, T t2)
        {
            var r1 = Convert.ToInt32(t1);
            var r2 = Convert.ToInt32(t2);

            return (T)(dynamic)(r1 + r2);

        }
    }
}




