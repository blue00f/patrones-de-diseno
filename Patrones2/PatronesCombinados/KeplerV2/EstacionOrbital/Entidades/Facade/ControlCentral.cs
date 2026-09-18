using EstacionOrbital.Entidades.Facade.Subsistemas;

namespace EstacionOrbital.Entidades.Facade
{
    public class ControlCentral
    {
        private readonly SistemaEnergia energia;
        private readonly SistemaSoporteVital soporteVital;
        private readonly SistemaNavegacion navegacion;
        private readonly SistemaComunicaciones comunicaciones;
        private readonly SistemaSeguridad seguridad;
        private readonly SistemaClima clima;
        private readonly SistemaInventario inventario;
        private readonly SistemaMedico medico;
        private readonly SistemaDefensa defensa;
        private readonly SistemaLog log;
        public ControlCentral()
        {
            energia = new();
            soporteVital = new();
            navegacion = new();
            comunicaciones = new();
            seguridad = new();
            clima = new();
            inventario = new();
            medico = new();
            defensa = new();
            log = new();
        }
        public void IniciarTurno()
        {
            Console.WriteLine(">> Iniciando turno...");
            energia.Encender();
            soporteVital.Activar();
            clima.Regular();
            navegacion.CalibrarOrbita();
            comunicaciones.Conectar();
            seguridad.Armar();
            defensa.Standby();
            inventario.Verificar();
            medico.Preparar();
            log.Registrar("Turno iniciado");
        }
        public void EntrarEnEmergencia()
        {
            Console.WriteLine(">> ¡PROTOCOLO DE EMERGENCIA!");
            energia.ModoReserva();
            soporteVital.MaximaPrioridad();
            seguridad.SellarCompuertas();
            defensa.ActivarEscudos();
            navegacion.Estabilizar();
            medico.Alerta();
            comunicaciones.EnviarSOS();
            log.Registrar("Emergencia declarada");
        }

        public void ApagarEstacion()
        {
            Console.WriteLine(">> Apagando la estación...");
            log.Registrar("Inicio de apagado");
            inventario.Cerrar();
            defensa.Desactivar();
            comunicaciones.Desconectar();
            navegacion.Apagar();
            clima.Apagar();
            seguridad.Bloquear();
            soporteVital.ModoMinimo();
            energia.Apagar();
        }
    }
}
