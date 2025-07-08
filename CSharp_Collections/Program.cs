using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharp_Collections.Ex_Delegates;
using static CSharp_Collections.Ex_Linq;

namespace CSharp_Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("THis is new");
            Console.WriteLine("hi");
            Console.WriteLine("heyyy from yash ");

            Console.Write("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            bool? isprime = null;

            if (input <= 1)
            {
                isprime = false;
            }
            else
            {
                isprime = true;
                for (int i = 2; i <= Math.Sqrt(input); i++)
                {
                    if (input % i == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
            }

            Console.WriteLine("Is Prime: " + isprime);

            //ArrayListExample example = new ArrayListExample();
            //example.Ex_ArrayList();
            //Console.ReadLine();


            ////Generic 
            //Ex_Generic ex1 = new Ex_Generic();
            //ex1.add2<int>(800, 900);
            //ex1.add2<string>("ppp", "ssss");
            //ex1.add2<char>('p', 'c');
            //ex1.add2<double>(900.900, 7789.900);
            //Console.ReadLine();


            //GenericCls
            //Ex_NewGnericCls<int> ex2 = new Ex_NewGnericCls<int>();
            //ex2.Swap(800, 900);
            //Ex_NewGnericCls<double> ex3 = new Ex_NewGnericCls<double>();
            //ex3.Swap(800, 900);

            //Employee_Cls e1 = new Employee_Cls();
            //Employee_Cls e2 = new Employee_Cls();
            //Ex_NewGnericCls<Employee_Cls> ex4 = new Ex_NewGnericCls<Employee_Cls>();
            //ex4.Swap(e1,e2);


            //Ex_Generic e3 = new Ex_Generic();
            //var result5 = e3.add3<int>(800, 900);
            //Console.WriteLine("Result is {0}", result5);
            //Console.ReadLine();

            //GenericList
            //Ex_GenericList exl = new Ex_GenericList();
            //exl.AddListItem();
            //Console.ReadLine();


            //Dept_Cls new1 = new Dept_Cls();
            //Ex_GenericList exl = new Ex_GenericList();
            //exl.Accept_Details(new1);
            //Console.ReadLine();

            //Ex_Serialization s1 = new Ex_Serialization();
            //s1.Ex_New_JsonSeralizationAndDeseralization();


            //del_me d1 = null;
            //d1 += new del_me(Ex_MultiCastDelegate.add1);
            //int result_add = d1(10, 10);
            //Console.WriteLine("Add is {0}", result_add);
            //d1 -= new del_me(Ex_MultiCastDelegate.add1);
            //d1 += new del_me(Ex_MultiCastDelegate.multiple);
            //int result_multiple = d1(2, 2);
            //Console.WriteLine("multiple is {0}", result_multiple);
            //d1 -= new del_me(Ex_MultiCastDelegate.multiple);
            //d1 += new del_me(Ex_MultiCastDelegate.divide);
            //int result_divide = d1(4, 2);
            //Console.WriteLine("Divide is {0}", result_divide);
            //Console.ReadLine();

            //del_me d1 = new del_me(Ex_MultiCastDelegate.add1);
            //del_me d2 = new del_me(Ex_MultiCastDelegate.multiple);
            //del_me d3 = new del_me(Ex_MultiCastDelegate.divide);
            //del_me d4 = d1 + d2 + d3;
            //Delegate[] InvocationList = d4.GetInvocationList();
            //foreach (Delegate item in InvocationList)
            //{
            //    Console.WriteLine($"{item}");
            //}
            //foreach (Delegate method in d4.GetInvocationList())
            //{
            //    int individualResult = ((del_me)method).Invoke(5, 2);
            //    Console.WriteLine($"Method: {method.Method.Name}, Result: {individualResult}");
            //}
            //d4.Invoke(10, 10);
            //d4 -= d1;
            //int result_add = d4.Invoke(20, 20);
            //Console.WriteLine("Add() is {0}", result_add);
            //d4 -= d2;
            //int result_multiple = d4.Invoke(2, 2);
            //Console.WriteLine("Multiple() is {0}", result_multiple);
            ////d4 -= d3;
            //int result_divide = d4.Invoke(4, 2);
            //Console.WriteLine("Divide() is {0}", result_divide);
            //Console.ReadLine();

            //Func<int, float, double, double> obj1 = new Func<int, float, double, double>(Ex_GenericDelegate.AddNumber1);
            //Action<int, float, double> obj2 = new Action<int, float, double>(Ex_GenericDelegate.AddNumber2);
            //Predicate<string> obj3 = new Predicate<string>(Ex_GenericDelegate.CheckLength);
            //bool result_name = obj3.Invoke("Dave");
            //Console.WriteLine("Lenght of the string is bool value {0}", result_name);
            //Console.ReadLine();

            //B b = new B();
            //Ex_EventHandler a = new Ex_EventHandler(b);
            //MyEventArgs e1 = new MyEventArgs();
            //MyEventArgs e2 = new MyEventArgs();
            //e1.m_id = "Event args for event 1";
            //e2.m_id = "Event args for event 2";
            //b.FireEvent1(e1);
            //b.FireEvent2(e2);

            //EnterName ename = new EnterName();
            //ename.ev_BannedUser += WarningAlarm;
            //ename.User();
            //Console.Read();


            //string str1 = "James";
            //string str2 = str1.Reverse_str();
            //Console.WriteLine("Result is {0}", str2);
            //Console.ReadLine();

            //ALL_LINQ_EXAMPLES ex1 = new ALL_LINQ_EXAMPLES();
            //ex1.Linq_Queries();
            //Console.ReadLine();

            //Ex_LinqJoins ex2 = new Ex_LinqJoins();
            //ex2.Linq_Queries();
            //Console.ReadLine();
        }
        static void WarningAlarm(object sender, BannedUserEventArgs e)
        {
            Console.WriteLine("{0} Users Found. Sending Email to Administration.", e.Name);
            Console.WriteLine("Email Sent.");
            Console.WriteLine("Warning Alarm Started.");
            Console.WriteLine("Press Ctrl + c to stop the alarm");
            for (; ; )
            {
                Console.Beep();
                System.Threading.Thread.Sleep(100);
            }
        }
        public class Generic<T>
        {
            Stack<T> stk = new Stack<T>();
            public void push(T obj)
            {
                stk.Push(obj);
            }
            public T pop()
            {
                T obj = stk.Pop();
                return obj;
            }
        }
    }
}
