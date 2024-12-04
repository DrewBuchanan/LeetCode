using System.Text.RegularExpressions;

public class Solution
{
    public bool CanMakeSubsequence(string str1, string str2)
    {
        int i = 0, j = 0;

        while (i < str1.Length && j < str2.Length)
        {
            if (str1[i] - 'a' == str2[j] - 'a' || ((str1[i] - 'a' + 1) % 26) == str2[j] - 'a')
                j++;
            if (j == str2.Length)
                return true;

            i++;
        }

        return false;
    }
}