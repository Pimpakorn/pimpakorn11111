using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of rows for Pascal's triangle: ");
        int numRows = Convert.ToInt32(Console.ReadLine());

        if (numRows < 0)
        {
            Console.WriteLine("Invalid Pascal's triangle row number.");
            return;
        }

        for (int row = 0; row <= numRows; row++)
        {
            for (int col = 0; col <= row; col++)
            {
                int coef = CalculateCoefficient(row, col);
                Console.Write(coef + " ");
            }
            Console.WriteLine();
        }
    }

    static int CalculateCoefficient(int n, int k)
    {
        if (k == 0 || k == n)
        {
            return 1;
        }
        else
        {
            return CalculateCoefficient(n - 1, k - 1) + CalculateCoefficient(n - 1, k);
        }
    }
}