using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Collections
{
    public delegate void MyHandler1(object sender, MyEventArgs e);
    public delegate void MyHandler2(object sender, MyEventArgs e);
    public class MyEventArgs : EventArgs
    {
        public string m_id;
    }
    public class Ex_EventHandler
    {
        public const string m_id = "Class A";
        public Ex_EventHandler(B b)
        {
            MyHandler1 d1 = new MyHandler1(OnHandler1);
            MyHandler2 d2 = new MyHandler2(OnHandler2);
            b.Event1 += d1;
            b.Event2 += d2;
        }
        public void OnHandler1(object sender, MyEventArgs e)
        {
            Console.WriteLine("I am in OnHandler1 and MyEventArgs is {0}", e.m_id);
        }
        public void OnHandler2(object sender, MyEventArgs e)
        {
            Console.WriteLine("I am in OnHandler2 and MyEventArgs is {0}", e.m_id);
        }
    }
    public class B
    {
        public event MyHandler1 Event1;
        public event MyHandler2 Event2;
        public void FireEvent1(MyEventArgs e)
        {
            if (Event1 != null)
            {
                Event1(this, e);
            }
        }
        public void FireEvent2(MyEventArgs e)
        {
            if (Event2 != null)
            {
                Event2(this, e);
            }
        }
    }
}
