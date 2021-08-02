using Async_EntytiFramework.DatacontextLayer;
using Async_EntytiFramework.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Async_EntytiFramework.RunMethol
{
   public class InsertData
    {
        static async void InsertStudent()
        {
            using (var context = new DataContext())
            {
                try
                {
                    

                    await context.students.AddAsync(new Student()
                    {
                        Name = "hoai nam 1",
                        Age = 12,
                    });
                    Console.WriteLine("lam gi khi InsertStudent ket thuc");

                    await context.students.AddAsync(new Student()
                    {
                        Name = "hoai nam 1",
                        Age = 12,
                    });

                    Thread.Sleep(1000);
                    await context.students.AddAsync(new Student()
                    {
                        Name = "hoai nam 1",
                        Age = 12,
                    });
                    Console.WriteLine("lam gi khi InsertStudent ket thuc");

                    await context.SaveChangesAsync();

                    Console.WriteLine("lam gi khi InsertStudent ket thuc");

                }
                catch (Exception e)
                {

                    Console.WriteLine("loi " + e);

                }
                finally
                {
                    Console.WriteLine("Luu thanh cong");
                }
            }
        }

        static async void InsertGrader()
        {
            using (var context = new DataContext())
            {

                try
                {

                    var arrayObject = new object[] { new Grader() { Name = "Tuan" },
                                                     new Grader() { Name = "viet" },
                                                     new Grader() { Name = "Hoang" }};

                    await context.AddRangeAsync(arrayObject);
                    await context.SaveChangesAsync();
                    Console.WriteLine("lam gi khi InsertGrader ket thuc");
                }
                catch (Exception e)
                {

                    Console.WriteLine("loi " + e);
                }
                finally
                {
                    Console.WriteLine("luu thanh cong");
                }
            }
        }

        public static void run()
        {
            InsertStudent();
            InsertGrader();
        }
    }

    
}
