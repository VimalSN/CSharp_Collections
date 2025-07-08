using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Collections
{
    public class Ex_Linq
    {
        public class NewEmpCls
        {
            public int empid { get; set; }
            public string empname { get; set; }
            public string empaddress { get; set; }
            public int empsalary { get; set; }

        }
        public class UserLogin
        {
            public int userid { get; set; } // 001,002,003,004
            public string username { get; set; } // user1,user2,user3,user3,user5,
                                                 // useradmin01,useradmin02
            public string password { get; set; }
            public string email { get; set; }
            //public int RoleId { get; set; }
        }
        public class ALL_LINQ_EXAMPLES
        {
            public static List<NewEmpCls> emplist = new List<NewEmpCls>()
            {
                new NewEmpCls{empid=1,empname="Eric",empaddress="USA",empsalary=8000},
                new NewEmpCls{empid=2,empname="James",empaddress="UK",empsalary=81000},
                new NewEmpCls{empid=3,empname="Rajesh",empaddress="INDIA",empsalary=99000},
                new NewEmpCls{empid=4,empname="Jayson",empaddress="FRANCE",empsalary=10000},
                new NewEmpCls{empid=5,empname="Enric",empaddress="IRELAND",empsalary=18000}
            };

            List<UserLogin> r2 = new List<UserLogin>()
            {
                new UserLogin{userid=001,username="user1",password="satyam@123$",email="user1@email.com"},
                new UserLogin{userid=002,username="user2",password="satyam@123$",email="user2@email.com"},
                new UserLogin{userid=003,username="user3",password="satyam@123$",email="user3@email.com"},
                new UserLogin{userid=004,username="Adminuser1",password="satyam@123$",email="adminuser1@email.com"},
                new UserLogin{userid=005,username="Adminuser2",password="satyam@123$",email="adminuser2@email.com"}
            };

            public void Linq_Queries()
            {
                //Q1.) Display all employee's in the emplist collection
                /* var result = from c1 in emplist select c1;
                 foreach (var emp in result)
                     Console.WriteLine("Result is {0},{1},{2},{3}",emp.empid.ToString(),
                         emp.empname, emp.empaddress, emp.empsalary.ToString());*/

                //Q2.) Display all employee's who's salary is between 10000 and 30000
                /* var result = from c1 in emplist
                              where c1.empsalary >= 10000 && c1.empsalary <= 30000
                              select c1;
                 foreach (var c in result)
                     Console.WriteLine("Salaries are {0},{1},{2},{3}",
                         c.empid, c.empname, c.empaddress, c.empsalary);*/

                //Q3.) Display all employee's who's name's are starting with letter 'E'
                /* var result = from c1 in emplist
                              where c1.empname.StartsWith("E")
                              select c1;
                 foreach (var c in result)
                     Console.WriteLine("Salaries are {0},{1},{2},{3}",
                         c.empid, c.empname, c.empaddress, c.empsalary);*/

                //Q4.) Display all employee's who are not  residing in the country USA
                /*var result = from c1 in emplist
                             where c1.empaddress != "USA"
                             select c1;

                foreach (var c in result)
                    Console.WriteLine("Salaries are {0},{1},{2},{3}",
                        c.empid, c.empname, c.empaddress, c.empsalary);*/
                //Q5.) Display all employee's who are getting the highest salary
                //var result = (from c1 in select c1).Max(c => c.empsalary);
                //Console.WriteLine(result);

                //Question 6: Display employee who get the lowest salary
                //var result = (from obj in emplist where obj.empsalary == emplist.Min(x => x.empsalary) select obj);
                //Console.WriteLine(result);
                //foreach (var item in result)
                //{
                //    Console.WriteLine("Result : {0},{1},{2}", item.empid.ToString(), item.empname.ToString(), item.empaddress.ToString());
                //}


                //QUestion 7 : Display sum of empsalary
                //var result = emplist.Sum(x => x.empsalary);
                //Console.WriteLine(result);


                //Question 8 : Display total employees
                //var result = emplist.Count();
                //Console.WriteLine(result);

                //Q9.) Projection Operator using select only few columns and storing into 
                //it's orignial state which is emplist columns
                //var result = (from c1 in emplist
                //              select new
                //              {
                //                  empid = c1.empid,
                //                  empname = c1.empname,
                //                  empaddress = c1.empaddress
                //              });
                //foreach (var r1 in result)
                //{
                //    Console.WriteLine("Result is {0},{1},{2}",
                //        r1.empid, r1.empname, r1.empaddress);
                //}

                // Q9.) Projection Operator using select only few columns and storing into
                //it's orignial state which is emplist columns

                //var result = (from c1 in emplist
                //select new
                //{
                //    empid = c1.empid,
                //    empname = c1.empname,
                //    empaddress = c1.empaddress
                //});
                //foreach (var r1 in result)
                //{
                //    Console.WriteLine("Result is {0},{1},{2}",
                //        r1.empid, r1.empname, r1.empaddress);
                //}

                //List<NewEmpCls> emp1 = (from e1 in emplist
                //                        select e1).ToList();
                //foreach (var r1 in emp1)
                //{
                //    Console.WriteLine("Result is {0},{1},{2}",
                //        r1.empid, r1.empname, r1.empaddress);
                //}


                //Q10.) Projection Operator using Select Many to falternn the results

                //var emp1 = (from e1 in emplist.SelectMany(x => x.empname)
                //            select e1).ToList();
                //foreach (var r1 in emp1)
                //{
                //    Console.WriteLine(r1);
                //}


                //Q11.) How to use .Where filter operator
                //Display all employee's who's salary is between 10000 and 30000
                //var result = emplist.Where(x => x.empsalary >= 10000 && x.empsalary <= 30000);
                //foreach (var emp in result)
                //{
                //    Console.WriteLine("Result is {0}", emp.empsalary);
                //}

                /*var result = from c1 in emplist
                             where c1.empsalary >= 10000 && c1.empsalary <= 30000
                             select c1;
                foreach(var c in result)
                    Console.WriteLine("Salaries are {0},{1},{2},{3}",
                        c.empid,c.empname,c.empaddress,c.empsalary);*/

                //Partitioning Operators
                //Q12.) Take(2) which will display highest 2 values
                //var result = from c1 in emplist.Take(3)
                //             select new { empname = c1.empname, empsalary = c1.empsalary };
                //foreach (var c in result)
                //{

                //    Console.WriteLine("Salaries are {0},{1}", c.empname, c.empsalary);
                //}


                //Q13.) To find the 2nd largest salary
                //var result = emplist.OrderBy(x => x.empsalary)
                //    .Select(x => x.empsalary).Distinct().Take(5).Skip(4).First();
                //Console.WriteLine(result);


                //Q14. To display employee's in ascending order
                //var result = from c1 in emplist
                //             orderby c1.empname descending
                //             select new { c1.empid, c1.empname, c1.empaddress };

                ////var result1=emplist.OrderBy(c=>c.empname).ToList();
                //foreach (var c in result)
                //{
                //    Console.WriteLine("Result {0},{1},{2}", c.empid, c.empname, c.empaddress);
                //}


                //Q15.) To sort and display all employee's based on empname descending
                //order followed by subsequent then by based on empaddress
                //var result = (from c1 in emplist.OrderBy(c => c.empname)
                //              .ThenBy(c => c.empaddress)
                //              select c1).ToList();
                //foreach (var r1 in result)
                //{
                //    Console.WriteLine("Result is {0},{1},{2}",
                //        r1.empid, r1.empname, r1.empaddress);
                //}
                //Q16.) To sort and group all employee's based on
                //empid
                //var result = from e4 in emplist.GroupBy(e3 => e3.empid)
                //             select e4.ToList();
                //2nd method //var result1 = from e5 in emplist
                //                  //First store the data into a group
                //              group e5 by e5.empid into egroup
                //              orderby egroup.Key descending
                //              select new
                //              {
                //                  Key = egroup.Key,
                //                  egrops = egroup.OrderBy(x => x.empid)
                //              };
                //foreach (var group in result)
                //{
                //    Console.WriteLine("New Group:");
                //    foreach (var emp in group)
                //    {
                //        Console.WriteLine($"ID: {emp.empid}, Name: {emp.empname}, Address: {emp.empaddress}");
                //    }
                //}

                //Q17.) Distinct To display all employee's without any duplicates
                //var result = (from c1 in emplist select c1.empsalary).Distinct();

                //Console.WriteLine("Result is {0}", result);
                ////Q18.) Except To display all employee's except the values specified
                //var result1 = emplist.Except(emplist).ToList();
                //foreach (var r1 in result1)
                //{
                //    Console.WriteLine("Result is {0},{1},{2}",
                //        r1.empid, r1.empname, r1.empaddress);
                //}


                //Q18.) First Element Operator
                //(exception if first element is not found or list is empty)
                //var result3 = emplist.First(x => x.empsalary >= 10000);
                //Console.WriteLine("First Value is {0}", result3);

                //var result4 = emplist.FirstOrDefault(x => x.empsalary >= 10000);
                //Console.WriteLine("First Value is {0}", result4);
                //foreach(var item in result3)
                //{
                //    Console.WriteLine("Result of first is {0},{1},{2}", 
                //        item.empid, item.empname, item.empsalary);
                //}

                //Q19.)
                var result3 = r2.Any(x => x.username == "user1" || x.username == "user2");
                if (result3 == false)
                {
                    Console.WriteLine("Invalid login");
                }
                else
                {
                    Console.WriteLine("Valid login");
                }


            }

        }
    }
}
