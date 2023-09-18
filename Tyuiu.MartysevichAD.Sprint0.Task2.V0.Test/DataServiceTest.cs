using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MartysevichAD.Sprint0.Task2.V0.Lib;
namespace Tyuiu.MartysevichAD.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckgetMessageValid()
        {
            var name = "Андрей";
            var res = DataService.GetMessage(name);


            Assert.AreEqual("Привет, Андрей", res);
        }
    }
}
