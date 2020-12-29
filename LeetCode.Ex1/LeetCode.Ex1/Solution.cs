namespace LeetCode.Ex1
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length - 1; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    var sum = nums[i] + nums[j];
                    if (sum == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[] { };
        }
    }
}
