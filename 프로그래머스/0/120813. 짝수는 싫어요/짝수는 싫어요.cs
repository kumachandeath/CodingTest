using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int n)
    {
        int[] answer = new int[] { };

        List<int> list = new List<int>();

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 1)
            {
                list.Add(i);
            }
        }

        answer = list.ToArray();

        return answer;
    }
}