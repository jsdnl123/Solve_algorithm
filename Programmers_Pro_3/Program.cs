using System;
using System.Collections.Generic;
namespace Programmers_Pro_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            int[] arr = { 1, 5, 2, 6, 3, 7, 4 };
            int[,] com = new int[2,3];
            for(int i=0; i < 2; i++)
            {
                com[i, 0] = 2;
                com[i, 1] = 5;
                com[i, 2] = 3;


            }
            sol.solution(arr, com);
        }
    }

    public class Solution
    {
        public int[] solution(int[] array, int[,] commands)
        {
            int[] answer = new int[] { };
            List<int> list = new List<int>();
            for (int j=0; j<array.Length; j++)
            {
                list.Add(j);
            }
            List<int> list3 = new List<int>();
            for (int i=0; i<commands.Length; i++)
            {
                int staindex = commands[i, 0];
                int lastindex = commands[i, 1];
                int num = commands[i, 2];
                List<int> list2 = new List<int>();
                for(int k=staindex-1; k<lastindex; k++)
                {
                    list2.Add(list[k]);
                }
                list2.Sort();
                list3.Add(list2[num]);
            }
            answer = list3.ToArray();
            return answer;
        }
    }
}
