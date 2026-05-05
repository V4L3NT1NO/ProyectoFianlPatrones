using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverF
{
    class SupervisorRegional : IObserver
    {
        public void Actualizar(ISubject sujeto)
        {
            if (sujeto is RecepcionCentro cap && cap.PorcentajeOcupacion > 90)
                Console.WriteLine("[SUPERVISOR]: Alerta de saturación. Desviando carga a otro centro.");
        }
    }
}
