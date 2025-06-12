import java.util.*;

class Solution {
    public int[] solution(String s) {
        int[] answer = new int[s.length()];
        Arrays.fill(answer , -1);
        Map<Character, Integer> map = new HashMap<Character, Integer>();
        
        for(int i = 0; i < answer.length; i++){
            if(map.containsKey(s.charAt(i))){
            	answer[i] = i - map.get(s.charAt(i));
                map.remove(s.charAt(i));
                map.put(s.charAt(i), i);
            }else{
                map.put(s.charAt(i), i);
            }
        }
        
        
        return answer;
    }
}