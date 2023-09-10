using System;
using System.Collections.Generic;
using lab12ex1;

namespace lab12ex1
{
    class Program
    {

        static void Main(string[] args)
        {
            /*Scrieti o clasa care va implementa o structura de date generica de tipul coada. (queue)
       Coada va functiona pe principiul FIFO (first in first out) si va avea urmatoarele metode si proprietati:
        • Enqueue – va adauga un element la capatul cozii
        • Dequeue – va extrage primul element din coada si il va returna ca rezultat
        • Count – va returna numarul de elemente din coada.
        La initializarea cozii va fi stabilita capacitatea maxima a cozii.
        In interiorul clasei, folositi o structura de tip vector pentru a stoca datele.
        Initializati mai multe cozi (intregi, obiecte), adaugati elemente, extrageti elemente, afisati-le.
             */

            var queue = new Queue<int>(5);
            queue.Enqueue(10);
            queue.Enqueue(11);
            queue.Enqueue(12);
            queue.Enqueue(15);
            queue.Enqueue(1);

            queue.Afisare();
            Console.WriteLine($"Coada are {queue.Count} elemente");



            var queue1 = new Queue<int>(8);
            queue1.Enqueue(100);
            queue1.Enqueue(111);
            queue1.Enqueue(125);
            queue1.Enqueue(153);
            queue1.Enqueue(15);
            queue1.Enqueue(36);
            queue1.Enqueue(56);
            queue1.Enqueue(45);


            queue1.Afisare();
            Console.WriteLine($"Coada are {queue1.Count} elemente");
        }



    }
}