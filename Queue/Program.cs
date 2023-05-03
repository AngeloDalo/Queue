using System;

namespace Corso
{
    class Program
    {
        static void Main(string[] args)
        {
            //STACK utilizza il mezzo FIFO
            Queue<string> prova = new Queue<string>();
            prova.Enqueue("io");
            prova.Enqueue("tu");
            prova.Enqueue("lui");
            prova.Enqueue("egli");
            prova.Enqueue("noi");

            //VEDERE
            Console.WriteLine(prova.Peek()); //vedo primo valore

            //RIMUOVERE
            prova.Dequeue(); //rimuovo primo

            //ITERAZIONE
            foreach (string item in prova)
            {
                Console.WriteLine(item);
            }

            //RIPULIRE
            prova.Clear();
        }
    }
}
