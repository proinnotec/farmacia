namespace SistemaFarmacia.Entidades.Negocio
{
    public class ElementoMenu
    {
        public int IdMenu { get; set; }
        public string TextoVinculo { get; set; }
        public string Descripcion { get; set; }
        public string Vista { get; set; }
        public int IdPadre { get; set; }
        public int Posicion { get; set; }
        public int Nivel { get; set; }
    }
}
