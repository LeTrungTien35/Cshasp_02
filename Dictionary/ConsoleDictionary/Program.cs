using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.InteropServices;

namespace TuDien
{
    class Program
    {
        #region --- DllImport -> Gọi các hàm hệ thống để Set Console Unicode I/O ---
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleOutputCP(uint wCodePageID);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleCP(uint wCodePageID);


        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll")]
        static extern bool ReadConsoleW(IntPtr hConsoleInput,
                                        [Out] byte[] lpBuffer,
                                        uint nNumberOfCharsToRead,
                                        out uint lpNumberOfCharsRead,
                                        IntPtr lpReserved);

        public static IntPtr GetWin32InputHandle()
        {
            const int STD_INPUT_HANDLE = -10;
            IntPtr inHandle = GetStdHandle(STD_INPUT_HANDLE);
            return inHandle;
        }

        public static string ConsoleReadLine()
        {
            const int bufferSize = 1024;
            var buffer = new byte[bufferSize];

            uint charsRead = 0;

            ReadConsoleW(GetWin32InputHandle(), buffer, bufferSize, out charsRead, (IntPtr)0);
            // -2 to remove ending \n\r
            int nc = ((int)charsRead - 2) * 2;
            var b = new byte[nc];
            for (var i = 0; i < nc; i++)
                b[i] = buffer[i];

            var utf8enc = Encoding.UTF8;
            var unicodeenc = Encoding.Unicode;
            return utf8enc.GetString(Encoding.Convert(unicodeenc, utf8enc, b));
        }
        #endregion

        static int menu()
        {
            int choice = -1;
            List<string> myMenu = new List<string>(){
                "Menu app Từ điển Anh-Việt",
                " 0: Đọc các từ trong file vào từ điển (auto)",
                " 1: Liệt hết các từ trong từ điển",
                " 2: Tra cứu 1 từ",
                " 3: Cập nhật 1 từ",
                " 4: Xóa 1 từ",
                " 5: Cập nhật từ điển vào file",
                " 6: Giới thiệu về tác giả",
                " 7: Thoát chương trình"
            };
            do
            {
                foreach (string item in myMenu)
                {
                    Console.WriteLine(item);
                }
                Console.Write("Hãy chọn 1 số trong menu: ");
                int.TryParse(Console.ReadLine(), out choice);
                if (choice == -1) Console.WriteLine("Hãy nhập số từ 0..7");
            } while (!(choice >= 0 && choice <= 7));
            return choice;
        }
        static void Main(string[] args)
        {
            //chuyển code page sang 65001 để hiển thị UNICODE trên Console
            SetConsoleOutputCP(65001);
            SetConsoleCP(65001);

            Console.Title = "Từ điển Anh-Việt . Code bởi: Đỗ Duy Cốp";

            LibDictionary.DicEnVi myDic = new LibDictionary.DicEnVi(@"d:\my documents\visual studio 2013\Projects\Dictionary\Dictionary\bin\Debug\Anh-Viet.txt");
            myDic.LoadDic(); //auto

            int choice;
            do
            {
                choice = menu();
                switch (choice)
                {
                    case 0:
                        myDic.LoadDic();
                        Console.WriteLine("Đã load được {0} từ trong file vào từ điển",myDic.Count);
                        break;
                    case 1:
                        List<string> listAll = myDic.AllWord();
                        Console.WriteLine("Danh sách toàn bộ các từ trong từ điển: ");
                        for (int i = 0; i < listAll.Count; i++)
                        {
                            Console.WriteLine(string.Format(" {0}. {1}", i + 1, listAll[i]));
                        }
                        break;
                    case 2:
                        Console.Write("Nhập từ cần tra cứu: ");
                        string en = ConsoleReadLine();
                        string vi = myDic.Search(en);
                        if (vi != null)
                            Console.WriteLine("Kết quả tra cứu:\r\n{0}: {1}", en, vi);
                        else
                            Console.WriteLine("Kết quả tra cứu: Không tìm thấy nghĩa của {0}", en);
                        break;
                    case 3:
                        Console.Write("Nhập từ cần sửa: ");
                        string oldEn = ConsoleReadLine();
                        Console.Write("Nhập nghĩa mới: ");
                        string newVi = ConsoleReadLine();
                        string oldVi = myDic.Search(oldEn);
                        bool okUpdate = myDic.UpdateDic(oldEn, newVi);
                        if (okUpdate)
                            Console.WriteLine(string.Format("Kết quả: Đã cập nhật từ điển.\r\nTừ cũ: {0} => {1}\r\nCập nhật: {0} => {2}", oldEn, oldVi, newVi));
                        else
                            Console.WriteLine(string.Format("Kết quả cập nhật: Từ '{0}' không có trong từ điển.", oldEn));
                        break;
                    case 4:
                        Console.Write("Nhập từ cần xóa: ");
                        string enDelete = ConsoleReadLine();
                        bool okDelete = myDic.DeleteDic(enDelete);
                        if (okDelete)
                            Console.WriteLine("Kết quả: Đã xóa từ khỏi từ điển");
                        else
                            Console.WriteLine(string.Format("Kết quả: Từ '{0}' không có trong từ điển.", enDelete));
                        break;
                    case 5:
                        try
                        {
                            if (myDic.SaveDic())
                                Console.WriteLine("Đã cập nhật từ điển");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Có lỗi trong khi cập nhật từ điển: {0}", ex.Message);
                        }
                        break;
                    case 6:
                        Console.WriteLine("Tác giả: Đỗ Duy Cốp\r\nĐiện thoại: 0986.516.375\r\nEmail: duyco@tnut.edu.vn");
                        break;
                    case 7:
                        Console.Write("Bye! bấm phím bất kỳ để kết thúc!");
                        break;
                }
                Console.WriteLine();
            } while (choice != 7);
            Console.ReadKey(true);
        }
    }
}
