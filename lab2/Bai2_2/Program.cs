using System;
using System.Collections.Generic;

namespace Bai2_2
{
    public class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public int Yod { get; set; }

        public Person() { Id = ""; Name = ""; Yob = 0; Yod = 0; }
        public Person(Person p) { Id = p.Id; Name = p.Name; Yob = p.Yob; Yod = p.Yod; }

        public bool IsLiving() => Yod == 0;

        public void Input()
        {
            Console.Write("Nhập ID: "); Id = Console.ReadLine();
            Console.Write("Nhập Tên: "); Name = Console.ReadLine();
            Console.Write("Nhập Năm sinh: "); Yob = int.Parse(Console.ReadLine());
            Console.Write("Nhập Năm mất (0 nếu còn sống): "); Yod = int.Parse(Console.ReadLine());
        }

        public void Output() =>
            Console.WriteLine($"[{Id}] {Name} (Sinh: {Yob}, " + (IsLiving() ? "Còn sống)" : $"Mất: {Yod})"));
    }

    public class PersonList
    {
        private List<Person> list;

        public PersonList() { list = new List<Person>(); }
        public PersonList(PersonList other)
        {
            list = new List<Person>();
            foreach (var p in other.list) list.Add(new Person(p));
        }

        public void Add(Person x) => list.Add(x);

        public void Input()
        {
            Console.Write("Nhập số lượng người: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập người thứ {i + 1}:");
                Person p = new Person();
                p.Input();
                list.Add(p);
            }
        }

        public void Output()
        {
            foreach (var p in list) p.Output();
        }

        // Trả về một PersonList những người còn sống
        public PersonList LivingPeople()
        {
            PersonList livingList = new PersonList();
            foreach (var p in list)
            {
                if (p.IsLiving()) livingList.Add(p);
            }
            return livingList;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            PersonList pl = new PersonList();
            pl.Input();

            Console.WriteLine("\n--- DANH SÁCH TOÀN BỘ NHÂN KHẨU ---");
            pl.Output();

            Console.WriteLine("\n--- DANH SÁCH NGƯỜI CÒN SỐNG ---");
            PersonList living = pl.LivingPeople();
            living.Output();
        }
    }
}
