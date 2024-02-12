namespace ActividadRepaso.Dtos
{
    internal class ActividadDtos
    {
        public string nombreActividad;
        public DateTime fechaInicio;
        public DateTime fechaFin;
        public TimeSpan duracionMinutos;


        //Constructor vacio
        public ActividadDtos()
        {

        }
        //Constructor lleno
        public ActividadDtos(string nombreActividad, DateTime fechaInicio, DateTime fechaFin, TimeSpan duracionMinutos)
        {
            this.NombreActividad = nombreActividad;
            this.FechaInicio = fechaInicio;
            this.FechaFin = fechaFin;
            this.DuracionMinutos = duracionMinutos;
        }

        public string NombreActividad { get => nombreActividad; set => nombreActividad = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public TimeSpan DuracionMinutos { get => duracionMinutos; set => duracionMinutos = value; }
    }
}
