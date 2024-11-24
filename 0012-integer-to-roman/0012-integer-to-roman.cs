using System.Collections.Generic;

public class Solution {
    public string IntToRoman(int num) {
         Dictionary<int, string> roman = new Dictionary<int, string>
         {
             {1000, "M"},
             {900, "CM"},
             {500, "D"},
             {400, "CD"},
             {100, "C"},
             {90, "XC"},
             {50, "L"},
             {40, "XL"},
             {10, "X"},
             {9, "IX"},
             {5, "V"},
             {4, "IV"},
             {1, "I"}
        };
        string output = "";
        foreach (KeyValuePair<int, string> romanStep in roman)
        {
            while (num >= romanStep.Key)
            {
                num -= romanStep.Key;
                output += romanStep.Value;
            }
        }
        
        return output;
    }
}