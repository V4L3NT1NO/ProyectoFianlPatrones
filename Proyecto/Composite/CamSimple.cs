using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeF
{
    public class CamSimple : IComponenteCamino
    {
        private float costoBase;
        private int tiempoEstimado;

        public CamSimple(float costoBase, int tiempoEstimado)
        {
            this.costoBase = costoBase;
            this.tiempoEstimado = tiempoEstimado;
        }

        // Caso Base: Devuelve su propio valor sin delegar a nadie más
        public float SumaCosto()
        {
            return costoBase;
        }

        public int ObtenerTiempo()
        {
            return tiempoEstimado;
        }
    }
}
