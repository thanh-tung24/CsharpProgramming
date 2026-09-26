using System;
using System.Collections.Generic;

namespace Bai3_4
{
    public class ConsoleMenu
    {
        protected List<string> menuItems = new List<string>();

        public void AddItem(string item)
        {
            menuItems.Add(item);
        }

        public virtual void Display()
        {
            Console.WriteLine("\n========== MENU ==========");

            for (int i = 0; i < menuItems.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {menuItems[i]}");
            }

            Console.WriteLine("0. Thoát chương trình");
            Console.Write("Thực hiện: ");
        }

        public virtual void Run()
        {
            int choice;

            do
            {
                Display();

                // Sửa int.Parse() thành int.TryParse()
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    choice = -1;
                    Console.WriteLine("Vui lòng nhập số!");
                    continue;
                }

                if (choice > 0 && choice <= menuItems.Count)
                {
                    Console.WriteLine($"Bạn thực hiện chức năng {choice}");
                    OnExecute(choice);
                }
                else if (choice != 0)
                {
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                }

            } while (choice != 0);
        }

        protected virtual void OnExecute(int choice)
        {
        }
    }

    // Kế thừa ConsoleMenu để giải phương trình bậc 2
    public class PTBac2Console : ConsoleMenu
    {
        private double a, b, c;

        public PTBac2Console()
        {
            AddItem("Nhập hệ số a, b, c");
            AddItem("Giải phương trình bậc 2");
        }

        protected override void OnExecute(int choice)
        {
            switch (choice)
            {
                case 1:
                    NhapHeSo();
                    break;

                case 2:
                    GiaiPT();
                    break;
            }
        }

        private void NhapHeSo()
        {
            Console.Write("Nhập a: ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.Write("a không hợp lệ. Nhập lại a: ");
            }

            Console.Write("Nhập b: ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.Write("b không hợp lệ. Nhập lại b: ");
            }

            Console.Write("Nhập c: ");
            while (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.Write("c không hợp lệ. Nhập lại c: ");
            }
        }

        private void GiaiPT()
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phương trình có vô số nghiệm.");
                    }
                    else
                    {
                        Console.WriteLine("Phương trình vô nghiệm.");
                    }
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine($"Phương trình bậc nhất có nghiệm x = {x}");
                }

                return;
            }

            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("Phương trình vô nghiệm thực.");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Phương trình có nghiệm kép x = {x}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine(
                    $"Phương trình có 2 nghiệm phân biệt: x1 = {x1}, x2 = {x2}"
                );
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            PTBac2Console app = new PTBac2Console();

            app.Run();
        }
    }
}