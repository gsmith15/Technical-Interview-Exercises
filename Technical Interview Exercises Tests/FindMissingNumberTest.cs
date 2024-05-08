using Technical_Interview_Exercises;

namespace Technical_Interview_Exercises_Tests
{
    [TestClass]
    public class FindMissingNumberTest
    {
        [TestMethod]
        public void GetMissingNumbderFromArrayReturnsSix()
        {
            int[] ints = { 1, 2, 7, 5, 3, 4 };
            int n = ints.Length;

            int result = FindMissingNumber.MissingNumber(ints, n);

            Assert.AreEqual(6, result);

        }
    }
}