using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Pilas__Colas_y_Colas_Dobles.Estructuras.Pilas
{
    public class Ventana
    {
        public string Nombre { get; set; }
        public DateTime Hora { get; set; }
        public string Usuario { get; set; }

        public Ventana(string nombre, string usuario)
        {
            Nombre = nombre;
            Usuario = usuario;
            Hora = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Nombre} | {Usuario} | {Hora:HH:mm:ss}";
        }

    }
}
