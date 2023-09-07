using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        int[] arr = new int[]{0,1,2,3,4,5,6,7,8,9};
        
        for(int j = 0; j < arr.Length; j++){
            answer += arr[j];
        }
        
        for(int i = 0; i < numbers.Length; i++){
            answer -= numbers[i];
        }
        
        return answer;
    }
}