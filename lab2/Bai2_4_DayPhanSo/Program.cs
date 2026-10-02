using System;
using System.Collections.Generic;

namespace Bai2_4_DayPhanSo
{
    public class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }

        public PhanSo(int tu = 0, int mau = 1)
        {
            TuSo = tu;
            MauSo = (mau == 0) ? 1 : mau;
            RutGon();
        }

        private int USCLN(int a, int b)
        {
            a = Math.Abs(a); b = Math.Abs(b);
            while (b != 0) { int r = a % b; a = b; b = r; }
            return a == 0 ? 1 : a;
        }

        public void RutGon()
        {
            int u = USCLN(TuSo, MauSo);
            TuSo /= u; MauSo /= u;
            if (MauSo < 0) { TuSo = -TuSo; MauSo = -MauSo; }
        }

        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.TuSo * b.MauSo + b.TuSo * a.MauSo, a.MauSo * b.MauSo);
        }

        public override string ToString() => MauSo == 1 ? $"{TuSo}" : $"{TuSo}/{MauSo}";
    }

    public class DayPhanSo
    {
        private List<PhanSo> danhSach;

        public DayPhanSo() { danhSach = new List<PhanSo>(); }

        public void Nhap()
        {
            Console.Write("Nhập số lượng phân số n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Phân số thứ {i + 1}:");
                Console.Write("  Tử số: "); int tu = int.Parse(Console.ReadLine());
                Console.Write("  Mẫu số: "); int mau = int.Parse(Console.ReadLine());
                danhSach.Add(new PhanSo(tu, mau));
            }
        }

        public PhanSo TinhTong()
        {
            PhanSo tong = new PhanSo(0, 1);
            foreach (var ps in danhSach)
            {
                tong = tong + ps;
            }
            return tong;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            DayPhanSo dps = new DayPhanSo();
            dps.Nhap();
            Console.WriteLine($"Tổng n phân số = {dps.TinhTong()}");
        }
    }
}
