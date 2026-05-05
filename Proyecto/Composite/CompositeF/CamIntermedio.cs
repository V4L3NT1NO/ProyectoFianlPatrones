using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeF
{
    internal class CamIntermedio : IComponenteCamino
    {
        // Lista que puede contener caminos simples O OTROS caminos intermedios
        private List<IComponenteCamino> componentes = new List<IComponenteCamino>();

        // Operaciones de gestión exclusivas del nodo compuesto
        public void AñadirComponente(IComponenteCamino componente)
        {
            componentes.Add(componente);
        }

        public void QuitarComponente(IComponenteCamino componente)
        {
            componentes.Remove(componente);
        }

        // Paso Recursivo: Delega el cálculo a sus hijos y suma los resultados
        public float SumaCosto()
        {
            float costoTotal = 0;
            foreach (var componente in componentes)
            {
                // ¡Aquí está la magia del polimorfismo! 
                // No le importa si es CamSimple o CamIntermedio, solo le pide el costo.
                costoTotal += componente.SumaCosto();
            }
            return costoTotal;
        }

        public int ObtenerTiempo()
        {
            int tiempoTotal = 0;
            foreach (var componente in componentes)
            {
                tiempoTotal += componente.ObtenerTiempo();
            }
            return tiempoTotal;
        }
    }
}
