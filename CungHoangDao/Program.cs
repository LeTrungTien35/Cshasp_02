using System;
using System.Collections.Generic;
using System.Text;

namespace CungHoangDao
{
    class Program
    {
        static void Main(string[] args)
        {
            String choice = "";
            do
            {     
                int day = 0;
                int month = 0;
                Console.WriteLine("Nhap ngay sinh: ");
                day = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Nhap thang sinh: ");
                month = Convert.ToInt32(Console.ReadLine());
                
                

                switch (month)
                {
                    case 1:
                        if(day > 20)
                        {
                            Console.WriteLine("ban la sieu nhan!");
                        }
                        break;
                }

                Console.WriteLine("Nhap Y de tiep tuc nhap N de thoat!");
                choice = Console.ReadLine();
                if (choice.ToLower() == "n")
                {
                    System.Environment.Exit(0);
                }

            } while (true);            
        }
    }
}
