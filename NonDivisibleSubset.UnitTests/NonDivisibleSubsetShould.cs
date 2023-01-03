namespace NonDivisibleSubset.UnitTests
{
    public class NonDivisibleSubsetShould
    {
        [Fact]
        public void ReturnTheLengthOfTheLongestSubset()
        {
            List<int> S = new List<int> { 19, 10, 12, 10, 24, 25, 22 };
            int k = 4;

            var processor = new NonDivisibleSubsetProcessor();

            int result = processor.LongestSubset(k, S);

            int expected = 3;

            Assert.Equal(expected, result);
        }
    }
}