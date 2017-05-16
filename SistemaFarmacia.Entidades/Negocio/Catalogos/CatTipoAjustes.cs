namespace SistemaFarmacia.Entidades.Negocio.Catalogos
{
    public class CatTipoAjustes: ClaseBase
    {
        public int IdTipoAjuste { get; set; }
        public string Descripcion { get; set; }
        public Usuario Usuario { get; set; }
        public bool EsActivo { get; set; }

        public CatTipoAjustes()
        {
            Usuario = new Usuario();
        }

    }

}
