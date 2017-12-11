namespace LintCode
{
    public class Code366
    {
        public static int Fibonacci1(int n)
        {
            int f1 = 0;
            int f2 = 1;
            int f3 = 0;

            if (n == 1)
            {
                return f1;
            }
            if (n == 2)
            {
                return f2;
            }

            for (int i = 2; i < n; i++)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
            }
            return f3;
        }

        /// <summary>
        /// Very Slow
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Fibonacci2(int n)
        {
            if (n == 1)
            {
                return 0;
            }
            else if (n == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci2(n - 1) + Fibonacci2(n - 2);
            }
        }
    }
}