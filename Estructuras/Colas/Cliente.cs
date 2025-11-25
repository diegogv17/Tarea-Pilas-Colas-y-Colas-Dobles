using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Pilas__Colas_y_Colas_Dobles.Estructuras.Colas
{
    public class Cliente
    {
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public string Pedido { get; set; }

        public Cliente(int num, string nombre, string pedido)
        {
            Numero = num;
            Nombre = nombre;
            Pedido = pedido;
        }

        public override string ToString()
        {
            return $"#{Numero} {Nombre} ({Pedido})";
        }
    }

}
