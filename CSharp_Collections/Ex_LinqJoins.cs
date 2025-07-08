using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Collections
{
    public class User_Role
    {
        public int roleid { get; set; } //1,2
        public string rolename { get; set; }//Admin,User
    }
    public class User_Login
    {
        public int userid { get; set; } //001,002,003,004,005
        public string username { get; set; } //user1,user2,user3,user4,user5
        public string password { get; set; }
        public string email { get; set; }
        public string mobileno { get; set; }
    }
    public class User_RoleMapping
    {
        public int roleid { get; set; } //1,2
        public int userid { get; set; }//001,002,002,003,004,004
    }
    public class Ex_LinqJoins
    {
        public static List<User_Role> ur = new List<User_Role>()
        {
            new User_Role{roleid=1,rolename="Admin"},
            new User_Role{roleid=2,rolename="User"}
        };

        public static List<User_Login> ul = new List<User_Login>()
        {
            new User_Login{userid=001,username="user1",password="user1@123$",email="user1@email.com",mobileno="8978907"},
            new User_Login{userid=002,username="user2",password="user2@123$",email="user2@email.com",mobileno="986789"},
            new User_Login{userid=003,username="user3",password="user3@123$",email="user3@email.com",mobileno="956789"}
        };
         
        public static List<User_RoleMapping> um = new List<User_RoleMapping>()
        {
            new User_RoleMapping{roleid=1,userid=001},
            new User_RoleMapping{roleid=2,userid=002},
            new User_RoleMapping{roleid=2,userid=003}
        };

        public void Linq_Queries()
        {
            //1.) Inner Joins 
            //var result = (from ur1 in ur
            //              join um1 in um on ur1.roleid equals um1.roleid
            //              join ul1 in ul on um1.userid equals ul1.userid
            //              select new { ul1.userid, ul1.username });
            //foreach (var r in result)
            //{
            //    Console.WriteLine("Result is {0},{1}", r.userid, r.username);
            //}

            //2.) Left Outer Join
            //var result = (from ul1 in ul
            //              join um1 in um on ul1.userid equals um1.roleid
            //              select new { ul1.userid, ul1.username, um1.roleid });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Result is {item.username}:{item.roleid}");
            //}

            //3.) Right Outer Join
            var result = from um1 in um
                         join ul1 in ul on um1.roleid equals ul1.userid into joined
                         from ul1 in joined.DefaultIfEmpty()
                         select new
                         {
                             userid = ul1?.userid,
                             username = ul1?.username ?? "No User",
                             roleid = um1.roleid
                         };

            foreach (var item in result)
            {
                Console.WriteLine($"Result is {item.username}:{item.roleid}");
            }

            //4.) Cross Join
            var crossJoin = from ur1 in ur
                            from ul1 in ul
                            select new
                            {
                                ur1.rolename,
                                ul1.username,
                                ul1.userid
                            };

            foreach (var item in crossJoin)
            {
                Console.WriteLine($"User: {item.username} ({item.userid}), Role: {item.rolename}");
            }

        }

    }
}
