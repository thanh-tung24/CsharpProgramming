using System;
using System.Collections.Generic;

namespace Bai3_4
{
    // =========================================================================
    // 1. LỚP CƠ SỞ (Base Class): ConsoleMenu - Quản lý khung Menu dòng lệnh
    // =========================================================================
    public class ConsoleMenu
    {
        // Danh sách lưu trữ nhãn các mục chức năng trong menu
        // Dùng phạm vi truy cập protected để lớp con có thể kế thừa và mở rộng
        protected List<string> menuItems = new List<string>();

        // Phương thức hỗ trợ thêm một tùy chọn mới vào menu
        public void AddItem(string item)
        {
            menuItems.Add(item);
        }

        // Phương thức ảo hiển thị danh sách chức năng ra màn hình Console
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

        // Vòng lặp điều hướng menu chính: nhận thao tác người dùng và kiểm soát luồng
        public virtual void Run()
        {
            int choice;

            do
            {
                Display();

                // Sử dụng int.TryParse() chống crash ứng dụng khi nhập chuỗi ký tự bất hợp lệ
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    choice = -1;
                    Console.WriteLine("Vui lòng nhập số!");
                    continue;
                }

                // Kiểm tra phạm vi hợp lệ của các chức năng đang có
                if (choice > 0 && choice <= menuItems.Count)
                {
                    Console.WriteLine($"Bạn thực hiện chức năng {choice}");
                    OnExecute(choice); // Gọi hàm nghiệp vụ thực thi ứng với lựa chọn
                }
                else if (choice != 0)
                {
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                }

            } while (choice != 0); // Nhập 0 sẽ thoát chương trình
        }

        // Phương thức ảo rỗng: Đóng vai trò Hook Method để lớp con ghi đè hành vi nghiệp vụ
        protected virtual void OnExecute(int choice)
        {
        }
    }

    // =========================================================================
    // 2. LỚP DẪN XUẤT (Derived Class): PTBac2Console kế thừa từ ConsoleMenu
    // =========================================================================
    public class PTBac2Console : ConsoleMenu
    {
        // Các hệ số của phương trình bậc hai: a*x^2 + b*x + c = 0
        private double a, b, c;

        // Constructor: Khởi tạo sẵn danh sách chức năng nghiệp vụ của bài toán
        public PTBac2Console()
        {
            AddItem("Nhập hệ số a, b, c");
            AddItem("Giải phương trình bậc 2");
        }

        // Ghi đè phương thức OnExecute để kích hoạt đúng chức năng được chọn
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

        // Phương thức nhập liệu: Có vòng lặp bắt lỗi định dạng số thực cho từng hệ số
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

        // Phương thức nghiệp vụ: Biện luận và giải phương trình a*x^2 + b*x + c = 0
        private void GiaiPT()
        {
            // Trường hợp 1: Suy biến thành phương trình bậc nhất (a == 0)
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

            // Trường hợp 2: Phương trình bậc hai đầy đủ (a != 0)
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

    // =========================================================================
    // 3. CHƯƠNG TRÌNH CHÍNH (Program Execution)
    // =========================================================================
    internal class Program
    {
        static void Main(string[] args)
        {
            // Thiết lập bảng mã UTF-8 để hiển thị tiếng Việt trên Console không lỗi font
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khởi tạo đối tượng ứng dụng giải phương trình và khởi chạy menu
            PTBac2Console app = new PTBac2Console();
            app.Run();
        }
    }
}
