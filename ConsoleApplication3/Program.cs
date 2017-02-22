using HRM.DAL.DbContext;
using HRM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            HRMContext db = new HRMContext();
            var arr = db.Users.ToList();
            foreach (var i in arr)
            {
                Console.WriteLine("{0}", i.FullName);
            }
            Console.ReadKey();
        }
    }
}
