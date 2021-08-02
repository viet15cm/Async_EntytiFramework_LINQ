using Async_EntytiFramework.DatacontextLayer;
using Async_EntytiFramework.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using Async_EntytiFramework.RunMethol;

namespace Async_EntytiFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            DeleteData.run();
            Console.ReadKey();
        }
    }
}
