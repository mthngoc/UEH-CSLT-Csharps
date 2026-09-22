using System;

namespace UEH_CSLT_Csharps.Exercise03
{
    internal class Bài_14_Xu_Ly_Chuoi_So
    {
        static void Bai14()
        {
            int giaTri = 0;
            while (true)
            {
                Console.Write("Nhập chuỗi số: ");
                string chuoiNhap = Console.ReadLine();

                if (int.TryParse(chuoiNhap, out giaTri))
                {
                    Console.WriteLine($"Kiểm tra Parse: Thành công! Giá trị int = {giaTri}");
                    break;
                }
                else
                {
                    Console.WriteLine("Kiểm tra Parse: Thất bại! Chuỗi không phải là số nguyên hợp lệ. Vui lòng nhập lại.");
                }
            }
            if (giaTri >= 0 && giaTri <= 255)
            {
                Console.WriteLine("Phù hợp kiểu byte: CÓ (Vừa vặn trong dải 0-255)");
            }
            else
            {
                Console.WriteLine("Phù hợp kiểu byte: KHÔNG (Vượt ngoài dải 0-255)");
            }
            if (giaTri >= -32768 && giaTri <= 32767)
            {
                Console.WriteLine("Phù hợp kiểu short: CÓ (Vừa vặn trong dải -32,768 đến 32,767)");
            }
            else
            {
                Console.WriteLine("Phù hợp kiểu short: KHÔNG (Vượt ngoài dải short)");
            }
            int soDuong = Math.Abs(giaTri);
            int tongChuSo = 0;
            int n = soDuong;
            while (n > 0)
            {
                tongChuSo = tongChuSo + n % 10;
                n = n / 10;
            }
            Console.WriteLine($"Tổng các chữ số: {tongChuSo}");
            Console.Write("Kiểm tra Tràn số: ");
            try
            {
                checked
                {
                    int binhPhuong = giaTri * giaTri;
                    Console.WriteLine($"An toàn trong phạm vi int32. (Giá trị^2 = {binhPhuong})");
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Tràn số! Phép tính thử nghiệm vượt quá giới hạn của kiểu int32.");
            }
        }
        //static void Main(string[] args)
        //{
        //    Console.OutputEncoding = System.Text.Encoding.UTF8;
        //    Console.InputEncoding = System.Text.Encoding.UTF8;
        //    Bai14();
        //}
    }
}