public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        int min = n < m ? n : m;
        int max = n < m ? m : n;
        
        for(int i = min; i >= 1; i--){
            if(n % i == 0 && m % i == 0){
                answer[0] = i;
                break;
            }
        }
        
        for(int i = m * n; i >= max; i--){
            if(i % n == 0 && i % m == 0){
                answer[1] = i;
            }
        }
        
        return answer;
    }
}