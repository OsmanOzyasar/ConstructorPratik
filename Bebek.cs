using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorPratik
{
    public class Bebek
    {
        public Bebek() { }

        private string _name;
        private string _surname;
        private DateTime _birthDay;

        public Bebek(string name, string surname)
        {
            _name = name;
            _surname = surname;

            _birthDay = DateTime.Now;

            Console.WriteLine($"Ingaaa isim: {name} soyisim: {surname} doğum tarihi: {_birthDay}");
        }

        public void WriteName(string name, string surname)
        {
            _birthDay = DateTime.Now;
            Console.WriteLine($"Ingaaa isim: {name} soyisim: {surname} doğum tarihi: {_birthDay}");
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

    }
}
