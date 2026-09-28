using System;
using System.Collections.Generic;
using System.Text;

namespace UEH_CSLT_Csharps.Session06
{
    internal class BaiTap7LMS
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Run();
            // Run2();
            // Run3();
        }
        static int[] CreateRandomArray(int size, int min, int max)
        {
            Random rnd = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++) arr[i] = rnd.Next(min, max + 1);
            return arr;
        }
        static double CalculateAverage(int[] arr)
        {
            int sum = 0;
            foreach (int x in arr) sum += x;
            return (double)sum / arr.Length;
        }
        static bool ContainsValue(int[] arr, int value)
        {
            foreach (int x in arr) if (x == value) return true;
            return false;
        }
        static int FindIndex(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++) if (arr[i] == value) return i;
            return -1;
        }
        static int[] RemoveElement(int[] arr, int value)
        {
            int index = FindIndex(arr, value);
            if (index == -1) return arr;
            int[] newArr = new int[arr.Length - 1];
            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                if (i != index) newArr[j++] = arr[i];
            }
            return newArr;
        }
        static void FindMaxMin(int[] arr, out int max, out int min)
        {
            max = arr[0]; min = arr[0];
            foreach (int x in arr)
            {
                if (x > max) max = x;
                if (x < min) min = x;
            }
        }
        static int[] ReverseArray(int[] arr)
        {
            int[] rev = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++) rev[i] = arr[arr.Length - 1 - i];
            return rev;
        }
        static void FindDuplicates(int[] arr)
        {
            Console.Write("Các giá trị trùng lặp: ");
            var duplicates = arr.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key);
            foreach (var d in duplicates) Console.Write(d + " ");
            Console.WriteLine();
        }
        static int[] RemoveDuplicates(int[] arr)
        {
            return arr.Distinct().ToArray();
        }
        static void PrintArray(int[] arr)
        {
            Console.WriteLine("[" + string.Join(", ", arr) + "]");
        }
        public static void Run()
        {
            int[] arr = CreateRandomArray(10, 1, 20);
            Console.Write("Mảng ngẫu nhiên ban đầu: "); PrintArray(arr);

            Console.WriteLine($"1. Trung bình: {CalculateAverage(arr)}");
            Console.WriteLine($"2. Chứa số 10? {ContainsValue(arr, 10)}");
            Console.WriteLine($"3. Vị trí của số 10: {FindIndex(arr, 10)}");

            FindMaxMin(arr, out int max, out int min);
            Console.WriteLine($"5. Max = {max}, Min = {min}");

            Console.Write("6. Mảng đảo ngược: "); PrintArray(ReverseArray(arr));
            FindDuplicates(arr);
            Console.Write("8. Mảng sau khi xóa trùng: "); PrintArray(RemoveDuplicates(arr));
        }
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        static bool LinearSearchWord(string sentence, string word)
        {
            string[] words = sentence.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string w in words)
            {
                if (w.Equals(word, StringComparison.OrdinalIgnoreCase)) return true;
            }
            return false;
        }
        public static void Run2()
        {
            int[] numbers = new int[10];
            Console.WriteLine("NHẬP 10 SỐ NGUYÊN: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Nhập số thứ {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            BubbleSort(numbers);
            Console.WriteLine("Mảng sau khi sắp xếp (Bubble Sort): " + string.Join(" ", numbers));
            Console.Write("Nhập vào một câu: ");
            string sentence = Console.ReadLine();
            Console.Write("Nhập từ cần tìm: ");
            string targetWord = Console.ReadLine();

            bool found = LinearSearchWord(sentence, targetWord);
            if (found) Console.WriteLine($"Từ '{targetWord}' CÓ xuất hiện trong câu.");
            else Console.WriteLine($"Từ '{targetWord}' KHÔNG xuất hiện trong câu.");
        }
        static int[,] CreateRandomMatrix(int rows, int cols)
        {
            Random rnd = new Random();
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = rnd.Next(1, 100);
            return matrix;
        }
        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++) Console.Write($"{matrix[i, j],4}");
                Console.WriteLine();
            }
        }
        static void PrintRowAndColumn(int[,] matrix, int rowIndex, int colIndex)
        {
            int rows = matrix.GetLength(0), cols = matrix.GetLength(1);

            if (rowIndex >= 0 && rowIndex < rows)
            {
                Console.Write($"Hàng {rowIndex}: ");
                for (int j = 0; j < cols; j++) Console.Write(matrix[rowIndex, j] + " ");
                Console.WriteLine();
            }

            if (colIndex >= 0 && colIndex < cols)
            {
                Console.Write($"Cột {colIndex}: ");
                for (int i = 0; i < rows; i++) Console.Write(matrix[i, colIndex] + " ");
                Console.WriteLine();
            }
        }
        static int FindMatrixMax(int[,] matrix)
        {
            int max = matrix[0, 0];
            foreach (int x in matrix) if (x > max) max = x;
            return max;
        }
        static void FindMinOfRowCol(int[,] matrix, int rowIndex, int colIndex)
        {
            int rows = matrix.GetLength(0), cols = matrix.GetLength(1);

            if (rowIndex >= 0 && rowIndex < rows)
            {
                int minRow = matrix[rowIndex, 0];
                for (int j = 1; j < cols; j++) if (matrix[rowIndex, j] < minRow) minRow = matrix[rowIndex, j];
                Console.WriteLine($"Min của hàng {rowIndex} là: {minRow}");
            }

            if (colIndex >= 0 && colIndex < cols)
            {
                int minCol = matrix[0, colIndex];
                for (int i = 1; i < rows; i++) if (matrix[i, colIndex] < minCol) minCol = matrix[i, colIndex];
                Console.WriteLine($"Min của cột {colIndex} là: {minCol}");
            }
        }
        static int[,] TransposeMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
            int[,] transposed = new int[cols, rows];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    transposed[j, i] = matrix[i, j];
            return transposed;
        }
        static void PrintDiagonals(int[,] matrix)
        {
            int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
            if (rows != cols)
            {
                Console.WriteLine("Đây không phải ma trận vuông -> Không có đường chéo!");
                return;
            }

            Console.Write("Đường chéo chính: ");
            for (int i = 0; i < rows; i++) Console.Write(matrix[i, i] + " ");
            Console.WriteLine();

            Console.Write("Đường chéo phụ: ");
            for (int i = 0; i < rows; i++) Console.Write(matrix[i, rows - 1 - i] + " ");
            Console.WriteLine();
        }
        public static void Run3()
        {
            Console.Write("Nhập số hàng N: "); int n = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột M: "); int m = int.Parse(Console.ReadLine());

            int[,] matrix = CreateRandomMatrix(n, m);
            Console.WriteLine("\n--- MA TRẬN NGẪU NHIÊN ---");
            PrintMatrix(matrix);

            Console.Write("\nNhập chỉ số hàng/cột i cần xem: ");
            int idx = int.Parse(Console.ReadLine());
            PrintRowAndColumn(matrix, idx, idx);

            Console.WriteLine($"Max của ma trận: {FindMatrixMax(matrix)}");
            FindMinOfRowCol(matrix, idx, idx);

            Console.WriteLine("\n--- MA TRẬN CHUYỂN VỊ (TRANSPOSE) ---");
            PrintMatrix(TransposeMatrix(matrix));

            Console.WriteLine("\n--- ĐƯỜNG CHÉO MA TRẬN ---");
            PrintDiagonals(matrix);
        }
    }
}
