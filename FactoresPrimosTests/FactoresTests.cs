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
      var exception = Assert.Throws<ArgumentException>(() => new FactoresPrimos.Factores().Game(-1));
      Assert.That(exception, Has.Message.EqualTo("numeros negativos no permitidos"));
    }

    [Test]
    public void ReturnExceptionWhenZeroNumber() {
      var exception = Assert.Throws<ArgumentException>(() => new FactoresPrimos.Factores().Game(0));
      Assert.That(exception, Has.Message.EqualTo("numero cero no permitido"));
    }

    [Test]
    public void ReturnEmptyListWhenNumberOne() {
      Assert.AreEqual(new List<int>() { }, new FactoresPrimos.Factores().Game(1));
    }

    [Test]
    public void ReturnListWithInputNumberWhenPrimeNumber() {
      Assert.AreEqual(new List<int>() { 2 }, new FactoresPrimos.Factores().Game(2));
      Assert.AreEqual(new List<int>() { 3 }, new FactoresPrimos.Factores().Game(3));
      Assert.AreEqual(new List<int>() { 5 }, new FactoresPrimos.Factores().Game(5));
      Assert.AreEqual(new List<int>() { 7 }, new FactoresPrimos.Factores().Game(7));
    }

    [Test]
    public void ReturnListWith_2_2_WhenNumberIsFour() {
      Assert.AreEqual(new List<int>() { 2, 2 }, new FactoresPrimos.Factores().Game(4));
    }
    
  }
}
