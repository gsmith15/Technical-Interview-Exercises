using Technical_Interview_Exercises;

namespace Technical_Interview_Exercises_Tests
{
    [TestClass]
    public class CountFrequencyTest
    {
        [TestMethod]
        public void CountFrequencyFromArrayReturns5()
        {
            int[] ints = { 1, 4, 2, 4, 3, 4, 5, 4, 6, 4, 7 };
            int numberToCount = 4;

            int result = CountFrequency.CountFrequencyInArray(ints, numberToCount);

            Assert.AreEqual(5, result);

        }
    }
}