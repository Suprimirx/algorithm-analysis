public class Solution {
    public void SortColors(int[] nums) {
        int i = 0;
        int m = 0;
        int j = nums.Length - 1;

        while (m <= j)
        {
            if (nums[m] == 0)
            {
                (nums[m], nums[i]) = (nums[i], nums[m]);
                i++;
                m++;
            }
            else if (nums[m] == 1)
            {
                m++;
            }
            else
            {
                (nums[m], nums[j]) = (nums[j], nums[m]);
                j--;
            }
        }
    }
}
