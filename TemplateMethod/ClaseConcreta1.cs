using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class ClaseConcreta1 : ClaseAbstracta
    {
    public ClaseConcreta1()
    {
    }
    // ------------------------------------
    
     public override int multiplicar(int num)
    {
        return num * 100;
    }

     public override int sumar(int num)
    {
        return num + 10;
    }
}
}
