using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Pilas__Colas_y_Colas_Dobles.Estructuras.Pilas
{
    public class Movimiento
    {
        public string Accion { get; set; }
        public string Posicion { get; set; }
        public int Tiempo { get; set; }

        public Movimiento(string accion, string pos, int tiempo)
        {
            Accion = accion;
            Posicion = pos;
            Tiempo = tiempo;
        }

        public override string ToString()
        {
            return $"{Accion} en {Posicion} | t={Tiempo}s";
        }
    }

}
