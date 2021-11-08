using System;

namespace InfinteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada PIN-kood;
            //programm võrdleb sisestatud PIN-koodi arvuga 1234;
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast"
            //kui sisestatud PIN-kood on midagi muud, siis konsool kuvab"Vale PIN.Proovi uuesti";
            //katsete arv on piiramatu.

            bool loopActive = true; //boolean --> true/false (reserveeritud väärtus)
            int i = 0;

            while (loopActive)
            {
                Console.WriteLine("Sisesta PIN"); //cw+double TAB
                int userPIN = Convert.ToInt32(Console.ReadLine());
                if(userPIN == 1234)
                {
                    Console.Write("Tere päevast");
                    loopActive = false;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale PIN!");
                    Console.WriteLine($"Oled sisestanud vale PIN koodi {i} korda sisestanud");
                }
        {

        }

            }




            Console.WriteLine("Kena päeva");
        }
    }
}
