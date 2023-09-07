using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer;
        List<int> list = new List<int>();        
        int tmp = 0;
        
        if(arr.Length == 1)
            answer = new int[] {-1};
        else{
            tmp = arr.Min();
            for(int i = 0; i < arr.Length; i++){
                if(!(tmp == arr[i])){
                    list.Add(arr[i]);
                }
            }
            answer = list.ToArray();
        }
        
        return answer;
    }
}