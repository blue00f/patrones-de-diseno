namespace State2.Entidades
{
    public class Reproductor
    {
        private Estado estado;
        private List<string> playlist = new List<string> { "Tema 1", "Tema 2", "Tema 3" };
        private int cancionActual = 0;
        public bool Reproduciendo { get; private set; }
        public string NombreEstado => estado.Nombre;
        public string CancionActual => playlist[cancionActual];
        public Reproductor()
        {
            estado = new EstadoListo(this);
        }
        public void CambiarEstado(Estado nuevoEstado)
        {
            Console.WriteLine($"\t(Transición: {estado.Nombre} -> {nuevoEstado.Nombre})");
            this.estado = nuevoEstado;
        }
        public void ClickBloquear() => estado.ClickBloquear();
        public void ClickPlay() => estado.ClickPlay();
        public void ClickSiguiente(bool dobleClick = false) => estado.ClickSiguiente(dobleClick);
        public void ClickAnterior(bool dobleClick = false) => estado.ClickAnterior(dobleClick);

        public void IniciarReproduccion()
        {
            Reproduciendo = true;
            Console.WriteLine($"\tReproduciendo: {CancionActual}");
        }
        public void DetenerReproduccion()
        {
            Reproduciendo = false;
            Console.WriteLine("\tReproducción detenida.");
        }
        public void SiguienteCancion()
        {
            cancionActual = (cancionActual + 1) % playlist.Count;
            MostrarCancion();
        }
        public void CancionAnterior()
        {
            cancionActual = (cancionActual - 1 + playlist.Count) % playlist.Count;
            MostrarCancion();
        }
        public void AvanzarRapido(int segundos) => Console.WriteLine($"\tAvance rápido de {segundos} segundos en '{CancionActual}'.");
        public void Retroceder(int segundos) => Console.WriteLine($"\tRetroceso de {segundos} segundos en '{CancionActual}'.");
        private void MostrarCancion()
        {
            string accion = Reproduciendo ? "Reproduciendo" : "Canción seleccionada";
            Console.WriteLine($"\t{accion}: {CancionActual}");
        }
    }
}