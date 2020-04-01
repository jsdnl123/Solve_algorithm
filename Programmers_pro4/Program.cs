using System;

namespace Programmers_pro4
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public class Solution
        {
            public int solution(int n, int[] lost, int[] reserve)
            {
                int answer = 0;

                bool[] ret = new bool[n];
                bool[] rsv = new bool[n];

                for(int i=0; i<n; i++)
                {
                    for(int j=0; j<lost.Length; j++)
                    {
                        if(i == (lost[j] - 1))
                        {
                            ret[i] = false;
                        }
                        else
                        {
                            ret[i] = true;
                        }
                    }
                }


                for(int k =0; k<n; k++)
                {
                    if (ret[k] == false)
                    {
                        int index = k + 1;
                        for(int m =0; m<reserve.Length; m++)
                        {
                            if(index == reserve[m] - 1)
                            {
                                ret[k] = true;
                                reserve[m] = -1;
                            }
                            else if(index == reserve[m] + 1)
                            {
                                ret[k] = true;
                                reserve[m] = -1;
                            }
                        }
                    }
                }
                for(int l =0; l<ret.Length; l++)
                {
                    if (ret[l] == true)
                    {
                        answer++;
                    }
                }

                return answer;
            }
        }
    }
}
