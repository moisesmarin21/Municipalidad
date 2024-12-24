
using System;
using System.Data;
using Capa_Datos;
using Capa_Entidad;


namespace Capa_Negocio
{
    public class CN_Ciudadano
    {
        CD_Ciudadano objetoCD = new CD_Ciudadano();

        public DataTable Listar_Ciudadanos()
        {
            return objetoCD.Ciudadanos();
        }


        public DataTable Listar_TipoGenero()
        {
            return objetoCD.ListarTipoGenero();
        }

        public DataTable Listar_Zona()
        {
            return objetoCD.ListarZona();
        }

        public DataTable Listar_Situacion()
        {
            return objetoCD.ListarSituacion();
        }

        public DataTable Listar_TipoTarifa()
        {
            return objetoCD.ListarTipoTarifa();
        }

        public DataTable Buscar_Ciudadano(string valor)
        {
            CD_Ciudadano objetoCD = new CD_Ciudadano();
            return objetoCD.BuscarCiudadano(valor);
        }


        public void Insertar_Ciudadano(string nombreC, string apellidoC, string telefonoC, 
                            string dniC, string idTipoGenero, string idZona,
                                string idSituacion, string idTipoTarifa)
        {

            CD_Ciudadano objetoCD = new CD_Ciudadano();
            CE_Ciudadano obj = new CE_Ciudadano();

            obj.nombreC = nombreC;
            obj.apellidoC = apellidoC;
            obj.telefonoC = telefonoC;
            obj.dniC= dniC;

            obj.idTipoGenero = Convert.ToInt32(idTipoGenero);
            obj.idZona = Convert.ToInt32(idZona);
            obj.idSituacion = Convert.ToInt32(idSituacion);
            obj.idTipoTarifa = Convert.ToInt32(idTipoTarifa);

            objetoCD.InsertarCiudadano(obj);
        }


        public void Editar_Ciudadano(string idCiudadano, string nombreC, string apellidoC, 
                                    string telefonoC, string dniC, string idTipoGenero, 
                                        string idZona, string idSituacion, string idTipoTarifa)

        {
            CD_Ciudadano objetoCD = new CD_Ciudadano();
            CE_Ciudadano obj = new CE_Ciudadano();

            obj.idCiudadano = Convert.ToInt32(idCiudadano);
            obj.nombreC = nombreC;
            obj.apellidoC = apellidoC;
            obj.telefonoC = telefonoC;
            obj.dniC = dniC;

            obj.idTipoGenero = Convert.ToInt32(idTipoGenero);
            obj.idZona = Convert.ToInt32(idZona);
            obj.idSituacion = Convert.ToInt32(idSituacion);
            obj.idTipoTarifa = Convert.ToInt32(idTipoTarifa);

            objetoCD.EditarCiudadano(obj);
        }



        public void Eliminar_Ciudadano(string idCiudadano)
        {
            CD_Ciudadano objetoCD = new CD_Ciudadano();
            CE_Ciudadano obj = new CE_Ciudadano();

            obj.idCiudadano = Convert.ToInt32(idCiudadano);

            objetoCD.EliminarCiudadano(obj);
        }
    }
}
