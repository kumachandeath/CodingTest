using System;

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        answer = (n*6) / gcd(n,6)/6;
        return answer;
    }

    public int gcd(int a, int b = 6)
    {
        int r;
        while (b != 0)
        {
            r = a % b;
            a = b;
            b = r;
        }
        return a;
    }
}