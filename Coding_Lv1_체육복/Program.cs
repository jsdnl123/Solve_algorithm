using System;

namespace Coding_Lv1_체육복
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Solution
    {
        /*
         * 실패할 경우 꼭 확인해야할 Test Case: Lost, Reserve 모두 포함될 경우.
         * Ex) Lost = {2,3} , Reserve = {3,4} 해당 Case에서 3번은 체육복 보유: O, 여벌 체육복 보유:X
         * 로 판단하여 로직 처리해야함.
         * 잃어버렸으나 여벌이 있다?, 현실적으로 문제가 잘못된 것 같으나.. 판단은 해야함.
         */
        public int solution(int n, int[] lost, int[] reserve)
        {

            int answer = 0;
            bool[] ishave = new bool[n];



            for (int k = 0; k < ishave.Length; k++)
            {
                ishave[k] = true;
            }

            for (int k = 0; k < lost.Length; k++)
            {
                for (int a = 0; a < reserve.Length; a++)
                {
                    if (lost[k] == reserve[a])
                    {
                        lost[k] = -1;
                        reserve[a] = -1;
                    }
                }
            }


            for (int i = 0; i < lost.Length; i++)
            {
                bool isnear = false;
                for (int j = 0; j < reserve.Length; j++)
                {
                    if (lost[i] == -1)
                    {
                        continue;
                    }

                    if ((lost[i] - 1) == reserve[j] || (lost[i] + 1) == reserve[j])
                    {
                        isnear = true;
                    }

                    if (!isnear)
                    {
                        ishave[lost[i] - 1] = false;
                    }
                    else
                    {
                        ishave[lost[i] - 1] = true;
                        reserve[j] = -1;
                        break;
                    }
                }
            }
            for (int m = 0; m < ishave.Length; m++)
            {
                if (ishave[m])
                {
                    answer++;
                }
            }
            return answer;
        }
    }

}
