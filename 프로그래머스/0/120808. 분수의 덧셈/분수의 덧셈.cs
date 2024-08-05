public class Solution
{
    public int[] solution(int numer1, int denom1, int numer2, int denom2)
    {
        int[] answer = new int[2];

        int gcbdenom = 1;
        int gcd, temp1, temp2;

        temp1 = denom1;
        temp2 = denom2;

        while (temp2 != 0)
        {
            int r = temp1 % temp2;
            temp1 = temp2;
            temp2 = r;
        }

        gcd = temp1;

        
        gcbdenom = (denom1 * denom2) / gcd;
        

        numer1 = numer1 * gcbdenom / denom1;
        numer2 = numer2 * gcbdenom / denom2;

        answer[0] = numer1 + numer2;
        answer[1] = gcbdenom;

        temp1 = answer[0];
        temp2 = answer[1];

        while (temp2 != 0)
        {
            int r = temp1 % temp2;
            temp1 = temp2;
            temp2 = r;
        }

        gcd = temp1;

        answer[0] /= gcd;
        answer[1] /= gcd;

        return answer;
    }
}