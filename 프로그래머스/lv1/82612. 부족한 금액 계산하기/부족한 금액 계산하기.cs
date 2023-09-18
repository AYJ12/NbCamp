using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long result;
        long sum = 0;
        
        for(int i = 1; i <= count; i++){
            sum += price * i;
        }
        
        if(money > sum)
            return 0;
        else{
            result = -1 * (money - sum);
            return result;
        }
        
    }
}