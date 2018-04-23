using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseConcreta1 cc1 = new ClaseConcreta1();
            ClaseConcreta2 cc2 = new ClaseConcreta2();
            // Obtener el resultado de multiplicar 3 por 100 y restarle 10
            int num1 = cc1.obtener(3);
            Console.WriteLine("num1: " + num1);
            // Obtener el resultado de multiplicar 3 por 1000 y restarle 100
            int num2 = cc2.obtener(50);
            Console.WriteLine("num2: " + num2);

            Console.ReadKey();
        }
    }
}
