namespace Builder.Entidades
{
    public class Computadora
    {
        public string Procesador { get; set; }
        public string MemoriaRam { get; set; }
        public string Almacenamiento { get; set; }
        public string PlacaDeVideo { get; set; }
        public bool RefrigeracionLiquida { get; set; }
        public override string ToString()
        {
            string resumen = $"CPU: {Procesador} | RAM: {MemoriaRam} | Almacenamiento: {Almacenamiento}";
            resumen += string.IsNullOrEmpty(PlacaDeVideo) ? " | Sin placa de video dedicada" : $" | GPU: {PlacaDeVideo}";
            resumen += RefrigeracionLiquida ? " | Con refrigeración líquida" : " | Refrigeración estándar (FAN)";
            return resumen;
        }
    }
}
