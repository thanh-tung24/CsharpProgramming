using System;

namespace Bai2_3_DaThuc
{
    public class DaThuc
    {
        private double[] heSo; // heSo[i] là hệ số của x^i
        private int n;         // Bậc của đa thức

        public DaThuc() { n = 0; heSo = new double[1]; }
        public DaThuc(int n)
        {
            this.n = n;
            heSo = new double[n + 1];
        }

        // Indexer truy cập hệ số của x^i
        public double this[int i]
        {
            get => heSo[i];
            set => heSo[i] = value;
        }

        public void Nhap()
        {
            Console.Write("Nhập bậc đa thức n: ");
            n = int.Parse(Console.ReadLine());
            heSo = new double[n + 1];
            for (int i = 0; i <= n; i++)
            {
                Console.Write($"Nhập hệ số cho x^{i} (a_{i}): ");
                heSo[i] = double.Parse(Console.ReadLine());
            }
        }

        public void Xuat()
        {
            Console.Write("P(x) = ");
            for (int i = 0; i <= n; i++)
            {
                if (i == 0) Console.Write($"{heSo[i]}");
                else if (i == 1) Console.Write($" + {heSo[i]}x");
                else Console.Write($" + {heSo[i]}x^{i}");
            }
            Console.WriteLine();
        }

        public double TinhGiaTri(double x)
        {
            double sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += heSo[i] * Math.Pow(x, i);
            }
            return sum;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            DaThuc dt = new DaThuc();
            dt.Nhap();
            dt.Xuat();

            Console.Write("Nhập x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine($"Giá trị P({x}) = {dt.TinhGiaTri(x)}");
        }
    }
}