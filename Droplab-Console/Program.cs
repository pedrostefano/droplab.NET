using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Droplab_DATA;

namespace Droplab_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new DroplabModel())
            {
                var a = context.TOS.ToList();




            }
        }
    }
}
