using ActividadRepaso.Dtos;
using ActividadRepaso.Servicios;

namespace ActividadRepaso.Controladores
{
    class program
    {
        public static void Main(string[] args)
        {
            List<ActividadDtos> listaActividades = new List<ActividadDtos>();
            OperativaInterfaz oi = new OperativaImplementacion();
            MenuInterfaz mi = new MenuImplementacion();
            bool cerrarMenu = false;
            while (!cerrarMenu)
            {
                int seleccion = mi.menuYSeleccion();
                switch (seleccion)
                {
                    //Cerrar menu
                    case 0:
                        cerrarMenu = true;
                        break;

                    //Crear actividad
                    case 1:
                        oi.darAltaActividad(listaActividades);
                        break;
                    //Mostar actividad
                    case 2:
                        oi.mostrarActividad(listaActividades);
                        break;
                    //Eliminar actividad
                    case 3:
                        oi.borrarActividad(listaActividades);
                        break;
                }

            }
        }
    }
}