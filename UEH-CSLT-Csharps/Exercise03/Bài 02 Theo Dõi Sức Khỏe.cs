using System;
using System.Collections.Generic;
using System.Text;

namespace UEH_CSLT_Csharps.Exercise03
{
    internal class Bài_2
    {
        static void Bai2()
        {
            double chieuCao;
            Console.Write("Nhập chiều cao của bạn(m): ");
            while (!double.TryParse(Console.ReadLine(), out chieuCao)|| chieuCao<=0)
            {
                Console.WriteLine("Dữ liệu không hợp lệ!");
                Console.Write("Vui lòng nhập lại: ");
            }
            double canNang;
            Console.Write("Nhập cân nặng của bạn(kg): ");
            while (!double.TryParse(Console.ReadLine(), out canNang) || canNang <= 0)
            {
                Console.WriteLine("Dữ liệu không hợp lệ!");
                Console.Write("Vui lòng nhập lại: ");
            }
            double chiSoBMI = canNang / Math.Pow(chieuCao,2);
            Console.WriteLine($"Chỉ số BMI của bạn là:{chiSoBMI:F2}");
            if (chiSoBMI < 18.5)
            {
                Console.WriteLine("Phân loại sức khỏe: Gầy(Thiếu Cân)");
            }
            else if(chiSoBMI < 23.0)
            {
                Console.WriteLine("Phân loại sức khỏe: Bình thường(Lý tưởng)");
            }
            else if (chiSoBMI < 25.0)
            {
                Console.WriteLine("Phân loại sức khỏe: Thừa Cân(Tiền béo phì)");
            }
            else
            {
                Console.WriteLine("Phân loại sức khỏe: Béo Phì");
            }
            double canNangMin = 18.5 * Math.Pow(chieuCao, 2);
            double canNangMax = 22.9 * Math.Pow(chieuCao, 2);
            Console.WriteLine($"Khuyên dùng: Cân nặng lý tưởng của bạn nên từ {canNangMin:F2}kg đến {canNangMax:F2}kg");
        }
        //static void Main(string[] args)
        //{
        //    Console.OutputEncoding = System.Text.Encoding.UTF8;
        //    Console.InputEncoding = System.Text.Encoding.UTF8;
        //    Bai2();
        //}
    }
}
