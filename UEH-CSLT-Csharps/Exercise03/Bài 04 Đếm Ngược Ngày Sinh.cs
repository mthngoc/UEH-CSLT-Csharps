using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace UEH_CSLT_Csharps.Exercise03
{
    internal class Bài_4_Đếm_Ngược_Ngày_Sinh
    {
        static void Bai4()
        {
            DateTime ngaySinh;
            Console.Write("Nhập ngày sinh của bạn (dd/mm/yyyy): ");
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy",CultureInfo.InvariantCulture,DateTimeStyles.None, out ngaySinh))
            {
                Console.Write("Ngày sinh không hợp lệ! Vui lòng nhập lại: ");
            }
            DateTime ngayHienTai = DateTime.Now.Date;
            int tuoi = ngayHienTai.Year - ngaySinh.Year;
            if (ngayHienTai.Month < ngaySinh.Month || ngayHienTai.Month==ngaySinh.Month && ngayHienTai.Day < ngaySinh.Day)
            {
                tuoi--;
            }
            TimeSpan ngayDaSong = ngayHienTai - ngaySinh;
            Console.WriteLine($"Tuổi hiện tại: {tuoi}");
            Console.WriteLine($"Bạn đã sống tổng cộng: {ngayDaSong.TotalDays} ngày");

            DateTime sinhNhatKeTiep = new DateTime(ngayHienTai.Year,ngaySinh.Month, ngaySinh.Day);
            if (sinhNhatKeTiep < ngayHienTai)
            {
                sinhNhatKeTiep = sinhNhatKeTiep.AddYears(1);
            }
            TimeSpan ngayDemNguoc = sinhNhatKeTiep - ngayHienTai;
            Console.WriteLine($"Sinh nhật tiếp theo còn: {(int)ngayDemNguoc.TotalDays:#,##0} ngày nữa");
        }
        //static void Main(string[] args)
        //{
        //    Console.OutputEncoding = System.Text.Encoding.UTF8;
        //    Console.InputEncoding = System.Text.Encoding.UTF8;
        //    Bai4();
        //}
    }
}
