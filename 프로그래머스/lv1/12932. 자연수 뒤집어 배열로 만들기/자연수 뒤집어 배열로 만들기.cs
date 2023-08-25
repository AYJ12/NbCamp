using System.Collections.Generic;

public class Solution {
    public int[] solution(long n) {
        List<int> arr = new List<int>();
        
        while(n % 10 != 0 || n / 10 != 0){
            arr.Add((int)(n % (long)10));
            n /= 10;
        }
        
        int[] answer = arr.ToArray();
        
        
        return answer;
    }
}