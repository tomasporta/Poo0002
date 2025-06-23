using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico.Entidades
{
    public class Camioneta : Vehiculo
    {
        public int CapacidadCarga { get; set; }
        public override decimal CalcularCostoUso() => 15 * (DateTime.Now.Year - Anio) + 0.5m * CapacidadCarga;
        public override string Informar()
        {
            return base.Informar() + $" | Carga: {CapacidadCarga}kg | Costo Uso: ${CalcularCostoUso():0.00}";
        }

    }
}

