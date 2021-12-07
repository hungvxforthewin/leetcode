// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using static System.Console;
using SolutionNameSpace;

//WriteLine($"Hello, world");

int[] nums = new int[] {2,7,11,15};
int target = 9;

int[] result = Solution1.TwoSum(nums, target);
for (int i = 0; i < result.Length; i++)
{
    WriteLine(result[i]);
}

public static class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> lookup = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if(lookup.ContainsKey(target - nums[i]))
            {
                return new int[] { lookup[target - nums[i]], i};
            }
            lookup[nums[i]] = i;
        }
        return new int[] {};
    }
}