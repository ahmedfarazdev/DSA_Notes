/// Binary Search Approach
// Runtime: 154 ms --- Beats: 64.62%
// Memory Used: 46.5 MB --- Beats: 7%
public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        int start, end, middle = 0;
        for(int i=0; i<numbers.Length; i++)
        {
            start = i+1;
            end = numbers.Length-1;
            var sum = target - numbers[i];
            while(start <= end)
            {
                middle = start + (end - start)/2;
                if(numbers[middle] == sum)
                {
                    return new []{i+1, middle+1};
                }
                if(numbers[middle]>sum)
                {
                    end = middle-1;
                }
                else
                {
                    start = middle +1;
                }
            }
        }
        return new[] {0, 0};

    }
}

/// Binary Search Approach
// Runtime: 149 ms --- Beats: 82.39%
// Memory Used: 46.6 MB --- Beats: 7%
public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int min = 0, max = numbers.Length - 1, temp = 0;
        while((numbers[min] + numbers[max]) != target)
            if((numbers[min] + numbers[max]) > target) max--;
            else min++;            
        return new int[]{min +1, max+1};
    }
}