using System;
using Xunit;
using System_IO;

namespace System_IO_Test
{
    public class UnitTest1
    {
        [Fact]
        public void prodactOfThreeTest()
        {
            Assert.Equal(10, Program.productOfThree("1 2 5"));
        }
        [Fact]
        public void prodactLessThanThreeTest()
        {
            Assert.Equal(0, Program.productOfThree("1 2"));
        }
        [Fact]
        public void prodactMoreThanTreeTest()
        {
            Assert.Equal(12, Program.productOfThree("1 2 6 5 6"));
        }
        [Fact]
        public void prodactNegativeNumberTest()
        {
            Assert.Equal(-6, Program.productOfThree("1 2 -3"));
        }
        [Fact]
        public void prodactNunNumberTest()
        {
            Assert.Equal(8, Program.productOfThree("2 ahmad 4"));
        }
        [Fact]
        public void avgTest()
        {
            int[] arr={4,5,6};
            Assert.Equal(5, Program.Avg(arr));
        }
        [Fact]
        public void avgOfZerosTest()
        {
            int[] arr = { 0, 0, 0 };
            Assert.Equal(0, Program.Avg(arr));
        }

        [Fact]
        public void maxFrequentTest()
        {
            int[] arr = { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };
            Assert.Equal(1, Program.mostFrequentElement(arr));
        }
        [Fact]
        public void maxFrequentOfSameInputTest()
        {
            int[] arr = { 5,5,5,5,5,5,5,5,5,5 };
            Assert.Equal(5, Program.mostFrequentElement(arr));
        }

        [Fact]
        public void maxFrequentNoDuplicatesTest()
        {
            int[] arr = { 6,5,4,7,8,9 };
            Assert.Equal(6, Program.mostFrequentElement(arr));
        }
        [Fact]
        public void maxFrequentSameAmountTest()
        {
            int[] arr = {1,2,2,2,3,5,6,6,6 };
            Assert.Equal(2, Program.mostFrequentElement(arr));
        }
        [Fact]
        public void maxForNegative()
        {
            int[] arr = { -6,-8,-1,-8,-9};
            Assert.Equal(-1, Program.maxNumber(arr));
        }
        [Fact]
        public void maxForSameInput()
        {
            int[] arr = { 5,5,5,5,5,5,5 };
            Assert.Equal(5, Program.maxNumber(arr));
        }
        [Fact]
        public void characterCounterTest()
        {
            string[] arr = { "this: 4", "is: 2", "a: 1", "sentance: 8", "about: 5", "important: 9", "things: 6" };
            Assert.Equal(arr, Program.characterCounter("this is a sentance about important things"));
        }

        [Fact]
        public void characterCounterWithDifferentSymbolsTest()
        {
            string[] arr = { "hello: 5", "#$!@: 4", "my: 2", "name: 4", "is: 2", "A7ma0d: 6" };
            Assert.Equal(arr, Program.characterCounter("hello #$!@ my name is A7ma0d"));
        }
    }
}


