using System;

namespace Lab
{
    public class Tasks
    {
        public double fraction(double x)
        {
            return Math.Abs(x - (int)x);
        }

        public int charToNum(char x)
        {
            return x - '0';
        }

        public bool is2Digits(int x)
        {
            return (x >= 10 && x <= 99) || (x <= -10 && x >= -99);
        }

        public bool isInRange(int a, int b, int num)
        {
            if (a > b)
            {
                return num >= b && num <= a;
            }
            else
            {
                return num >= a && num <= b;
            }
        }

        public bool isEqual(int a, int b, int c)
        {
            return a == b && b == c;
        }

        public int abs(int x)
        {
            if (x < 0)
            {
                return -x;
            }

            return x;
        }

        public bool is35(int x)
        {
            if (x % 3 == 0 && x % 5 == 0)
            {
                return false;
            }

            if (x % 3 == 0 || x % 5 == 0)
            {
                return true;
            }

            return false;
        }

        public int max3(int x, int y, int z)
        {
            int max = x;

            if (y > max)
            {
                max = y;
            }

            if (z > max)
            {
                max = z;
            }

            return max;
        }

        public int sum2(int x, int y)
        {
            int sum = x + y;

            if (sum >= 10 && sum <= 19)
            {
                return 20;
            }

            return sum;
        }

        public string day(int x)
        {
            switch (x)
            {
                case 1:
                    return "понедельник";
                case 2:
                    return "вторник";
                case 3:
                    return "среда";
                case 4:
                    return "четверг";
                case 5:
                    return "пятница";
                case 6:
                    return "суббота";
                case 7:
                    return "воскресенье";
                default:
                    return "это не день недели";
            }
        }

        public string listNums(int x)
        {
            string result = "0";

            for (int i = 1; i <= x; i++)
            {
                result += " " + i;
            }

            return result;
        }

        public string chet(int x)
        {
            string result = "0";

            for (int i = 2; i <= x; i += 2)
            {
                result += " " + i;
            }

            return result;
        }

        public int numLen(long x)
        {
            if (x == 0)
            {
                return 1;
            }

            if (x < 0)
            {
                x = -x;
            }

            int count = 0;

            while (x > 0)
            {
                x /= 10;
                count++;
            }

            return count;
        }

        public void square(int x)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        public void rightTriangle(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < x - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}