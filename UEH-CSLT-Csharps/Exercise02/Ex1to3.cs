using System;
using System.Collections.Generic;
using System.Text;

namespace UEH_CSLT_Csharps.Exercise02
{
    internal class Ex1to3
    {
        static void Ex01() //Đổi độ C sang Kelvin & Fahrenheit
        {
            Console.Write("Nhập độ C: ");
            double doC = Convert.ToDouble(Console.ReadLine());
            double kelvin = doC + 273.0;
            double fahrenheit = doC * 18.0 / 10.0 + 32.0;
            Console.WriteLine($"{doC} độ C = {kelvin} độ K = {fahrenheit} độ F");
        }
        static void Ex02() //Tính diện tích & thể tích hình cầu
        {
            Console.Write("Nhập bán kính hình cầu: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double surface = (4.0 * Math.PI * Math.Pow(r, 2));
            Console.WriteLine($"Diện tích hình cầu là: {surface}");
            double volume = (4.0 / 3.0 * Math.PI * Math.Pow(r, 3));
            Console.WriteLine($"Thể tích hình cầu là: {volume}");

        }
        static void Ex03()
        {
            Console.Write("Nhập số nguyên a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập số nguyên b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} x {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} mod {b} = {a % b}");
        }
        //static void Main(string[] args)
        //{
        //    Console.OutputEncoding = System.Text.Encoding.UTF8;
        //    Console.InputEncoding = System.Text.Encoding.UTF8;
        //    Ex01();
        //    Ex02();
        //    Ex03();
        //}
    }
}
