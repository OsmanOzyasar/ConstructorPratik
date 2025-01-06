using ConstructorPratik;
using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Bebek bebek = new Bebek();

            string name = bebek.Name = "Hüseyin";
            string surname = bebek.Surname = "Şibidik";
            bebek.WriteName(name, surname);

            Bebek bebek1 = new Bebek("Mustafa", "Şibidik");
        }
    }
}