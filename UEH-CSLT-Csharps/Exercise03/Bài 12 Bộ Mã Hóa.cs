using System;
using System.Collections.Generic;
using System.Text;

namespace UEH_CSLT_Csharps.Exercise03
{
    internal class Bài_12_Bộ_Mã_Hóa
    {
        static void Bai12()
        {
            Console.Write("Văn bản gốc: ");
            string vanban = Console.ReadLine();
            Console.Write("Khóa dịch chuyển (Shift Key k): ");
            int k = int.Parse(Console.ReadLine());

            char[] maHoa = vanban.ToCharArray();
            for (int i = 0; i < maHoa.Length; i++)
            {
                if (maHoa[i] >= 'A' && maHoa[i] <= 'Z')
                {
                    maHoa[i] = (char)('A' + (maHoa[i] - 'A' + k) % 26);
                }
                else if (maHoa[i] >= 'a' && maHoa[i] <= 'z')
                {
                    maHoa[i] = (char)('a' + (maHoa[i] - 'a' + k) % 26);
                }
            }
            string textMaHoa = new string(maHoa);

            char[] giaiMa = textMaHoa.ToCharArray();
            for (int i = 0; i < giaiMa.Length; i++)
            {
                if (giaiMa[i] >= 'A' && giaiMa[i] <= 'Z')
                {
                    giaiMa[i] = (char)('A' + (giaiMa[i] - 'A' - k + 26) % 26);
                }
                else if (giaiMa[i] >= 'a' && giaiMa[i] <= 'z')
                {
                    giaiMa[i] = (char)('a' + (giaiMa[i] - 'a' - k + 26) % 26);
                }
            }
            string textGiaiMa = new string(giaiMa);

            Console.WriteLine($"Văn bản Mã hóa: {textMaHoa}");
            Console.WriteLine($"Văn bản Giải mã: {textGiaiMa}");
        }
        //static void Main(string[] args)
        //{
        //    Console.OutputEncoding = System.Text.Encoding.UTF8;
        //    Console.InputEncoding = System.Text.Encoding.UTF8;
        //    Bai12();
        //}
    }
}
