using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Pilas__Colas_y_Colas_Dobles.Estructuras.Deque
{
    public class Imagen
    {
        public string Archivo { get; set; }
        public string Resolucion { get; set; }
        public DateTime Fecha { get; set; }

        public Imagen(string archivo, string resolucion, DateTime fecha)
        {
            Archivo = archivo;
            Resolucion = resolucion;
            Fecha = fecha;
        }

        public override string ToString()
        {
            return $"{Archivo} | {Resolucion} | {Fecha:dd/MM/yyyy}";
        }
    }

}
