public class Solution
{
    public int[] FindMissingAndRepeatedValues(int[][] grid)
    {
        int n = grid.Length;
        int[] count = new int[n * n + 1];

        foreach (int[] row in grid)
        {
            foreach (int num in row)
            {
                count[num]++;
            }
        }

        int repeated = 0;
        int missing = 0;

        for (int i = 1; i <= n * n; i++)
        {
            if (count[i] == 2)
                repeated = i;
            else if (count[i] == 0)
                missing = i;
        }

        return new int[] { repeated, missing };
    }
}