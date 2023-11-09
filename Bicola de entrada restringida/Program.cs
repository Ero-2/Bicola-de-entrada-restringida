using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicola_de_entrada_restringida
{

    class InputRestrictedDeque<T>
    {
        private LinkedList<T> deque = new LinkedList<T>();

        public void AddRear(T item)
        {
            deque.AddLast(item);
        }

        public T RemoveFront()
        {
            if (deque.Count == 0)
            {
                throw new InvalidOperationException("La bicola está vacía.");
            }

            T item = deque.First.Value;
            deque.RemoveFirst();
            return item;
        }

        public int Count()
        {
            return deque.Count;
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            InputRestrictedDeque<int> irDeque = new InputRestrictedDeque<int>();

            irDeque.AddRear(1);
            irDeque.AddRear(2);
            irDeque.AddRear(3);

            Console.WriteLine("Elemento frontal removido: " + irDeque.RemoveFront());
            Console.WriteLine("Número de elementos en la bicola: " + irDeque.Count());

            Console.ReadKey();

        }
    }
}
