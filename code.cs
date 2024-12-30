public class Solution
{
    public int[] FindMissingAndRepeatedValues(int[][] grid)
    {
        int n = grid.Length;
        int[] count = new int[n * n + 1];
        // creating an array count to store the number of occurences of each element

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < grid[0].Length; j++)
            {
                count[grid[i][j]]++;
                // storing the number of occurences of each element
            }
        }

        int a = -1, b = -1;
        for(int num = 1; num < count.Length; num++)
        {
            if(count[num] == 2)
            {
                // if any element occured twice make it a
                a = num;
            }
            if(count[num] == 0)
            {
                // if any element didn't appear even once make it b
                b = num;
            }
        }

        return new int[] {a, b};
    }
}
