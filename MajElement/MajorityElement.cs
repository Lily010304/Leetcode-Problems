public class Solution {
    public int MajorityElement(int[] nums) {
        int n = nums.Count();
        Dictionary<int, int> mode = new();
        foreach (var num in nums)
        {
            mode[num] = 0;
        }

        for (int i = 0; i < n; i++)
        {
            mode[nums[i]]++;
        }
        int max = 0;
        KeyValuePair<int, int> maxx = new KeyValuePair<int, int>(0, 0);;
        foreach (var m in mode)
        {
           if (m.Value > max)
           {
            max = m.Value;
            maxx = m;
           }
        }

        return maxx.Key;
    }
}