//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace UEH_CSLT_Csharps.Session07
//{
//    internal class Exercise_In_Slide
//    {
//        static void Bai01() //Tìm giá trị trung bình của các phần tử trong mảng.
//        {
//            Console.Write("Nhập số lượng phần tử n: ");
//            int n = int.Parse(Console.ReadLine());
//            int[] a = new int[n];

//            for (int i = 0; i < n; i++)
//            {
//                Console.Write($"Nhập phần tử thứ {i}: ");
//                a[i] = int.Parse(Console.ReadLine());
//            }
//            int tong = 0;
//            foreach (int i in a)
//            {
//                tong += i;
//            }
//            double sum = (double)tong / n;
//            Console.WriteLine($"Giá trị trung bình của các phần tử là: {sum:F2}");
//        }
//        static void Bai05(int[] a) //Tìm giá trị lớn nhất và nhỏ nhất của 1 mảng
//        {
//            Random rnd = new Random();
//            for (int i = 0; i < a.Length; i++)
//            {
//                a[i] = rnd.Next(1, 10);
//            }

//            foreach(int v in a)
//            {
//                int max = 0;
//                for (int i = 1; i < a.Length; i++)
//                {
//                    if (a[i] > max) max = a[i];
//                }
//                Console.WriteLine($"Giá trị lớn nhất là: {max}");

//                int min = 0;
//                for (int i = 1; i < a.Length; i++)
//                {
//                    if (a[i] < max) max = a[i];
//                }
//                Console.WriteLine($"Giá trị nhỏ nhất là: {min}");
//            }
//        }
//        static void Main( string[] args)
//        {
//            Console.OutputEncoding = Encoding.UTF8;
//            //Bai01();
//            //Bai05();
//        }
//    }
//}
