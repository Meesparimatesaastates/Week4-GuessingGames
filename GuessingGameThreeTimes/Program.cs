using System;

namespace GuessingGameThreeTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja pole suutnud kolme katsega ära arvata, siis mängu võidab arvuti
            //*programm genereerib juhuslikku numbrit üks korda.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Paku oma number 1 kuni 10'ni"); //cw+double TAB
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber == Convert.ToInt32(cpuNumber))
                {
                    Console.Write("Õige vastus");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale number!");
                    Console.WriteLine($"Oled sisestanud vale numbrit {i} korda sisestanud");
                    
                }
            }
            Console.WriteLine($"Õige number oli {cpuNumber}");
        }
    }
}
