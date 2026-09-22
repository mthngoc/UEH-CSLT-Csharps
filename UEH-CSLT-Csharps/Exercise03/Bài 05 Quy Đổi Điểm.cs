using System;
using System.Collections.Generic;
using System.Text;

namespace UEH_CSLT_Csharps.Exercise03
{
    internal class Bài_5_Quy_Đổi_Điểm
    {
        static void Bai5()
        {
            Console.Write("Nhập điểm số môn lập trình C# (thang 10): ");
            double diem1;
            while(!double.TryParse(Console.ReadLine(), out diem1) || diem1 < 0 || diem1 > 10)
            {
                Console.Write("Điểm số không hợp lệ! Vui lòng nhập lại: ");
            }
            Console.Write("Nhập số tín chỉ: ");
            int tinChi1;
            while(!int.TryParse(Console.ReadLine(), out tinChi1) || tinChi1 <= 0)
            {
                Console.Write("Tín Chỉ không hợp lệ! Vui lòng nhập lại: ");
            }
            Console.Write("Nhập điểm số môn Toán rời rạc (thang 10): ");
            double diem2;
            while (!double.TryParse(Console.ReadLine(), out diem2) || diem2 < 0 || diem2 > 10)
            {
                Console.Write("Điểm số không hợp lệ! Vui lòng nhập lại: ");
            }
            Console.Write("Nhập số tín chỉ: ");
            int tinChi2;
            while (!int.TryParse(Console.ReadLine(), out tinChi2) || tinChi2 <= 0)
            {
                Console.Write("Tín Chỉ không hợp lệ! Vui lòng nhập lại: ");
            }
            Console.Write("Nhập điểm số môn Tiếng Anh (thang 10): ");
            double diem3;
            while (!double.TryParse(Console.ReadLine(), out diem3) || diem3 < 0 || diem3 > 10)
            {
                Console.Write("Điểm số không hợp lệ! Vui lòng nhập lại: ");
            }
            Console.Write("Nhập số tín chỉ: ");
            int tinChi3;
            while (!int.TryParse(Console.ReadLine(), out tinChi3) || tinChi3 <= 0)
            {
                Console.Write("Tín Chỉ không hợp lệ! Vui lòng nhập lại: ");
            }
            double scoreAvg = (diem1*tinChi1 + diem2*tinChi2 + diem3*tinChi3)/(tinChi1+tinChi2+tinChi3);
            string diemChu;
            string xepLoai;
            double gpaThang4;
            if (scoreAvg > 8.5)
            {
                diemChu = "A";
                gpaThang4 = 4.0;
                xepLoai = "Xuất Sắc/ Giỏi";
            }
            else if(scoreAvg > 7.0)
            {
                diemChu = "B";
                gpaThang4 = 3.0;
                xepLoai = "Khá";
            }
            else if (scoreAvg > 5.5)
            {
                diemChu="C";
                gpaThang4 = 2.0;
                xepLoai = "Trung Bình";
            }
            else if (scoreAvg > 4.0)
            {
                diemChu = "D";
                gpaThang4 = 1.0;
                xepLoai = "Yếu";
            }
            else
            {
                diemChu = "F";
                gpaThang4 = 0.0;
                xepLoai = "Kém (Trượt)";
            }
            Console.WriteLine($"Điểm TB thang 10: {scoreAvg:F2}");
            Console.WriteLine($"Điểm chữ quy đổi: {diemChu}");
            Console.WriteLine($"Điểm GPA thang 4: {gpaThang4}");
            Console.WriteLine($"Xếp loại học lực: {xepLoai}");
        }
        //static void Main(string[] args)
        //{
        //    Console.OutputEncoding = System.Text.Encoding.UTF8;
        //    Console.InputEncoding = System.Text.Encoding.UTF8;
        //    Bai5();
        //}

    }
}
