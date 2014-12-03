using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoresPrimos
{
  public class Factores
  {
    public static object Game(int number)
    {
      if (number < 0)
        throw new ArgumentException("numeros negativos no permitidos");
      throw new ArgumentException("numero cero no permitido");
      
    }
  }
}
