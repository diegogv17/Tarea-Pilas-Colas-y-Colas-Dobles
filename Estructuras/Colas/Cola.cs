using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Pilas__Colas_y_Colas_Dobles.Estructuras.Colas
{
    public class NodoCola<T>
    {
        public T Valor;
        public NodoCola<T> Siguiente;

        public NodoCola(T valor)
        {
            Valor = valor;
        }
    }

    public class Cola<T>
    {
        private NodoCola<T> frente;
        private NodoCola<T> final;

        public int Count { get; private set; }

        public void Enqueue(T valor)
        {
            NodoCola<T> nuevo = new NodoCola<T>(valor);

            if (frente == null)
            {
                frente = final = nuevo;
            }
            else
            {
                final.Siguiente = nuevo;
                final = nuevo;
            }

            Count++;
        }

        public T Dequeue()
        {
            if (frente == null) return default;

            T valor = frente.Valor;
            frente = frente.Siguiente;
            Count--;

            if (frente == null) final = null;

            return valor;
        }

        public T Peek()
        {
            return frente != null ? frente.Valor : default;
        }
    }

}
