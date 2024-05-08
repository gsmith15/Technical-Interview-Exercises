using Technical_Interview_Exercises;

namespace Technical_Interview_Exercises_Tests
{
    [TestClass]
    public class DistinctSubstringsTest
    {
        [TestMethod]
        public void GetNumberOfDistinctSubstrings()
        {
            string substring = "abcd";

            int result = DisctinctSubstrings.DistinctSubstrings(substring);

            Assert.AreEqual(10, result);

        }
    }
}