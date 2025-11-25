using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Pilas__Colas_y_Colas_Dobles.Estructuras.Pilas
{
    public class Nodo<T>
    {
        public T Valor;
        public Nodo<T> Siguiente;

        public Nodo(T valor)
        {
            Valor = valor;
        }
    }

    public class Pila<T>
    {
        private Nodo<T> tope;

        public int Count { get; private set; }

        public void Push(T valor)
        {
            Nodo<T> nuevo = new Nodo<T>(valor);
            nuevo.Siguiente = tope;
            tope = nuevo;
            Count++;
        }

        public T Pop()
        {
            if (tope == null)
                return default;

            T valor = tope.Valor;
            tope = tope.Siguiente;
            Count--;
            return valor;
        }

        public T Peek()
        {
            return tope != null ? tope.Valor : default;
        }
    }

}
