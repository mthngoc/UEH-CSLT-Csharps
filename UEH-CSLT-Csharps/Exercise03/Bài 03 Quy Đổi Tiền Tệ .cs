using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace UEH_CSLT_Csharps.Exercise03
{
    internal class Bài_3_Quy_Đổi_Tiền_Tệ
    {
        enum CurrencyType { USD = 1, EUR, JPY, GBP }
        static void doitien()
        {
            decimal tienCanDoi;
            Console.Write("Nhập số tiền VNĐ cần đổi: ");
            while (!decimal.TryParse(Console.ReadLine(), out tienCanDoi) || tienCanDoi <= 0)
            {
                Console.Write("Số tiền không hợp lệ. Vui lòng nhập lại: ");
            }
            int luaChon;
            Console.Write("Chọn loại ngoại tệ bạn muốn đổi: 1-USD, 2-EUR, 3-JPY, 4-GBP: ");
            while(!int.TryParse(Console.ReadLine(), out luaChon) || luaChon < 1 || luaChon > 4)
            {
                Console.Write("Lựa chọn không hợp lệ! Vui lòng nhập lại: ");
            }
            CurrencyType loaiTien = (CurrencyType)luaChon;
            decimal phiDV = tienCanDoi * 0.005m;
            decimal tienSauPhi = tienCanDoi - phiDV;
            string kiHieu = "";
            decimal tienNhanDuoc = 0m;
            switch (loaiTien)
            {
                case CurrencyType.USD: 
                    tienNhanDuoc = tienSauPhi/25400m;
                    kiHieu = "USD";
                    break; 
                case CurrencyType.EUR:
                    tienNhanDuoc = tienSauPhi/27200m;
                    kiHieu = "EUR";
                    break;
                case CurrencyType.JPY:
                    tienNhanDuoc = tienSauPhi / 165m;
                    kiHieu = "JPY";
                    break;
                case CurrencyType.GBP:
                    tienNhanDuoc = tienSauPhi / 32100m;
                    kiHieu = "GBP";
                    break;
            }
            Console.WriteLine($"Phí dịch vụ (0.5%): {phiDV:#,##0} VNĐ");
            Console.WriteLine($"Số tiền VNĐ tính đổi: {tienSauPhi:#,##0} VNĐ");
            Console.WriteLine($"Số tiền {kiHieu} nhận được: {tienNhanDuoc:#,##0.00} {kiHieu}");
        }
        //static void Main(string[] args)
        //{
        //    Console.OutputEncoding = System.Text.Encoding.UTF8;
        //    Console.InputEncoding = System.Text.Encoding.UTF8;
        //    doitien();
        //}
    }
}
