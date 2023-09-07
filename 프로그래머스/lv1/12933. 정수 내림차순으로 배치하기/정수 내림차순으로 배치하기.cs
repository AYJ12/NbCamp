using System;
using System.Collections.Generic;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        long tmp = n;
        string str = "";
        List<long> listArr = new List<long>();
        
        for(int i = 0; ; i++){
            if(tmp % 10 == 0 && tmp / 10 == 0)
                break;
            listArr.Add(tmp % 10);
            tmp /= 10;

        }
        
        listArr.Sort(new Comparison<long>((n1, n2) => n2.CompareTo(n1)));
        
        foreach(long i in listArr){
            str += i.ToString();
        }
        
        answer = Convert.ToInt64(str);
        
        return answer;
    }
}