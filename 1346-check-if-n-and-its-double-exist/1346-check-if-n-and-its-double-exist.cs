public class Solution {
    public bool CheckIfExist(int[] arr) 
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j] *2 || arr[j] == arr[i] * 2)
                    return true;
            }
        }
        return false;
    }
}