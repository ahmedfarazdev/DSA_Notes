public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        int arrayLength = nums.Length;
        Dictionary<int, int> hashMap = new Dictionary<int, int>();

        if (nums == null || arrayLength < 2) {
        return Array.Empty < int > ();
    }

        for (int i =0; i<arrayLength; i++)
        {
            var complement = target - nums[i];

            int index = 0;
            if(hashMap.TryGetValue(complement, out index))
            {
                return new [] {index, i};
            }

            if(!hashMap.ContainsKey(complement)){
                //hashMap.Add(nums[i], i);
                hashMap[nums[i]] = i;
            }
            
        }
        throw new Exception("Not Found.");
    }
}