using System;

namespace TwoDArrayTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2D = {
                { 1, -2, 3, 4 },
                { 5, -6, 7, -8 },
                { 9, 10, -11, 12 },
                { -13, 14, 15, -16 }
            };

            // Task 1
            PrintArray(array2D);

            // Task 2
            Console.WriteLine("Sum of all elements: " + SumAllElements(array2D));

            // Task 3
            Console.WriteLine("Sum of the first column: " + SumFirstColumn(array2D));

            // Task 4
            PrintNegativeElements(array2D);

            // Task 5
            var (min, max) = FindMinMax(array2D);
            Console.WriteLine($"Min element: {min}, Max element: {max}");

            // Task 6
            ModifyArray(array2D);
            PrintArray(array2D);

            // Task 7
            SetSecondRowToZero(array2D);
            PrintArray(array2D);

            // Task 8
            int[,] array3x3 = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            SetThirdColumnToZero(array3x3);
            PrintArray(array3x3);

            // Task 9
            Console.WriteLine("Sum of left diagonal: " + SumLeftDiagonal(array3x3));

            // Task 10
            Console.WriteLine("Sum of right diagonal: " + SumRightDiagonal(array2D));

            // Task 11
            int[,] array5x5 = {
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15 },
                { 16, 17, 18, 19, 20 },
                { 21, 22, 23, 24, 25 }
            };
            SetBelowLeftDiagonalToZero(array5x5);
            PrintArray(array5x5);

            // Task 12
            SetAboveLeftDiagonalToZero(array5x5);
            PrintArray(array5x5);

            // Task 13
            int[,] array2D1 = {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16 }
            };
            int[,] sumArray = SumOfTwoArrays(array2D, array2D1);
            PrintArray(sumArray);

            // Task 14:
            SumOfEachRow(array2D);

            // Task 15
            SumOfEachColumn(array2D);

            // Task 16
            int shift = 3;
            int[,] shiftedArray = {
                { 1, 1, 0, 0, 1, 1 },
                { 1, 1, 0, 0, 1, 1 },
                { 1, 1, 0, 0, 1, 1 },
                { 1, 1, 0, 0, 1, 1 }
            };
            ShiftArrayRight(shiftedArray, shift);
            PrintArray(shiftedArray);

            // Task 17
            int[,] productArray = MultiplyTwoArrays(array2D, array2D1);
            PrintArray(productArray);

            // Task 18
            PrintPrimeNumbers(array2D);
        }

        static void PrintArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static int SumAllElements(int[,] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return sum;
        }

        static int SumFirstColumn(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, 0];
            }
            return sum;
        }

        static void PrintNegativeElements(int[,] array)
        {
            Console.WriteLine("Negative elements:");
            foreach (int num in array)
            {
                if (num < 0)
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
        }

        static (int, int) FindMinMax(int[,] array)
        {
            int min = array[0, 0];
            int max = array[0, 0];

            foreach (int num in array)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }

            return (min, max);
        }

        static void ModifyArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] > 0)
                    {
                        if (array[i, j] % 2 == 0)
                        {
                            array[i, j] = 2;
                        }
                        else
                        {
                            array[i, j] = 1;
                        }
                    }
                    else if (array[i, j] < 0)
                    {
                        if (array[i, j] % 2 == 0)
                        {
                            array[i, j] = -2;
                        }
                        else
                        {
                            array[i, j] = -1;
                        }
                    }
                }
            }
        }

        static void SetSecondRowToZero(int[,] array)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                array[1, i] = 0;
            }
        }

        static void SetThirdColumnToZero(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i, 2] = 0;
            }
        }

        static int SumLeftDiagonal(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, i];
            }
            return sum;
        }

        static int SumRightDiagonal(int[,] array)
        {
            int sum = 0;
            int size = array.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                sum += array[i, size - 1 - i];
            }
            return sum;
        }

        static void SetBelowLeftDiagonalToZero(int[,] array)
        {
            int size = array.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    array[i, j] = 0;
                }
            }
        }

        static void SetAboveLeftDiagonalToZero(int[,] array)
        {
            int size = array.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    array[i, j] = 0;
                }
            }
        }

        static int[,] SumOfTwoArrays(int[,] array1, int[,] array2)
        {
            int rows = array1.GetLength(0);
            int columns = array1.GetLength(1);
            int[,] sumArray = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sumArray[i, j] = array1[i, j] + array2[i, j];
                }
            }

            return sumArray;
        }
        static void SumOfEachRow(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                int sum = 0;
                for (int j = 0; j < columns; j++)
                {
                    sum += array[i, j];
                }
                Console.WriteLine($"Sum of row {i}: {sum}");
            }
        }
        static void SumOfEachColumn(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            for (int j = 0; j < columns; j++)
            {
                int sum = 0;
                for (int i = 0; i < rows; i++)
                {
                    sum += array[i, j];
                }
                Console.WriteLine($"Sum of column {j}: {sum}");
            }
        }
        static void ShiftArrayRight(int[,] array, int shift)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            int[,] tempArray = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    tempArray[i, (j + shift) % columns] = array[i, j];
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = tempArray[i, j];
                }
            }
        }
        static int[,] MultiplyTwoArrays(int[,] array1, int[,] array2)
        {
            int rows = array1.GetLength(0);
            int columns = array1.GetLength(1);
            int[,] productArray = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    productArray[i, j] = array1[i, j] * array2[i, j];
                }
            }

            return productArray;
        }
        static void PrintPrimeNumbers(int[,] array)
        {
            Console.WriteLine("Prime numbers in the array:");
            foreach (int num in array)
            {
                if (IsPrime(num))
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
        }

        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
