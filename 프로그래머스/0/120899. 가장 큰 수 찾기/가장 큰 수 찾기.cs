using System;

public class Solution
{
    public int[] solution(int[] array)
    {
        int[] answer = new int[2];
        int maxInt = array[0];
        int maxIndex = 0;
        for (int i = 0; i < array.Length-1; i++)
        {
            if (array[i+1] > array[i])
            {
                maxInt = array[i+1];
                maxIndex = i+1;
            }
        }
        answer[0] = maxInt;
        answer[1] = maxIndex;
        return answer;
    }
}