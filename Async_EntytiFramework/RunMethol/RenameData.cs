using Async_EntytiFramework.DatacontextLayer;
using Async_EntytiFramework.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Async_EntytiFramework.RunMethol
{
    public class RenameData
    {
        static async void RenameGrader(Grader grader)
        {
            try
            {
                using (var context = new DataContext())
                {
                    var existingGrader = await (from p in context.graders where (p.Id == grader.Id) select p).FirstOrDefaultAsync();

                    if (existingGrader != null)
                    {
                        existingGrader.Name = grader.Name;
                        existingGrader.Amount = grader.Amount;

                        await context.SaveChangesAsync();
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("loi khong thanh cong " + e);
            }
            finally
            {
                Console.WriteLine("Sua Thanh Cong");
            }
            
        }

        public static void Run()
        {
            RenameGrader(new Grader() { 
                                         Id= new Guid("3e6d2ce5-b5ba-42b4-a4fe-146df7efc4cc"),
                                           Name = "Sua thanh cong",
                                           Amount = "Pro Viet"
                                         
            
                                        });
        }
    }
}
