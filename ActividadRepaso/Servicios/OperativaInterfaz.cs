using ActividadRepaso.Dtos;

namespace ActividadRepaso.Servicios
{
    internal interface OperativaInterfaz
    {
        public void darAltaActividad(List<ActividadDtos> listaAntigua);

        public void mostrarActividad(List<ActividadDtos> listaAntigua);

        public void borrarActividad(List<ActividadDtos> listaAntigua)
    }
}
