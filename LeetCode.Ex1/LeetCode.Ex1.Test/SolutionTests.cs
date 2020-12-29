using Xunit;
using Should;

namespace LeetCode.Ex1.Test
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void ShouldReturnCorrectResultWhenSolutionExists(int[] nums, int target, int[] expectedResult)
        {
            var actualResult = Solution.TwoSum(nums, target);

            actualResult.ShouldEqual(expectedResult);
        }

        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 1)]
        [InlineData(new int[] { 2, 7, 11, 15 }, 100)]
        [InlineData(new int[] { 3, 2, 4 }, 4)]
        [InlineData(new int[] { 3, 2, 4 }, 8)]
        public void ShouldReturnEmptyArrayWhenNoSolutionExists(int[] nums, int target)
        {
            var expectedResult = new int[] { };
            var actualResult = Solution.TwoSum(nums, target);

            actualResult.ShouldEqual(expectedResult);
        }
    }
}
