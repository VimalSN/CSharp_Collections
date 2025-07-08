using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharp_Collections.Ex_Delegates;

namespace CSharp_Collections
{
    public class Ex_Delegates
    {
        public delegate int add1(int x, int y, int z);
        public class Ex_SingleCastDelegate
        {
            public int newadd(int x1, int y1, int z1)
            {
                return x1 + y1 + z1;
            }
            public int newadd2(int x2, int y2, int z2)
            {
                return x2 + y2 + z2;
            }
            public void showdata()
            {
                Console.WriteLine("show data()");
            }
        }
        public delegate int del_me(int x, int y);
        public class Ex_MultiCastDelegate
        {
            public static int add1(int x1, int y1)
            {

                return x1 + y1;
            }
            public static int multiple(int x, int y)
            {
                return x * y;
            }
            public static int divide(int x, int y)
            {
                return x / y;
            }
        }
        public class Ex_GenericDelegate
        {
            public static double AddNumber1(int a1, float a2, double d1)
            {
                return a1 + a2 + d1;
            }
            public static void AddNumber2(int a1, float a2, double d1)
            {
                Console.WriteLine(a1 + a2 + d1);
            }
            public static bool  CheckLength(string name)
            {
                if (name.Length >= 5)
                    return true;
                return false;
            }
        }
    }
}

