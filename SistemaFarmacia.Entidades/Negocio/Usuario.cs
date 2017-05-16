namespace SistemaFarmacia.Entidades.Negocio
{
    public class Usuario : ClaseBase
    {
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string NombreUsuario { get; set; }
        public string UserPassword { get; set; }        
    }
}
