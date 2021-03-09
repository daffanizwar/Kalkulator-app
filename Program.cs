using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Program Calculator";

            menu();
            int selectMenu = SelectMenu();
            if (selectMenu < 1 || selectMenu > 4)
            {
                Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
                ExitProgram();
            }

            Console.WriteLine();
            int a = InputA();
            int b = InputB();

            Console.WriteLine();
            if (selectMenu == 1)
            {
                Console.WriteLine("Hasil penambahan {0] + {1} = {2}", a, b, Penambahan(a, b));
            }

            else if (selectMenu == 2)
            {
                Console.WriteLine("Hasil pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            }

            else if (selectMenu == 3)
            {
                Console.WriteLine("Hasil perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            }

            else if (selectMenu == 4)
            {
                Console.WriteLine("Hasil pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }

            ExitProgram();
        }

        static void menu()
        {
            Console.WriteLine("Pilih Menu Calculator : ");

            Console.WriteLine();
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
        }

        static int SelectMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Pilih 1-4");
            return int.Parse(Console.ReadLine());
        }

        static int InputA()
        {
            Console.Write("Inputkan nilai a : ");
            return int.Parse(Console.ReadLine());
        }

        static int InputB()
        {
            Console.Write("Inputkan nilai b : ");
            return int.Parse(Console.ReadLine());
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }

        static void ExitProgram()
        {
            Console.WriteLine();
            Console.WriteLine("Tekan sembarang key untuk berhenti");
            Console.ReadKey();
        }

    }
}
