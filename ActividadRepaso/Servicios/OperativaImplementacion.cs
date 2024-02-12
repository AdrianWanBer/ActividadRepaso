using ActividadRepaso.Dtos;

namespace ActividadRepaso.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        //Metodo de dar de alta actividad
        public void darAltaActividad(List<ActividadDtos> listaAntigua)
        {

            ActividadDtos nuevaActividad = new ActividadDtos();
            //Creacion de la actividad
            Console.WriteLine("Escriba el nombre de la actividad");
            nuevaActividad.nombreActividad = Console.ReadLine();
            Console.WriteLine("Escriba la fecha de inicio (dd/mm/yyyy)");
            DateTime fechaInicioCalc = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Escriba la fecha de cierre (dd/mm/yyyy)");
            DateTime fechaCierreCalc = DateTime.Parse(Console.ReadLine());

            //Calculo en minutos de las fechas 
            TimeSpan minutosDiferencia = fechaInicioCalc - fechaCierreCalc;
            nuevaActividad.fechaInicio = fechaInicioCalc;
            nuevaActividad.fechaFin = fechaCierreCalc;

            listaAntigua.Add(nuevaActividad);

        }

        //Metodo de mostrar actividad

        public void mostrarActividad(List<ActividadDtos> listaAntigua)
        {
            Console.WriteLine("Cual es el nombre de la actividad");
            string nombreActividadTemp = Console.ReadLine();
            foreach (ActividadDtos actividad in listaAntigua)
            {
                if (actividad.nombreActividad.Equals(nombreActividadTemp))
                {
                    Console.WriteLine(actividad);
                } else
                {
                    Console.WriteLine("No se ha encontrado la actividad");
                }
                
            }
        }

        public void borrarActividad(List<ActividadDtos> listaAntigua)
        {
            Console.WriteLine("Cual es el nombre de la actividad que desea borrar");
            string nombreActividadTemp = Console.ReadLine();
            foreach (ActividadDtos actividad in listaAntigua)
            {
                if (actividad.nombreActividad.Equals(nombreActividadTemp))
                {
                    listaAntigua.Remove(actividad);
                    Console.WriteLine("Borrado con exito");
                } else
                {
                    Console.WriteLine("No se ha encontrado la actividad");
                }
            }
        }

    }

}
