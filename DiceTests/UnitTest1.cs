using System;
using System.Collections.Generic;
using Xunit;
using Week13Assess;

namespace DiceTests
{
    public class UnitTest1
    {
        [Fact]
        public void AverageTest()
        {
            CIGame test1 = new CIGame();
            test1.Results = new List<int>() { 2, 7, 3, 11, 2, 2 };
            Assert.Equal(4.50, test1.GetAverage());

            CIGame test2 = new CIGame();
            test2.Results = new List<int>() { 18, 4, 6, 12, 19 };
            Assert.Equal(11.80, test2.GetAverage());

            CIGame test3 = new CIGame();
            test3.Results = new List<int>() { 5 };
            Assert.Equal(5, test3.GetAverage());
            
            CIGame test4 = new CIGame();
            Assert.Equal(0, test4.GetAverage());
        }

        [Fact]
        public void TotalTest()
        {
            CIGame test1 = new CIGame();
            test1.Results = new List<int>() { 2, 7, 3, 11, 2, 2 };
            Assert.Equal(27, test1.GetTotal());

            CIGame test2 = new CIGame();
            test2.Results = new List<int>() { 18, 4, 6, 12, 19 };
            Assert.Equal(59, test2.GetTotal());

            CIGame test3 = new CIGame();
            test3.Results = new List<int>() { 5 };
            Assert.Equal(5, test3.GetTotal());

            CIGame test4 = new CIGame();
            Assert.Equal(0, test4.GetTotal());
        }
    }
}
