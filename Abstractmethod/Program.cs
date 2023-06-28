using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Abstractmethod.AbstractClass;

namespace Abstractmethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Rectanglel area = new Rectanglel(10, 20);
            area.CalculateArea();
            Console.WriteLine(area);
        }
    }
}
