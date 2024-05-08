using Technical_Interview_Exercises;

namespace Technical_Interview_Exercises_Tests
{
    [TestClass]
    public class LargestSumSubarrayTest
    {
        [TestMethod]
        public void GetLargestSumSubarrayReturnsEighteen()
        {
            int[] ints = { -2, 9, 4, -1, 0, 1, 5, -3 };

            int result = LargestSumSubarray.maxSubArraySum(ints);

            Assert.AreEqual(18, result);

        }
    }
}