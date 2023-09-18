

public class Solution {
    public bool solution(string s) {
        bool answer = false;
        long temp = 0;
        
        if(s.Length == 4 || s.Length == 6){
            if(long.TryParse(s,out temp)){
                answer = true;
            }    
        }
        
        
        return answer;
    }
}