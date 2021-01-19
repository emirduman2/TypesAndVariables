using System;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 2147483647; // int'in sınırı 2147483647 -2147483648. 32 bit yer kaplar.
            long number2 = -9223372036854775808; // -9223372036854775808 long sınırı. 64 bit yer kaplar.
            short number3 = -32768; // sınırı -32768, 32767 16 bit yer kaplar.
            byte number4 = 0; // 0 ile 255 arası değer tutar. 8 bit yer kaplar.
            double number5 = 10.4; //64 bit yer kaplar.
            decimal number6 = 10.4m; // daha hassas işler için kullanilir. Örneğin para.
            bool condition = true; // sadece true ve false tutabilir.
            char character = 'A';
            var number7 = 10;
            number7 = 'A';
            
            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine("Character is : {0}", (int)character);

            Console.WriteLine((int)Days.Friday); // tip dönüşüm.

            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday=10,Tuesday=20,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}
