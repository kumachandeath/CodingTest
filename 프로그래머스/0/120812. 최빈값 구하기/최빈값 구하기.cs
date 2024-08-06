using System;

public class Solution
{
    public int solution(int[] array)
    {
        int answer = 0;
        int[] count = new int[1000];
        int maxCount = 0;
        answer = array[0];

        for(int i =0; i < count.Length; i++)
        {
            count[i] = 0;
        }

        for (int i = 0; i < array.Length; i++)
        {
            count[array[i]]++;

            if(count[array[i]] > maxCount)
            {
                maxCount = count[array[i]];
                answer = array[i];
            }
            else if (count[array[i]] == maxCount)
            {
                answer = -1;
            }
        }
        return answer;
    }
}