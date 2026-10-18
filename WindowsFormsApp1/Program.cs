using System;
using System.Windows.Forms;
using BaiNangCao; // Thêm dòng này để Program.cs tìm thấy Form1

namespace BaiNangCao
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}