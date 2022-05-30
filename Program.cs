using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Иванов";
            string secondName = "Иван";
            string changer;

            Console.WriteLine("Неверные Имя и Фамилия: {0} {1}", name, secondName);

            changer = name;
            name = secondName;
            secondName = changer;

            Console.WriteLine("Bерные Имя и Фамилия: {0} {1}", name, secondName);
        }
    }
}
