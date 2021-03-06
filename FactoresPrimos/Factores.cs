﻿using System;
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

      if (Enumerable.Range(1, number).Where(x => number % x == 0).Count() == 2) 
        list.Add(number);
      else {
        while (number > 1)
        {
          var divider = Enumerable.Range(2, number).Where(x => number % x == 0 || number == x).Select(x => x).First();
          list.Add(divider);
          number = number / divider;
        }
      }
      return list;
    }
  }
}
