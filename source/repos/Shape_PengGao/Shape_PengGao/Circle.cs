using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_PengGao
{
    class Circle
    {
        decimal radius;
        decimal pi = (decimal)Math.PI;
        
        public string Display()
        {
            Console.WriteLine("This is a circle");
        }

        public decimal CalculateArea()
        {
            decimal area = radius * radius * pi; 
        }
    }
}
