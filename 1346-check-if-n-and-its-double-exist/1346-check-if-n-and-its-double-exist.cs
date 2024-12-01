public class Solution {
    public bool CheckIfExist(int[] arr) 
    {
        /*
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j] *2 || arr[j] == arr[i] * 2)
                    return true;
            }
        }
        return false;
        */
        
        Array.Sort(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            int index = CustomBinarySearch(arr, arr[i] * 2);
            if (index >= 0 && index != i)
                return true;
        }
        
        return false;
    }
    
    public int CustomBinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        int mid = 0;
        while (left <= right)
        {
            mid = left + (right - left) / 2;
            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        
        return -1;
    }
}