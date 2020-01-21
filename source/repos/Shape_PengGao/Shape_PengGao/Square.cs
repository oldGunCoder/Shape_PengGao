using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_PengGao
{
    class Square
    {
        decimal length;

        public string Display()
        {
            Console.WriteLine("This is a square");
        }

        public decimal CalculateArea()
        {
            decimal area = length * length;
        }
    }
}
