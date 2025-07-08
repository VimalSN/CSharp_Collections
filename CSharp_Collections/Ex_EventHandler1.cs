using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Collections
{
    public class EnterName
    {
        public event EventHandler<BannedUserEventArgs> ev_BannedUser;
        public void User()
        {
            Console.Write("Enter You Name : ");
            string user = Console.ReadLine();

            if ((user == "Jack" || user == "Steven" || user == "Mathew") && (ev_BannedUser != null))
            {
                ev_BannedUser(this, new BannedUserEventArgs(user));
            }
            else
            {
                Console.WriteLine("Welcome to " + user);
            }
        }
    }

    public class BannedUserEventArgs : EventArgs
    {
        public BannedUserEventArgs(string s)
        {
            Name = s;
        }
        public string Name { get; set; }
    }
}
