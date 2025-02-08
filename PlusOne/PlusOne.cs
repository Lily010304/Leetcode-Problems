public class Solution {
    public int[] PlusOne(int[] digits) {
        int c = 1;
        int n = digits.Length;
        int i = 0;
        List<int> list = new List<int>(digits);
        list.Reverse();
        while (c == 1)
        {
            if (i < n)
            {
                if (list[i] == 9)
                {
                    list[i] = 0;
                }
                else
                {
                    list[i]++;
                    c = 0;
                }
            }
            else
            {
                list.Add(1);
                c = 0;
            }
            i++;
        }
        list.Reverse();
        digits = list.ToArray();

        return digits;
    }
}