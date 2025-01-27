public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        int sums = 0;
        int[] res = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            sums = nums[i];
            res[0] = i;
            for (int j = i + 1; j < nums.Length; j++)
            {
                sums += nums[j];
                res[1] = j;
                if (sums == target)
                    return res;

                else
                    sums -= nums[j];
            }
        }
        return res;

    }
}