public class Solution {
    public string MergeAlternately(string word1, string word2) {
        string output = "";
        int index = 0;
        while (index < word1.Length && index < word2.Length)
        {
            output += word1[index].ToString() + word2[index].ToString();
            index++;
        }
        if (index >= word1.Length)
            output += word2.Substring(index);
        else
            output += word1.Substring(index);
        
        return output;
    }
}