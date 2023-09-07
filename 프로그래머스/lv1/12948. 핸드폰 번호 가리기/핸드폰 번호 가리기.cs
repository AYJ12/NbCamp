public class Solution {
    public string solution(string phone_number) {
        string answer = "";
        
        for(int i = 0; i < phone_number.Length - 4; i++){
            answer += "*";
        }
        
        answer += phone_number.Substring(phone_number.Length - 4);
        
        return answer;
    }
}