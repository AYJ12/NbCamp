using System.Collections;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        ArrayList arr = new ArrayList();
        
        for(int i = n; i > 0; i--){
            if(n % i == 0)
                arr.Add(i);
        }
        
        foreach(int k in arr){
            answer += k;
        }
        
        return answer;
    }
}