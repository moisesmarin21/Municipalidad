namespace Capa_Entidad
{
    public class CE_Ciudadano
    {
        public int idCiudadano { get; set; }
        public string nombreC { get; set; }
        public string apellidoC { get; set; }
        public string telefonoC { get; set; }
        public string dniC { get; set; }

        public int idTipoGenero { get; set; }
        public int idZona { get; set; }
        public int idSituacion { get; set; }
        public int idTipoTarifa { get; set; }

    }
}
