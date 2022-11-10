namespace Test
{
    public class FindTopValues
    {
        public int FindTopNValues(int[] anyOldValues)
        {
            return anyOldValues.OrderByDescending(x => x).First();
        }

        public int[] FindTopNValues(int[] anyOldValues, int n)
        {
            return anyOldValues.OrderByDescending(x => x).Take(n).ToArray();
        }
    }
}
