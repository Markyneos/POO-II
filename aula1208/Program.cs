using System;

namespace aula1208;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("== SerVivo ==");
        SerVivo sv = new SerVivo();
        sv.Nascer();
        sv.Crescer();
        sv.Morrer();

        Console.WriteLine("== Animal ==");
        Animal an = new();
        an.Mover();
        an.Respirar();

        an.Nascer();
    }
}
