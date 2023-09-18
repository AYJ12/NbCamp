using System.Collections.Generic;
using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        List<char> stringArr = new List<char>(s);
        stringArr.Sort(new Comparison<char>((n1, n2) => n2.CompareTo(n1)));
        
        answer = string.Join("",stringArr);
        
        
        return answer;
    }
}