using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverF
{
    class RecepcionCentro : ISubject
    {


        public int PorcentajeOcupacion { get; set; }

        private List<IObserver> operadores = new List<IObserver>();

        public void Suscribirse(IObserver operador)
        {
            if (operadores.Contains(operador))
            {
                Console.WriteLine($"[SUJETO: {PorcentajeOcupacion}] : El operador ya está suscrito a la recepción de vehículos.");
                return;
            }
            operadores.Add(operador);
        }

        public void Desuscribir(IObserver operador)
        {
            operadores.Remove(operador);
        }

        public void Notificar()
        {
            if (operadores.Count == 0)
            {
                Console.WriteLine($"[SUJETO: {PorcentajeOcupacion}] : No hay operadores suscritos para recibir notificaciones.");
                return;
            }

            foreach (IObserver o in operadores)
            {
                o.Actualizar(this);
            }
            Console.WriteLine("----------------------------------------------------------------------------");
        }
    }
}
