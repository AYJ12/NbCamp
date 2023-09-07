using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        long tmp = 0;
        
        if(Math.Sqrt(n) % 1.0 == 0)
        {
            tmp = Convert.ToInt64(Math.Sqrt(n)) + 1;
            answer = tmp * tmp;
        }else{
            answer = -1;
        }
        
        return answer;
    }
}