namespace NonDivisibleSubset.UnitTests
{
    internal class NonDivisibleSubsetProcessor
    {
        public NonDivisibleSubsetProcessor()
        {
        }

        internal int LongestSubset(int k, List<int> s)
        {
            int[] remainders = new int[k];

            foreach (int number in s)
            {
                remainders[number % k]++;
            }

            int count = Math.Min(remainders[0], 1);

            for (int i = 1; i <= k / 2 && i != k - i; i++)
            {
                count += Math.Max(remainders[i], remainders[k - i]);
            }

            if (k % 2 == 0)
            {
                count++;
            }

            return count;
        }
    }
}