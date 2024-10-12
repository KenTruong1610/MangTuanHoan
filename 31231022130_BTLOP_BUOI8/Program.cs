using System;
using System.Text;

class Program
{
    static bool TuanHoan(int[] arr, int n, int length)
    {
        for (int i = n; i < length; i += n)
        {
            for (int j = 0; j < n; j++)
            {
                if (arr[j] != arr[i + j])
                {
                    return false;
                }
            }
        }
        return true;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        Console.Write("Nhập vào số phần tử mảng A: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] A = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhập phần tử thứ {0} của mảng A: ", i);
            A[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 1; i <= n / 2; i++)
        {
            if (n % i == 0 && TuanHoan(A, i, n))
            {
                Console.WriteLine("Mảng A là mảng tuần hoàn.");
                Console.ReadLine();
                return;
            }
            
        }

        Console.WriteLine("Mảng A không là mảng tuần hoàn.");
        Console.ReadLine();
    }
}
