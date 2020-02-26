/*
 * Created by SharpDevelop.
 * User: MrFalko
 * Date: 26.02.2020
 * Time: 20:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;

namespace Tasks.Custom_rounding_rule
{
  [TestFixture]
  public class RoundTest
  {

        [Test]
        public void Precision_0_RoundUp_4()
        {
            Assert.AreEqual(0, CustomMath.Round(0.0m, 0, 4));
            Assert.AreEqual(1, CustomMath.Round(0.9m, 0, 4));
            Assert.AreEqual(1, CustomMath.Round(1.0m, 0, 4));
            Assert.AreEqual(1, CustomMath.Round(1.1m, 0, 4));
            Assert.AreEqual(1, CustomMath.Round(1.2m, 0, 4));
            Assert.AreEqual(1, CustomMath.Round(1.3m, 0, 4));
            Assert.AreEqual(2, CustomMath.Round(1.4m, 0, 4));
            Assert.AreEqual(2, CustomMath.Round(1.5m, 0, 4));
            Assert.AreEqual(2, CustomMath.Round(1.6m, 0, 4));
            Assert.AreEqual(2, CustomMath.Round(1.7m, 0, 4));
            Assert.AreEqual(2, CustomMath.Round(1.8m, 0, 4));
            Assert.AreEqual(2, CustomMath.Round(1.9m, 0, 4));
            Assert.AreEqual(2, CustomMath.Round(2.0m, 0, 4));
            Assert.AreEqual(2, CustomMath.Round(2.1m, 0, 4));
        }


        [Test]
        public void Precision_2_RoundUp_4()
        {
            Assert.AreEqual(0.00m, CustomMath.Round(0.0m, 2, 4));
            Assert.AreEqual(0.90m, CustomMath.Round(0.900m, 2, 4));
            Assert.AreEqual(0.91m, CustomMath.Round(0.904m, 2, 4));
            Assert.AreEqual(0.91m, CustomMath.Round(0.905m, 2, 4));
            Assert.AreEqual(0.91m, CustomMath.Round(0.909m, 2, 4));
            Assert.AreEqual(1.00m, CustomMath.Round(1.000m, 2, 4));
            Assert.AreEqual(1.00m, CustomMath.Round(1.0019m, 2, 4));
            Assert.AreEqual(1.01m, CustomMath.Round(1.0049m, 2, 4));
            Assert.AreEqual(1.01m, CustomMath.Round(1.0059m, 2, 4));
            Assert.AreEqual(1.01m, CustomMath.Round(1.0099m, 2, 4));
        }

  }

}
