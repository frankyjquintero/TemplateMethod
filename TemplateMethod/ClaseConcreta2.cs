using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class ClaseConcreta2 : ClaseAbstracta
    {
    public ClaseConcreta2()
    {
    }
    // ------------------------------------
    
     public override int multiplicar(int num)
    {
        return num * 1000;
    }
    // ------------------------------------
    
     public override int sumar(int num)
    {
        return num + 100;
    }
}
}
