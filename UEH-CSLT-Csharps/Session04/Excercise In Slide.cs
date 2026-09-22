//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace UEH_CSLT_Csharps.Session04
//{
//    internal class Excercise_In_Slide
//    {
//        static void Bai1()
//        {
//            Console.WriteLine("BÀI 1: KIỂM TRA LOẠI TAM GIÁC ");
//            Console.Write("Nhập cạnh a: ");
//            double a = double.Parse(Console.ReadLine());
//            Console.Write("Nhập cạnh b: ");
//            double b = double.Parse(Console.ReadLine());
//            Console.Write("Nhập cạnh c: ");
//            double c = double.Parse(Console.ReadLine());
//            if (a + b <= c || a + c <= b || b + c <= a)
//            {
//                Console.WriteLine("Ba cạnh không tạo thành tam giác hợp lệ!");
//            }
//            else if (a == b && b == c)
//            {
//                Console.WriteLine("Đây là tam giác Đều (Equilateral).");
//            }
//            else if (a == b || b == c || a == c)
//            {
//                Console.WriteLine("Đây là tam giác Cân (Isosceles).");
//            }
//            else
//            {
//                Console.WriteLine("Đây là tam giác Thường (Scalene).");
//            }
//        }
//        static void Bai2()
//        {
//            Console.WriteLine("--- BÀI 2: TÍNH TỔNG VÀ TRUNG BÌNH 10 SỐ ---");
//            double tongSo = 0;
//            for (int i = 1; i <= 10; i++)
//            {
//                Console.Write($"Nhập số thứ {i}: ");
//                double so = double.Parse(Console.ReadLine());
//                tongSo = tongSo + so;
//            }
//            double trungBinh = tongSo / 10;

//            Console.WriteLine($"Tổng 10 số: {tongSo}");
//            Console.WriteLine($"Trung bình: {trungBinh}");
//        }
//        static void Bai3()
//        {
//            Console.WriteLine("--- BÀI 3: BẢNG CỬU CHƯƠNG ---");
//            Console.Write("Nhập số cần in bảng cửu chương: ");
//            int n = int.Parse(Console.ReadLine());
//            for (int i = 1; i <= 10; i++)
//            {
//                Console.WriteLine($"{n} x {i} = {n * i}");
//            }
//        }
//        static void Bai4()
//        {
//            Console.WriteLine("--- BÀI 4: MẪU HÌNH TAM GIÁC SỐ ---");
//            Console.Write("Nhập số hàng: ");
//            int soHang = int.Parse(Console.ReadLine());

//            for (int hang = 1; hang <= soHang; hang++)
//            {
//                string dong = "";
//                for (int so = 1; so <= hang; so++)
//                {
//                    dong = dong + so;
//                }
//                Console.WriteLine(dong);
//            }
//        }
//        static void Bai5()
//        {
//            Console.WriteLine("--- BÀI 5: MẪU HÌNH SỐ LIÊN TỤC ---");
//            Console.Write("Nhập số hàng: ");
//            int soHang = int.Parse(Console.ReadLine());

//            int soHienTai = 1;

//            for (int hang = 1; hang <= soHang; hang++)
//            {
//                string dong = "";
//                for (int cot = 1; cot <= hang; cot++)
//                {
//                    dong = dong + soHienTai;
//                    if (cot < hang)
//                    {
//                        dong = dong + " ";
//                    }
//                    soHienTai = soHienTai + 1;
//                }
//                Console.WriteLine(dong);
//            }
//        }
//        static void Bai6()
//        {
//            Console.WriteLine("--- BÀI 6: CHUỖI HARMONIC ---");
//            Console.Write("Nhập số hạng n: ");
//            int n = int.Parse(Console.ReadLine());
//            double tong = 0;
//            for (int i = 1; i <= n; i++)
//            {
//                double soHang = 1.0 / i;
//                tong = tong + soHang;
//                if (i == 1)
//                {
//                    Console.Write($"1");
//                }
//                else
//                {
//                    Console.Write($" + 1/{i}");
//                }
//            }
//            Console.WriteLine();
//            Console.WriteLine($"Tổng {n} số hạng: {tong}");
//        }
//        static void Bai7()
//        {
//            Console.WriteLine("--- BÀI 7: TÌM SỐ HOÀN HẢO TRONG KHOẢNG ---");
//            Console.Write("Nhập số bắt đầu: ");
//            int batDau = int.Parse(Console.ReadLine());
//            Console.Write("Nhập số kết thúc: ");
//            int ketThuc = int.Parse(Console.ReadLine());
//            Console.WriteLine("Các số hoàn hảo trong khoảng:");
//            bool coSoHoanHao = false;
//            for (int soCanKiemTra = batDau; soCanKiemTra <= ketThuc; soCanKiemTra++)
//            {
//                if (soCanKiemTra < 1)
//                {
//                    continue;
//                }
//                int tongUocSo = 0;
//                for (int uoc = 1; uoc < soCanKiemTra; uoc++)
//                {
//                    if (soCanKiemTra % uoc == 0)
//                    {
//                        tongUocSo = tongUocSo + uoc;
//                    }
//                }
//                if (tongUocSo == soCanKiemTra)
//                {
//                    Console.WriteLine(soCanKiemTra);
//                    coSoHoanHao = true;
//                }
//            }
//            if (!coSoHoanHao)
//            {
//                Console.WriteLine("Không có số hoàn hảo nào trong khoảng này.");
//            }
//        }
//        static void Bai8()
//        {
//            Console.WriteLine("--- BÀI 8: KIỂM TRA SỐ NGUYÊN TỐ ---");
//            Console.Write("Nhập số cần kiểm tra: ");
//            int n = int.Parse(Console.ReadLine());
//            if (n < 2)
//            {
//                Console.WriteLine($"{n} không phải là số nguyên tố.");
//                return;
//            }
//            bool laSoNguyenTo = true;
//            for (int i = 2; i <= n / 2; i++)
//            {
//                if (n % i == 0)
//                {
//                    laSoNguyenTo = false;
//                    break;
//                }
//            }
//            if (laSoNguyenTo)
//            {
//                Console.WriteLine($"{n} là số nguyên tố.");
//            }
//            else
//            {
//                Console.WriteLine($"{n} không phải là số nguyên tố.");
//            }
//        }
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            Console.InputEncoding = System.Text.Encoding.UTF8;
//            int luaChon;
//            while (true)
//            {
//                Console.WriteLine();
//                Console.WriteLine("===== CHỌN BÀI TẬP MUỐN CHẠY =====");
//                Console.WriteLine("1. Kiểm tra loại tam giác");
//                Console.WriteLine("2. Tính tổng và trung bình 10 số");
//                Console.WriteLine("3. Bảng cửu chương");
//                Console.WriteLine("4. Mẫu hình tam giác số");
//                Console.WriteLine("5. Mẫu hình số liên tục");
//                Console.WriteLine("6. Chuỗi Harmonic");
//                Console.WriteLine("7. Tìm số hoàn hảo trong khoảng");
//                Console.WriteLine("8. Kiểm tra số nguyên tố");
//                Console.WriteLine("0. Thoát chương trình");
//                Console.Write("Lựa chọn của bạn: ");
//                if (!int.TryParse(Console.ReadLine(), out luaChon))
//                {
//                    Console.WriteLine("Vui lòng nhập số hợp lệ!");
//                    continue;
//                }
//                Console.WriteLine();
//                switch (luaChon)
//                {
//                    case 1:
//                        Bai1();
//                        break;
//                    case 2:
//                        Bai2();
//                        break;
//                    case 3:
//                        Bai3();
//                        break;
//                    case 4:
//                        Bai4();
//                        break;
//                    case 5:
//                        Bai5();
//                        break;
//                    case 6:
//                        Bai6();
//                        break;
//                    case 7:
//                        Bai7();
//                        break;
//                    case 8:
//                        Bai8();
//                        break;
//                    case 0:
//                        Console.WriteLine("Đã thoát chương trình.");
//                        return;
//                    default:
//                        Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng chọn từ 0-8.");
//                        break;
//                }
//            }
//        }
//    }
//}
