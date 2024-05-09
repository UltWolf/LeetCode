namespace LeetCode.Test.Daily.Day592024
{
    public class ChildHappinessTest
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(
                    new int[] { 1, 2, 3 },
                    2,
                    4
                    );
            }
        }
        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void TestRanked(int[] array, int k, int actualResult)
        {
            Assert.AreEqual(new ChildHappiness().(array), expectedArray);
        }
    }
}
