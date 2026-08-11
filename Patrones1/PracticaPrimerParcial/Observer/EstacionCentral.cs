using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class EstacionCentral
    {
        List<ISuscriptor> suscriptores;
        public decimal Temperatura { get; set; }
        public EstacionCentral()
        {
            suscriptores = new List<ISuscriptor>();
        }
        public void Suscribir(ISuscriptor suscriptor) => suscriptores.Add(suscriptor);
        public void Desuscribir(ISuscriptor suscriptor) => suscriptores.Remove(suscriptor);
        private void Notificar()
        {
            foreach(ISuscriptor s in suscriptores)
            {
                s.Actualizar(this.Temperatura);
            }
        }

        public void CambiarTemperatura(decimal temperatura)
        {
            this.Temperatura = temperatura;
            Notificar();
        }
    }
}
