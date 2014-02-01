using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            var kt = new KnightTour(5);
            int[,] resultBoard = kt.Start(4, 3);

            Console.Read();
        }
    }
}
