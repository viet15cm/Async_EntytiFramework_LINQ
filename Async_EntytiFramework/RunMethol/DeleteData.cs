using Async_EntytiFramework.DatacontextLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Async_EntytiFramework.RunMethol
{
   public class DeleteData
    {
        static async Task DeleteGrader(Guid Id)
        {
            using (var context = new DataContext())
            {
                try
                {
                    var find = await (from a in context.graders
                                      where (a.Id == Id)
                                      select a).FirstOrDefaultAsync();
                    if(find != null)
                    {
                        context.Remove(find);

                        await context.SaveChangesAsync();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Xao khong thanh cong" + e);
                }
                finally
                {
                    Console.WriteLine("Xoa thanh cong");
                }
                
            }
        }

        public static void run()
        {
            var c = DeleteGrader(new Guid("3e6d2ce5-b5ba-42b4-a4fe-146df7efc4cc"));
        }
    }
}
