using Microsoft.VisualStudio.TestTools.UnitTesting;
using Allergies.Models;

namespace Allergies.Tests
{
  [TestClass]
  public class AllergicTest
  {
    [TestMethod]
    public void Is_allergic_to_eggs()
    {
      
      Allergic allergic = new Allergic();
      Assert.AreEqual("eggs" , allergic.IsAllergic(1));
    }
  }
}