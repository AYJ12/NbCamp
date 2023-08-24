using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int a,b;
        a = n / 10;
        b = n % 10;
        answer = answer + b;
        
        while(a != 0 || b != 0){
            b = a % 10;
            answer = answer + b;
            a = a / 10;
        }
        
        return answer;
    }
}