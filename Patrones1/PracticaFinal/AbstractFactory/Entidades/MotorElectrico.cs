namespace AbstractFactory.Entidades
{
    public class MotorElectrico : IMotor
    {
        public void Arrancar() => Console.WriteLine("Motor eléctrico: arranque silencioso, listo en un instante.");
    }
}
