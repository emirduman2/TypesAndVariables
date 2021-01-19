using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";

            string[] students2 = { "engin", "derin", "salih" };
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";

            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }
        }
    }
}
