using System.Collections.Generic;
using System.Linq;
using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        List<char> stringArr = new List<char>(s);
        stringArr.Sort();
        stringArr.Reverse();
        
        answer = string.Join("",stringArr);
        
        
        return answer;
    }
}