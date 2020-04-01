using System;
using System.Collections.Generic;
namespace Programmers_pro2_하드코딩제거
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testcase = { 1, 3, 2, 4, 2,1,2,3,4,5,6,7 };
            Solution sol = new Solution();
            int[] ret = sol.solution(testcase);
/*            for (int i = 0; i < ret.Length; i++)
            {
                Console.WriteLine(ret[i]);
            }*/
        }
    }


    public class Solution
    {
        public int[] solution(int[] answers)
        {
            int[] answer = new int[3];

            int a = 0;
            int b = 0;
            int c = 0;
            int[] aa = { 1, 2, 3, 4, 5 };
            int[] bb = { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] cc = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i] == aa[i % aa.Length]) a++;
                if (answers[i] == bb[i % bb.Length]) b++;
                if (answers[i] == cc[i % cc.Length]) c++;
            }
            List<int> list = new List<int>();

            int max = Math.Max(a, Math.Max(b, c));
            if (max == a) list.Add(1);
            if (max == b) list.Add(2);
            if (max == c) list.Add(3);

            answer = list.ToArray();

            return answer;
        }
    }
}


