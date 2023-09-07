public class Solution {
    public int solution(int num) {
        int answer = 0;
        long tmp = num;
        
        while(answer < 500){
            if(tmp % 2 == 0){
                tmp /= 2;
            }else{
                tmp = tmp * 3 + 1;
            }
            answer++;
            
            if(tmp == 1)
                break;
        }
        
        if(answer >= 500)
            answer = -1;
        else if(num == 1)
            answer = 0;
        
        return answer;
    }
}