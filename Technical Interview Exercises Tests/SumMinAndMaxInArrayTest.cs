using Technical_Interview_Exercises;

namespace Technical_Interview_Exercises_Tests
{
    [TestClass]
    public class SumOfMinAndMaxInArray
    {
        [TestMethod]
        public void GetSumOfMinAndMaxElementsInArray()
        {
            int[] arr = { 1, 2, 7, 5, 3, 4 };

            int result = SumMinAndMaxInArray.SumOfMinAndMax(arr);

            Assert.AreEqual(8, result);

        }
    }
}