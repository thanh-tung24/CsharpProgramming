using System;
using System.Collections;

namespace Bai2_1
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x = 0, double y = 0) { X = x; Y = y; }
        public override string ToString() => $"({X}, {Y})";
    }

    public class ArrayPoint
    {
        private ArrayList points;

        public ArrayPoint() { points = new ArrayList(); }

        public void Add(Point p) => points.Add(p);
        public int Count => points.Count;

        // Indexer cho phép truy cập Point thứ i
        public Point this[int index]
        {
            get
            {
                if (index < 0 || index >= points.Count) throw new IndexOutOfRangeException("Chỉ số nằm ngoài giới hạn.");
                return (Point)points[index];
            }
            set
            {
                if (index < 0 || index >= points.Count) throw new IndexOutOfRangeException("Chỉ số nằm ngoài giới hạn.");
                points[index] = value;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            ArrayPoint arr = new ArrayPoint();
            arr.Add(new Point(1, 2));
            arr.Add(new Point(3, 4));
            arr.Add(new Point(5, 6));

            Console.WriteLine("Truy cập các phần tử thông qua Indexer:");
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            arr[1] = new Point(99, 99);
            Console.WriteLine($"Sau khi cập nhật arr[1]: {arr[1]}");
        }
    }
}