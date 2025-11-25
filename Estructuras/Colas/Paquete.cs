using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Pilas__Colas_y_Colas_Dobles.Estructuras.Colas
{
    public class Paquete
    {
        public string Codigo { get; set; }
        public string Proveedor { get; set; }
        public double Peso { get; set; }

        public Paquete(string codigo, string proveedor, double peso)
        {
            Codigo = codigo;
            Proveedor = proveedor;
            Peso = peso;
        }

        public override string ToString()
        {
            return $"{Codigo} | {Proveedor} | {Peso}kg";
        }
    }

}
