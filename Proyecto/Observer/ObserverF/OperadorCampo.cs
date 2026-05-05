using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverF
{
    class OperadorCampo : IObserver
    {
        private string nombre;
        public OperadorCampo(string nombre) => this.nombre = nombre;

        public void Actualizar(ISubject sujeto)
        {
            if (sujeto is RecepcionClima clima)
            {
                if (clima.RequiereCierre)
                    Console.WriteLine($"[Operador {nombre}]: Recibido. Deteniendo entregas por: {clima.EstadoClima}");
            }
            if (sujeto is RecepcionVehiculos v && !v.DispVehiculo)
            {
                Console.WriteLine($"[Operador {nombre}]: Buscando rutas alternativas, no hay vehículos.");
            }
        }
    }
}
