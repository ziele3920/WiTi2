using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiTi2
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskService TS = new TaskService();
            Witi witi = new Witi();

            string[] files = { "dane1.txt", "dane2.txt", "dane3.txt", "dane4.txt", "dane5.txt", "dane6.txt", "dane7.txt", "dane8.txt", "dane9.txt" };
            Task[] tasks;

            //Console.WriteLine("Podaj nazwę pliku");
            string fileName = files[8];// Console.ReadLine();
            tasks = TS.ReadData(fileName);

            Console.WriteLine($"Result: {witi.WitiAlg(tasks)}");
            Console.ReadLine();
        }
    }
}





