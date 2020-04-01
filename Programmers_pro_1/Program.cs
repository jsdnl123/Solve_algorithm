using System;
using System.Collections.Generic;

namespace Programmers_pro_1
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Solution sol = new Solution();
            long nn = sol.solution(n);
            Console.WriteLine(nn);
        }
    }

    public class Solution
    {
        public int[] solution(int[] arr, int divisor)
        {
            int[] answer = new int[] { };
            int index = 0;
            foreach (int n in arr)
            {

                if (n % divisor == 0)
                {
                    answer[index] = n;
                    index++;
                }
            }

            if (answer.Length == 0)
            {
                answer[0] = -1;
            }
            else
            {
                for(int i=0; i< answer.Length; i++)
                {
                    for(int j=0; j<answer.Length-i-1; j++)
                    {
                        int temp = 0;
                        if (answer[j] > answer[j+1])
                        {
                            temp = answer[j];
                            answer[j] = answer[j+1];
                            answer[j+1] = temp;
                        }
                    }
                }
            }
            return answer;
        }
    }
}
