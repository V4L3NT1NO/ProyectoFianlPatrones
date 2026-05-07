using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverF
{
    class RecepcionVehiculos : ISubject
    {


        public bool DispVehiculo { get; set; }
        private List<IObserver> operadores = new List<IObserver>();

        public void Suscribirse(IObserver operador)
        {
            if (operadores.Contains(operador))
            {
                Console.WriteLine($"[SUJETO: {DispVehiculo}] : El operador ya está suscrito a la recepción de vehículos.");
                return;
            }
            operadores.Add(operador);
        }

        public void Desuscribir(IObserver operador)
        {
            operadores.Remove(operador);
        }

        public void Notificar(String mensaje)
        {
            if (operadores.Count == 0)
            {
                Console.WriteLine($"[SUJETO: {DispVehiculo}] : No hay operadores suscritos para recibir notificaciones.");
                return;
            }

            foreach (IObserver o in operadores)
            {
                o.Actualizar(mensaje);
            }
            Console.WriteLine("----------------------------------------------------------------------------");
        }
    }
}
