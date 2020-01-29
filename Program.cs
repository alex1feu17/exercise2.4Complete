using System;

namespace exercise2
{
    class Program
    {
        public static bool IsPrime(int n)
        {
            int x = (int)Math.Floor(Math.Sqrt(n));
            if(n==1)
            {
                return false;
            }
            else
            {
                if(n==2)
                {
                    return true;

                }
                else
                {
                    int i = 2;
                    if(i<=x)
                    {
                        while(i <= x)
                        {

                        
                            if(n%i==0)
                            {
                                return false;

                            }
                            else
                            {
                                ++i;
                            }
                        }
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n Sum of the first 500 prime numbers:");
            long sum = 0;
            int ctr = 0;
            int n = 2;

            if(ctr<500)
            {
                while(ctr < 500)
                {
                    if(IsPrime(n)==true)
                    {
                        sum += n;
                        n++;
                    }
                    else
                    {
                        n++;
                    }
                }
                
            }
            else 
            {
                Console.WriteLine(sum.ToString());
            }
        }
    }
}
