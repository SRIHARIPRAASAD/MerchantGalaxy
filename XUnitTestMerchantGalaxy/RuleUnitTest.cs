using System;
using MerchantApp.Roman.Rules;
using Xunit;

namespace XUnitTestMerchantGalaxy
{
    public class RuleUnitTest
    {
        [Fact]
        public void TestCantBeRepeatedRule()
        {
            CantBeRepeated rule = new CantBeRepeated();
            Assert.False(rule.Execute("MMDD"));
            Assert.False(rule.Execute("XVIV"));
            Assert.True(rule.Execute("XXIV"));
        }

        [Fact]
        public void TestCantBeRepeated4TimesRule()
        {
            CantBeRepeated4Times rule = new CantBeRepeated4Times();
            Assert.False(rule.Execute("XXXX"));
            Assert.True(rule.Execute("IXIXIXIX"));
            Assert.True(rule.Execute("XXXIX"));
        }

        [Fact]
        public void TestSingleSubtractionRule()
        {
            SingleSubtraction rule = new SingleSubtraction();
            Assert.False(rule.Execute("IIX"));
            Assert.False(rule.Execute("CCM"));
            Assert.True(rule.Execute("XXIV"));
        }

        [Fact]
        public void TestSubtractionRule()
        {
            Subtraction rule = new Subtraction();
            Assert.False(rule.Execute("CIL"));
            Assert.False(rule.Execute("MXD"));
            Assert.True(rule.Execute("XIX"));
        }

    }
}
