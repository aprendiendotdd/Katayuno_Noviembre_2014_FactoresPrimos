using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace FactoresPrimosTests
{
  [TestFixture]
  public class FactoresTests
  {
    [Test]
    public void ReturnExceptionWhenNegativeNumber() {
      var exception = Assert.Throws<ArgumentException>(() => FactoresPrimos.Factores.Game(-1));
      Assert.That(exception, Has.Message.EqualTo("numeros negativos no permitidos"));
    }
  }
}
