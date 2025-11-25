using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Pilas__Colas_y_Colas_Dobles.Estructuras.Deque
{
    public class Vehiculo
    {
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public DateTime Hora { get; set; }

        public Vehiculo(string placa, string tipo)
        {
            Placa = placa;
            Tipo = tipo;
            Hora = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Placa} | {Tipo} | {Hora:HH:mm:ss}";
        }
    }

}
