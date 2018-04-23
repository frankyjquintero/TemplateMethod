using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class ClaseAbstracta
    {
        public int obtener(int num)
        {
            this.mensaje();
            int numero = this.multiplicar(num);
            numero = this.sumar(numero);
            return numero;
        }
        // -------------------
        public void mensaje()
        {
            Console.WriteLine("Vamos a realizar las operaciones...");
        }
        // -------------------
        // Métodos que deberán implementar las subclases
        public abstract int multiplicar(int num);
        public abstract int sumar(int num);
    }

}
