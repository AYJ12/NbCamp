using System;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        int width = 0 , height = 0;
        
        
        for(int i = 0; i < sizes.GetLength(0); i++){
            int tmp;
            if(sizes[i,0] < sizes[i,1]){
                tmp = sizes[i,0];
                sizes[i,0] = sizes[i,1];
                sizes[i,1] = tmp;
            }
            
            width = width < sizes[i,0] ? sizes[i,0] : width;
            height = height < sizes[i,1] ? sizes[i,1] : height;
        }
        
        answer = width * height;
        return answer;
    }
}