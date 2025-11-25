using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Pilas__Colas_y_Colas_Dobles.Estructuras.Deque
{
    public class NodoD<T>
    {
        public T Valor;
        public NodoD<T> Anterior;
        public NodoD<T> Siguiente;

        public NodoD(T valor)
        {
            Valor = valor;
        }
    }

    public class Deque<T>
    {
        private NodoD<T> frente;
        private NodoD<T> final;

        public int Count { get; private set; }

        public void InsertFront(T valor)
        {
            NodoD<T> nuevo = new NodoD<T>(valor);

            if (frente == null)
                frente = final = nuevo;
            else
            {
                nuevo.Siguiente = frente;
                frente.Anterior = nuevo;
                frente = nuevo;
            }

            Count++;
        }

        public void InsertRear(T valor)
        {
            NodoD<T> nuevo = new NodoD<T>(valor);

            if (final == null)
                frente = final = nuevo;
            else
            {
                final.Siguiente = nuevo;
                nuevo.Anterior = final;
                final = nuevo;
            }

            Count++;
        }

        public T DeleteFront()
        {
            if (frente == null) return default;

            T val = frente.Valor;
            frente = frente.Siguiente;

            if (frente != null)
                frente.Anterior = null;
            else
                final = null;

            Count--;

            return val;
        }

        public T PeekFront() => frente != null ? frente.Valor : default;
    }

}
