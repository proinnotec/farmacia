using System;

namespace SistemaFarmacia.Entidades.Negocio.Catalogos
{
    public class ConfiguracionDescuento: ClaseBase
    {
        public int IdDescuentoConfiguracion { get; set; }
        public int IdDescuento { get; set; }
        public int IdDia { get; set; }
        public string Dia { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
    }
}
