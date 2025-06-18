import java.util.*;

class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = {};
        
        List<Integer> listArray = new ArrayList<Integer>();
        
        for(int i = 0; i < numbers.length - 1; i++) {
        	for(int j = i+1; j < numbers.length; j++) {
        		int res = numbers[i] + numbers[j];
        		if(!listArray.contains(res))
        			listArray.add(res);
        	}
        }
        Collections.sort(listArray);
        answer = listArray.stream().mapToInt(Integer::intValue).toArray();
        return answer;
    }
}