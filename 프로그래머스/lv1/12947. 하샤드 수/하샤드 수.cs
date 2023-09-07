using System.Collections.Generic;

public class Solution {
    public bool solution(int x) {
        bool answer = true;
        int tmp = x;
        int res = 0;
        
        while(tmp % 10 != 0 || tmp / 10 != 0){
            res += (tmp % 10);
            tmp /= 10;
        }
            
        if(x % res == 0)
            answer = true;
        else
            answer = false;
        
        return answer;
    }
}