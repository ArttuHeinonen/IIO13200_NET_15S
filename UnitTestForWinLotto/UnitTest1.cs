using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestForWinLotto
{
    [TestClass]
    public class UnitTestLotto
    {
        [TestMethod]
        public void TestGetWeek()
        {
            //Viittaus oikeaan luokkaan ja sen metodiin
            JAMK.IT.WinLotto.Lotto lotto = new JAMK.IT.WinLotto.Lotto();
            //Kutsutaan testattavaa metodia
            string week = lotto.GetWeekUnfinished();
            Assert.AreEqual("41/2015", week);
        }
    }
}
