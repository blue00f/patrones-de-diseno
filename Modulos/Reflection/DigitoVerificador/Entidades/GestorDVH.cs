using System.Reflection;

namespace DigitoVerificador.Entidades
{
    public class GestorDVH
    {
        public static string GenerarDVH(Entity entidad)
        {
            Type t = entidad.GetType();
            string dvh = string.Empty;
            PropertyInfo[] props = t.GetProperties();
            var attrs = t.GetCustomAttributes(false);
            var verificable = (VerificableAttribute)attrs.Where(i => i.GetType().Equals(typeof(VerificableAttribute))).FirstOrDefault();
            if (verificable != null) dvh += $"{verificable.Prefix}_";

            foreach (PropertyInfo item in props)
            {
                if (item.PropertyType.FullName.Equals(typeof(DateTime).FullName))
                {
                    DateTime a = (DateTime)item.GetValue(entidad);
                    dvh += a.ToString("ddmmyyyyhhmmss");
                }
                else
                {
                    dvh += item.GetValue(entidad).ToString();
                }
            }
            return Encriptador.ObtenerHashMd5(dvh);
        }
    }
}
