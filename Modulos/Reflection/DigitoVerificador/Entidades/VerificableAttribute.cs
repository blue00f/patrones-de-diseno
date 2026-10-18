namespace DigitoVerificador.Entidades
{
    public class VerificableAttribute : Attribute
    {
        string _prefix;
        public VerificableAttribute(string prefix)
        {
            _prefix = prefix;
        }
        public string Prefix { get { return _prefix; } }
    }
}
