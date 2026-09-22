//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace UEH_CSLT_Csharps.Session04
//{
//    internal class BaiTap5LMS
//    {
//        static long game01() //Làm lại game xí ngầu
//        {
//            Console.WriteLine("Chào mừng đến với game xí ngầu!");
//            long tien = 1_000_000;
//            int Solanchoi = 0;
//            int SolanThua = 0;
//            int SolanThangDacBiet = 0;
//            bool continueplaying = true;
//            do
//            {
//                Solanchoi++;
//                Console.Write($"Bạn có {tien} đồng. Bạn muốn đặt cược bao nhiêu? ");
//                long tiendatcuoc = 0;
//                do
//                {
//                    bool ok = long.TryParse(Console.ReadLine(), out long result);
//                    if (ok && result <= tien && result > 1000)
//                    {
//                        tiendatcuoc = result;
//                        break;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Số tiền không hợp lệ!" + $" Vui lòng nhập số tiền đặt cược không vượt quá số tiền hiện có {tien} ");
//                        Console.Write("Bạn đặt bao nhiêu?");
//                    }
//                }
//                while (true);
//                Random rand = new Random();
//                int dice1 = rand.Next(1, 7);
//                int dice2 = rand.Next(1, 7);
//                int sum = dice1 + dice2;
//                string guess;
//                do
//                {
//                    Console.Write("Bạn đoán tài (T), xỉu (X) hay lục (L)?");
//                    guess = Console.ReadLine().ToLower();
//                    if (guess != "t" && guess != "x" && guess != "l")
//                    {
//                        Console.WriteLine("Vui lòng nhập T, X hoặc L.");
//                    }
//                    else
//                    {
//                        break;
//                    }
//                }
//                while (true);
//                bool isWin = false;
//                bool isWinSpecial = false;
//                if (guess == "t" && sum > 6)
//                {
//                    isWin = true;
//                }
//                else if (guess == "x" && sum < 6)
//                {
//                    isWin = true;
//                }
//                else if (guess == "l" && sum == 6)
//                {
//                    isWin = true;
//                    isWinSpecial = true;
//                }
//                Console.WriteLine($"Kết quả gieo súc sắc: {dice1} + {dice2} = {sum}");
//                if (isWin)
//                {
//                    if (isWinSpecial)
//                    {
//                        SolanThangDacBiet++;
//                        tien += tiendatcuoc * 3;
//                        Console.WriteLine($"Bạn đã trúng giải đặc biệt! Tổng số tiền hiện tại: {tien} đồng");
//                    }
//                    else
//                    {
//                        tien += tiendatcuoc;
//                        Console.WriteLine($"Bạn đã thắng! Tổng số tiền hiện tại: {tien} đồng.");
//                    }
//                }
//                else
//                {
//                    tien -= tiendatcuoc;
//                    SolanThua++;
//                    Console.WriteLine($"Bạn thua! Tổng số tiền hiện tại: {tien} đồng");
//                }
//                Console.Write("\nBạn có muốn chơi tiếp không? (C/K): ");
//                string input = Console.ReadLine() ?? "";
//                if (input.ToLower() == "k")
//                {
//                    continueplaying = false;
//                }
//            }
//            while (continueplaying);
//            Console.WriteLine($"\n Trò chơi kết thúc!");
//            Console.WriteLine($"\n Tổng số lần chơi: {Solanchoi}");
//            Console.WriteLine($"Tổng số lần thắng: {Solanchoi - SolanThua - SolanThangDacBiet}");
//            Console.WriteLine($"Tổng số lần thua: {SolanThua}");
//            Console.WriteLine($"Tổng số lần thắng đặc biệt: {SolanThangDacBiet}");
//            return tien;
//        }


//        public static long game02()
//        {
//            long tien = 1_000_000;
//            int soLanChoi = 0;
//            int soLanThua = 0;
//            int soLanThang = 0;
//            bool continuePlaying = true;

//            do
//            {
//                if (tien <= 0)
//                {
//                    Console.WriteLine("\nBạn đã hết tiền! Trò chơi kết thúc.");
//                    break;
//                }

//                soLanChoi++;
//                Console.WriteLine($"\n GAME ĐOÁN SỐ - LẦN CHƠI THỨ {soLanChoi} ");
//                Console.Write($"Bạn đang có {tien} đồng. Bạn muốn đặt cược bao nhiêu? ");

//                long tienDatCuoc = 0;
//                do
//                {
//                    bool ok = long.TryParse(Console.ReadLine(), out long result);
//                    if (ok && result <= tien && result >= 1000)
//                    {
//                        tienDatCuoc = result;
//                        break;
//                    }
//                    else
//                    {
//                        Console.WriteLine($"Số tiền không hợp lệ! Nhập số từ 1000 đồng và không vượt quá {tien} đồng.");
//                        Console.Write("Bạn đặt bao nhiêu? ");
//                    }
//                } while (true);

//                Console.WriteLine("\nChọn độ khó:");
//                Console.WriteLine("1. Dễ (9 lần đoán) - Thưởng 0.5 lần tiền cược");
//                Console.WriteLine("2. Trung bình (6 lần đoán) - Thưởng 1.0 lần tiền cược");
//                Console.WriteLine("3. Khó (4 lần đoán) - Thưởng 3.0 lần tiền cược");

//                int maxLuotDoan = 0;
//                double tyLeThuong = 0;

//                do
//                {
//                    Console.Write("Mời bạn chọn mức độ (1-3): ");
//                    string chonLevel = Console.ReadLine() ?? "";
//                    if (chonLevel == "1")
//                    {
//                        maxLuotDoan = 9;
//                        tyLeThuong = 0.5;
//                        break;
//                    }
//                    else if (chonLevel == "2")
//                    {
//                        maxLuotDoan = 6;
//                        tyLeThuong = 1.0;
//                        break;
//                    }
//                    else if (chonLevel == "3")
//                    {
//                        maxLuotDoan = 4;
//                        tyLeThuong = 3.0;
//                        break;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn 1, 2 hoặc 3.");
//                    }
//                } while (true);

//                Random rand = new Random();
//                int soBiMat = rand.Next(1, 101);
//                int soLuotConLai = maxLuotDoan;
//                bool isWin = false;

//                Console.WriteLine($"\nMáy đã nghĩ ra 1 số từ 1 đến 100. Bạn có {maxLuotDoan} lượt để đoán!");

//                do
//                {
//                    Console.Write($"[Còn {soLuotConLai} lượt] Nhập số bạn đoán: ");
//                    bool ok = int.TryParse(Console.ReadLine(), out int guess);

//                    if (!ok || guess < 1 || guess > 100)
//                    {
//                        Console.WriteLine("Vui lòng nhập một số nguyên hợp lệ từ 1 đến 100!");
//                        continue;
//                    }

//                    if (guess == soBiMat)
//                    {
//                        isWin = true;
//                        break;
//                    }
//                    else if (guess < soBiMat)
//                    {
//                        Console.WriteLine("--> Số của máy LỚN HƠN số bạn đoán.");
//                    }
//                    else
//                    {
//                        Console.WriteLine("--> Số của máy NHỎ HƠN số bạn đoán.");
//                    }

//                    soLuotConLai--;

//                } while (soLuotConLai > 0);

//                if (isWin)
//                {
//                    soLanThang++;
//                    long tienThuong = (long)(tienDatCuoc * tyLeThuong);
//                    tien += tienThuong;
//                    Console.WriteLine($"\nCHÚC MỪNG! Bạn đã đoán đúng số {soBiMat}!");
//                    Console.WriteLine($"Bạn thắng +{tienThuong} đồng. Tổng tiền hiện tại: {tien} đồng.");
//                }
//                else
//                {
//                    soLanThua++;
//                    tien -= tienDatCuoc;
//                    Console.WriteLine($"\nBẠN ĐÃ THUA! Bạn đã hết lượt đoán. Số đúng là: {soBiMat}");
//                    Console.WriteLine($"Bạn bị trừ -{tienDatCuoc} đồng. Tổng tiền hiện tại: {tien} đồng.");
//                }

//                if (tien > 0)
//                {
//                    Console.Write("\nBạn có muốn chơi tiếp game đoán số không? (C/K): ");
//                    string input = Console.ReadLine() ?? "";
//                    if (input.ToLower() == "k")
//                    {
//                        continuePlaying = false;
//                    }
//                }

//            } while (continuePlaying);

//            Console.WriteLine("\n=================================");
//            Console.WriteLine("KẾT THÚC GAME ĐOÁN SỐ!");
//            Console.WriteLine($"Tổng số lần chơi: {soLanChoi}");
//            Console.WriteLine($"Tổng số lần thắng: {soLanThang}");
//            Console.WriteLine($"Tổng số lần thua: {soLanThua}");
//            Console.WriteLine($"Số tiền còn lại: {tien} đồng.");
//            Console.WriteLine("=================================");

//            return tien;
//        }
//        public static void Bai6()
//        {
//            Console.WriteLine("\n BÀI 6: CHUỖI HARMONIC ");
//            Console.Write("Nhập số n: ");

//            int n = 0;
//            do
//            {
//                bool ok = int.TryParse(Console.ReadLine(), out n);
//                if (ok && n > 0)
//                {
//                    break;
//                }
//                Console.Write("Vui lòng nhập n là số nguyên dương: ");
//            } while (true);

//            double sum = 0;
//            Console.Write("Chuỗi Harmonic: ");

//            for (int i = 1; i <= n; i++)
//            {
//                sum += 1.0 / i;
//                if (i == 1)
//                {
//                    Console.Write("1 ");
//                }
//                else
//                {
//                    Console.Write($"+ 1/{i} ");
//                }
//            }

//            Console.WriteLine($"\nTổng chuỗi Harmonic {n} số hạng là: {sum:F4}");
//        }

//        public static void Bai7()
//        {
//            Console.WriteLine("\nBÀI 7: TÌM SỐ HOÀN HẢO (PERFECT NUMBER) Trong KHOẢNG ");

//            int tu = 0;
//            Console.Write("Nhập khoảng từ (số bắt đầu): ");
//            do
//            {
//                bool ok = int.TryParse(Console.ReadLine(), out tu);
//                if (ok && tu > 0)
//                {
//                    break;
//                }
//                Console.Write("Vui lòng nhập số nguyên dương: ");
//            } while (true);

//            int den = 0;
//            Console.Write("Nhập đến (số kết thúc): ");
//            do
//            {
//                bool ok = int.TryParse(Console.ReadLine(), out den);
//                if (ok && den >= tu)
//                {
//                    break;
//                }
//                Console.Write($"Vui lòng nhập số nguyên lớn hơn hoặc bằng {tu}: ");
//            } while (true);

//            Console.WriteLine($"Các số hoàn hảo trong khoảng từ {tu} đến {den} là:");
//            bool timThay = false;

//            for (int num = tu; num <= den; num++)
//            {
//                int tongUoc = 0;
//                for (int i = 1; i <= num / 2; i++)
//                {
//                    if (num % i == 0)
//                    {
//                        tongUoc += i;
//                    }
//                }

//                if (tongUoc == num && num != 0)
//                {
//                    Console.Write($"{num} ");
//                    timThay = true;
//                }
//            }

//            if (!timThay)
//            {
//                Console.WriteLine("Không tìm thấy số hoàn hảo nào.");
//            }
//            else
//            {
//                Console.WriteLine();
//            }
//        }
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            game01();
//            game02();
//            Bai6();
//            Bai7();
//        }
//    }
//}
