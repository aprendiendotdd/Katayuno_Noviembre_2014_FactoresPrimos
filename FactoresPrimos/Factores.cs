using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoresPrimos
{
  public class Factores
  {
    public List<int> Game(int number)
    {
      if (number < 0)
        throw new ArgumentException("numeros negativos no permitidos");
      if (number == 0) 
        throw new ArgumentException("numero cero no permitido");
      var list = new List<int>();
      return list;
      
    }
  }
}
