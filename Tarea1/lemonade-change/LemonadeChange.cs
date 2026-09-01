public class Solution
{
    public bool LemonadeChange(int[] bills)
    {
        int five = 0;
        int ten = 0;

        for (int i = 0; i < bills.Length; i++)
        {
            if (bills[i] == 5)
            {
                five++;
            }
            if (bills[i] == 10)
            {
                five--;
                ten++;
            }
            if (bills[i] == 20)
            {
                if (ten == 0)
                {
                    five -= 3;
                }
                else
                {
                    five--;
                    ten--;
                }     
            }

            if (five < 0) return false;
        }

        return true;
    }
}
