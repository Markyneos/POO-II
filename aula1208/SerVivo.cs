using System;

namespace aula1208;

public class SerVivo
{
    public int Tamanho { get; set; }

    public void Nascer() => Console.WriteLine("SerVivo: Nascer()!!!");

    public void Crescer() => Console.WriteLine("SerVivo: Crescer()");

    public void Morrer() => Console.WriteLine("SerVivo: Morrer()");
}
