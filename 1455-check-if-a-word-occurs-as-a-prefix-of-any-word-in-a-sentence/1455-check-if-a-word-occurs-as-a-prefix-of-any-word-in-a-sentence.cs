public class Solution {
    public int IsPrefixOfWord(string sentence, string searchWord) {
        string[] split = sentence.Split(' ');
        int index = Array.FindIndex(split, word => word.IndexOf(searchWord) == 0);
        if (index < 0)
            return index;
        return index + 1;
    }
}