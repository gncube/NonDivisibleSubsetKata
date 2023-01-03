namespace NonDivisibleSubset.UnitTests
{
    public class NonDivisibleSubsetShould
    {
        [Fact]
        public void ReturnTheLengthOfTheLongestSubset1()
        {
            List<int> S = new List<int> { 19, 10, 12, 10, 24, 25, 22 };
            int k = 4;

            var processor = new NonDivisibleSubsetProcessor();

            int result = processor.LongestSubset(k, S);

            int expected = 3;

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3, 4, new int[] { 19, 10, 12, 10, 24, 25, 22 })]
        [InlineData(3, 3, new int[] { 1, 7, 2, 4 })]
        public void ReturnTheLengthOfTheLongestSubset(int expected, int k, int[] S)
        {
            var processor = new NonDivisibleSubsetProcessor();

            int result = processor.LongestSubset(k, S.ToList());

            Assert.Equal(expected, result);
        }
    }
}