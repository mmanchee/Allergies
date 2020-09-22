using Microsoft.VisualStudio.TestTools.UnitTesting;
using Allergies.Models;

namespace Allergies.Tests
{
  [TestClass]
  public class AllergicTest
  {
    Allergic allergic = new Allergic();

    [TestMethod]
    public void IsAllergic_to_eggs()
    {
      Assert.AreEqual("eggs" , allergic.IsAllergic(1));
    }
  }
}