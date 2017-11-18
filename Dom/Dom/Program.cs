using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dom
{
    class Program
    {
        static void Main(string[] args)
        {
            House house1 = new House("klonowa", 50, 8, 4);
            house1.Tax();
        }
    }
}
