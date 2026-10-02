using System;

namespace Bai1_5
{
    public class DonThuc
    {
        private double a; // Hệ số
        private int n;    // Số mũ không âm

        public double A { get => a; set => a = value; }
        public int N
        {
            get => n;
            set
            {
                if (value < 0) throw new ArgumentException("Số mũ n phải không âm.");
                n = value;
            }
        }

        public DonThuc() { a = 0; n = 0; }
        public DonThuc(double a, int n)
        {
            this.a = a;
            this.n = (n >= 0) ? n : 0;
        }

        public void Input()
        {
            Console.Write("Nhập hệ số a: ");
            a = double.Parse(Console.ReadLine());
            do
            {
                Console.Write("Nhập số mũ n (n >= 0): ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);
        }

        public void Output() => Console.WriteLine(ToString());

        public override string ToString()
        {
            if (n == 0) return $"{a}";
            if (n == 1) return $"{a}x";
            return $"{a}x^{n}";
        }

        // (a) Tính giá trị đơn thức P(x) = a * x^n
        public double TinhGiaTri(double x) => a * Math.Pow(x, n);

        // (b) Tính đạo hàm P'(x) = a * n * x^(n - 1)
        public DonThuc DaoHam()
        {
            if (n == 0) return new DonThuc(0, 0);
            return new DonThuc(a * n, n - 1);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            DonThuc dt = new DonThuc();
            dt.Input();

            Console.WriteLine($"Đơn thức vừa nhập: P(x) = {dt}");

            Console.Write("Nhập giá trị x để tính: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine($"P({x}) = {dt.TinhGiaTri(x)}");

            DonThuc dh = dt.DaoHam();
            Console.WriteLine($"Đạo hàm Q(x) = P'(x) = {dh}");
        }
    }
}
