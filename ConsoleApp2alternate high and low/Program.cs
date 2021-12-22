using System;

namespace alternate_high_and_low
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 9, 6, 8, 3, 7 };
            Alternative(A);
            Console.WriteLine(string.Join(",",A));
        }

        public static void Alternative(int[] A)
        {
            int len = A.Length;
            for (int i = 1; i < A.Length; i+=2)
            {
                if (A[i-1] > A[i ])
                    Swap(A, i, i - 1);

                if (A[i + 1] < len && A[i + 1] > A[i])
                    Swap(A, i, i + 1);
            }
        }

        public static void Swap(int[] A, int X, int Y)
        {
            int tmp = A[X];
            A[X] = A[Y];
            A[Y] = tmp;
        } 
    }
}
