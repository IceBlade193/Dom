using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dom
{
    class House
    {
        public string Address;
        public int Length;
        public int WindowsAmount;
        public int People;

        public House(string address, int length, int windowsAmount, int people)
        {
            Address = address;
            Length = length;
            WindowsAmount = windowsAmount;
            People = people;
        }

        public void Tax()
        {
            Console.WriteLine("Podatek za dom wynosi: " + Length*10);
        }
    }
}
