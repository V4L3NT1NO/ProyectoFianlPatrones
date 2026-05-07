using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverF
{

    
    class SupervisorRegional : IObserver
    {

        private string nombre;

        private AbstractHandler cadenaMando;

        private DirectorDespacho directorDespacho;

        public ICreadorEnvio fabrica;






        public SupervisorRegional(string nombre) => this.nombre = nombre;
        public void Actualizar(ISubject sujeto)
        {
            if (sujeto is RecepcionCentro cap && cap.PorcentajeOcupacion > 90)
                Console.WriteLine("[SUPERVISOR]: Alerta de saturación. Desviando carga a otro centro.");
        }


        public void SetDirectorDespacho(DirectorDespacho director) => this.directorDespacho = director;


        public void SetHandler(AbstractHandler handler) => this.cadenaMando = handler;
        public void SetFabrica(ICreadorEnvio fabrica) => this.fabrica = fabrica;
    }
}
