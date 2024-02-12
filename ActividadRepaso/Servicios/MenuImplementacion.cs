namespace ActividadRepaso.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuYSeleccion()
        {
            Console.WriteLine("Escoja una opcion");
            Console.WriteLine("0. Cerrar programa");
            Console.WriteLine("1. Dar de alta actividad");
            Console.WriteLine("2. Mostrar actividad");
            Console.WriteLine("3. Eliminar actividad");
            int seleccion = int.Parse(Console.ReadLine());
            return seleccion;
        }
    }
}
