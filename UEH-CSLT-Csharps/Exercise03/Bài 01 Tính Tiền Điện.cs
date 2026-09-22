using System;
using System.Collections.Generic;
using System.Text;

namespace UEH_CSLT_Csharps.Exercise03
{
    internal class Bài_1
    {
        //Tính tiền điện sinh hoạt gia đình theo bậc thang
        //Cách 1:
        static void Bai1()
        {
            Console.WriteLine("Tính Tiền Điện");
            Console.Write("Nhập chỉ số cũ (kWh): ");
            decimal chiSoCu = decimal.Parse(Console.ReadLine());
            Console.Write("Nhập chỉ số mới (kWh): ");
            decimal chiSoMoi = decimal.Parse(Console.ReadLine());
            while (chiSoCu > chiSoMoi)
            {
                Console.WriteLine("Lỗi! Chỉ sô mới phải lớn hơn chỉ số cũ");
                Console.Write("Nhập chỉ số cũ: ");
                chiSoCu = decimal.Parse(Console.ReadLine());
                Console.Write("Nhập chỉ số mới: ");
                chiSoMoi = decimal.Parse(Console.ReadLine());
            }
            decimal sokWh = chiSoMoi - chiSoCu;
            decimal tienDien = 0;
            Console.WriteLine($"Lượng tiêu thụ trong tháng là: {sokWh}");
            if (sokWh <= 50)
            {
                tienDien = sokWh * 1806m;
            }
            else if (sokWh <= 100)
            {
                tienDien = (50 * 1806m) + ((sokWh - 50) * 1866m);
            }
            else if (sokWh <= 200)
            {
                tienDien = (50 * 1806m) + (50 * 1866m) + (sokWh - 100) * 2167m;
            }
            else if (sokWh <= 300)
            {
                tienDien = (50 * 1806m) + (50 * 1866m) + (100 * 2167m) + (sokWh - 200) * 2729m;
            }
            else
            {
                tienDien = (50 * 1806m) + (50 * 1866m) + (100 * 2167m) + (100 * 2729m) + (sokWh - 300) * 3050m;
            }
            Console.WriteLine($"Với {sokWh} -> Tiền điện chưa thuế là: {tienDien:#,##0} VNĐ");
            decimal tienThue = tienDien * 0.08m;
            Console.WriteLine($"Tiền thuế là: {tienThue:#,###0} VNĐ");
            Console.WriteLine($"Tổng thanh toán: {tienDien + tienThue:N0} VNĐ");

        }
        //static void Main(string[] args)
        //{
        //    Console.OutputEncoding = Encoding.UTF8;
        //    Console.InputEncoding = Encoding.UTF8;
        //    Bai1();
        //}
    }
}
