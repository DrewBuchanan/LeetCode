public class Solution {
    public string AddSpaces(string s, int[] spaces)
    {
        StringBuilder sb = new StringBuilder(s.Length + spaces.Length);
        int startIndex = 0;
        for (int i = 0; i < spaces.Length; i++)
        {
            sb.Append(s, startIndex, spaces[i] - startIndex);
            sb.Append(" ");
            startIndex = spaces[i];
        }
        
        sb.Append(s, startIndex, s.Length - startIndex);
        
        return sb.ToString();
    }
}