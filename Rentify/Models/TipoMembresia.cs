using System;
namespace Rentify.Models
{
    public class TipoMembresia
    {
        public TipoMembresia()
        {
        }

        /*
          
          Reglas de negocio.

        
         MEMBRESIA        |  COSTO POR REGISTRO  |   DESCUENTO  

        (1) Al contado            Gratis                0%
        (2) Mensual                100                  10%
        (3) Cuatrimestral          300                  15%
        (4) Anual                  900                  20%

         */


        public byte Id { get; set; }
        public short CostoRegistro { get; set; }
        public byte DuracionEnMeses { get; set; }
        public byte Descuento { get; set; }
    }
}
