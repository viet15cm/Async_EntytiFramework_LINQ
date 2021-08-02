using Async_EntytiFramework.DatacontextLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Async_EntytiFramework.RunMethol
{
    class ReadData
    {
        public static async void ReadGrader()
        {
            using (var context = new DataContext())
            {
                var list = await context.graders.ToListAsync();

                foreach (var item in list)
                {
                    Thread.Sleep(100);
                    var s = String.Format("Id:{0} Name: {1} Age: {2} :",
                                         item.Id, item.Name, item.Amount);
                    Console.WriteLine(s);
                }
            }

        }

        public static async void ReadStrudent()
        {
            using (var context = new DataContext())
            {
                var list = await context.students.ToListAsync();

                foreach (var item in list)
                {
                    Thread.Sleep(100);
                    var s = String.Format("Id:{0} GraderId: {1} :",
                                         item.Id, item.GraderId);
                    Console.WriteLine(s);
                }
            }

        }

        public static void run()
        {
            ReadGrader();
            ReadStrudent();
        }
    }
}
