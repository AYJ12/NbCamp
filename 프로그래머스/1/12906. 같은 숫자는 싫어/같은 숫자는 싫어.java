import java.util.*;

public class Solution {
    public int[] solution(int []arr) {
        int[] answer = {};
        Stack<Integer> stackArray = new Stack<>(); 
        stackArray.push(arr[0]);
        
        for(int tmp : arr){
            if(tmp == stackArray.peek())
                continue;
            else
                stackArray.push(tmp);
        }
        
        answer = new int[stackArray.size()];
        
        for(int i=0; i < stackArray.size(); i++){
            answer[i] = stackArray.get(i);
        }

        return answer;
    }
}