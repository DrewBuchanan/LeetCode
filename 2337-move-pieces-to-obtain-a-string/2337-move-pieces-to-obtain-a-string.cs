public class Solution {
    public bool CanChange(string start, string target) {
        if (start.Replace("_", "") != target.Replace("_", ""))
            return false;
        
        int startindex = 0, targetindex = 0;
        while (startindex < start.Length || targetindex < target.Length)
        {
            while (startindex < start.Length && start[startindex] == '_') startindex++;
            while (targetindex < target.Length && target[targetindex] == '_') targetindex++;

            if (startindex >= start.Length || targetindex >= target.Length) continue;
            if (start[startindex] != target[targetindex]) return false;
            if (start[startindex] == 'L' && startindex < targetindex) return false;
            if (start[startindex] == 'R' && startindex > targetindex) return false;

            startindex++;
            targetindex++;
        }

        return true;
    }
}