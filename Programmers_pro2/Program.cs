using System;

namespace Programmers_pro2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testcase = { 1, 3, 2, 4, 2 };
            Solution sol = new Solution();
            int[] ret = sol.solution(testcase);
            for(int i=0; i<ret.Length; i++)
            {
                Console.WriteLine(ret[i]);
            }
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


            for(int i=1; i<answers.Length+1; i++)
            {
                switch (i % 5)
                {
                    case 0:
                        if(answers[i-1] == 5)
                        {
                            a++;
                        }
                        break;
                    case 1:
                        if (answers[i - 1] == 1)
                        {
                            a++;
                        }
                        break;
                    case 2:
                        if (answers[i - 1] == 2)
                        {
                            a++;
                        }
                        break;
                    case 3:
                        if (answers[i - 1] == 3)
                        {
                            a++;
                        }
                        break;
                    case 4:
                        if (answers[i - 1] == 4)
                        {
                            a++;
                        }
                        break;
                }
                //2, 1, 2, 3, 2, 4, 2, 5
                switch (i % 8)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                        if (answers[i - 1] == 2)
                        {
                            b++;
                        }
                       break;
                    case 2:
                        if (answers[i - 1] == 1)
                        {
                            b++;
                        }
                        break;
                    case 4:
                        if (answers[i - 1] == 3)
                        {
                            b++;
                        }
                        break;
                   
                    case 6:
                        if (answers[i - 1] == 4)
                        {
                            b++;
                        }
                        break;
                    case 0:
                        if (answers[i - 1] == 5)
                        {
                            b++;
                        }
                        break;
                }
                //3, 3, 1, 1, 2, 2, 4, 4, 5, 5
                switch (i % 10)
                {
                    case 1:
                    case 2:
                        if (answers[i - 1] == 3)
                        {
                            c++;
                        }
                        break;
                    case 3:
                    case 4:
                        if (answers[i - 1] == 1)
                        {
                            c++;
                        }
                        break;
                    case 5:
                    case 6:
                        if (answers[i - 1] == 2)
                        {
                            c++;
                        }
                        break;
                    case 7:
                    case 8:
                        if (answers[i - 1] == 4)
                        {
                            c++;
                        }
                        break;
                    case 9:
                    case 0:
                        if (answers[i - 1] == 5)
                        {
                            c++;
                        }
                        break;
                }
            }
            if (a==b && b == c)
            {
                answer[0] = 1;
                answer[1] = 2;
                answer[2] = 3;
                return answer;
            }
            
            if(a>b)
            {
                if(a>c)
                {
                    Array.Resize(ref answer, 1);
                    answer[0] = 1;
                    return answer;
                }
            }

            if(b>a)
            {
                if(b>c)
                {
                    Array.Resize(ref answer, 1);
                    answer[0] = 2;
                    return answer;
                }
            }
            
            if(c>a)
            {
                if (c > b)
                {
                    Array.Resize(ref answer, 1);
                    answer[0] = 3;
                    return answer;
                }
            }

            if(a==b && a > c)
            {
                Array.Resize(ref answer, 2);
                answer[0] = 1;
                answer[1] = 2;
                return answer;
            } 

            if(a==c && a > b)
            {
                Array.Resize(ref answer, 2);
                answer[0] = 1;
                answer[1] = 3;
                return answer;
            }

            if(b==c && c > a)
            {
                Array.Resize(ref answer, 2);
                answer[0] = 2;
                answer[1] = 3;
                return answer;
            }
            return answer;

        }
    }
}
