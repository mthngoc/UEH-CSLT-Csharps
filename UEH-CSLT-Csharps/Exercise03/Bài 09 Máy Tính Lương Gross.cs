using System;
using System.Collections.Generic;
using System.Text;

namespace UEH_CSLT_Csharps.Exercise03
{
    internal class Bài_9_Máy_Tính_Lương_Gross
    {
        static void Bai9()
        {
            Console.Write("Nhập lương Gross: ");
            decimal luongGross;
            while(!decimal.TryParse(Console.ReadLine(), out luongGross) || luongGross <= 0)
            {
                Console.Write("Dữ liệu không hợp lệ! Vui lòng nhập lại: ");
            }
            Console.Write("Số người phụ thuộc: ");
            int soNguoi;
            while(!int.TryParse(Console.ReadLine(), out soNguoi) || soNguoi < 0)
            {
                Console.Write("Dữ liệu không hợp lệ! Vui lòng nhập lại: ");
            }
            decimal giamtruBaoHiem = luongGross * 0.105m;
            Console.WriteLine($"Giảm trừ bảo hiểm: {giamtruBaoHiem:N0} VNĐ");
            decimal thuNhapChiuThue = luongGross - giamtruBaoHiem - 11000000 - soNguoi * 4400000;
            if (thuNhapChiuThue <= 0)
            {
                thuNhapChiuThue = 0;
            }
            Console.WriteLine($"Thu nhập chịu thuế: {thuNhapChiuThue:N0} VNĐ");
            decimal thueTNCN =0m;
            if (thuNhapChiuThue <= 5000000)
            {
                thueTNCN = thuNhapChiuThue * 0.05m;
            }
            else if(thuNhapChiuThue <= 10000000)
            {
                thueTNCN = (5000000 * 0.05m) + (thuNhapChiuThue - 5000000) * 0.1m;
            }
            else
            {
                thueTNCN = (5000000 * 0.05m) + (5000000 * 0.1m) + (thuNhapChiuThue - 10000000) * 0.15m;
            }
            Console.WriteLine($"Thuế TNCN phải nộp là: {thueTNCN:N0} VNĐ");
            decimal luongNet = luongGross - giamtruBaoHiem - thueTNCN;
            Console.WriteLine($"Lương Net thực nhận: {luongNet:N0} VNĐ");
        }
        //static void Main( string[] args)
        //{
        //    Console.OutputEncoding = System.Text.Encoding.UTF8;
        //    Bai9();
        //}
    }
}
