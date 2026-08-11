namespace AbstractFactory.Entidades
{
    public class MotorCombustion : IMotor
    {
        public void Arrancar() => Console.WriteLine("Motor a combustión: encendido, ronroneo del motor.");
    }
}
