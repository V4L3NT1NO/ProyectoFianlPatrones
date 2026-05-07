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
        public void Actualizar(String noticia)
        {
            Console.WriteLine($"[SUPERVISOR]: Recibida noticia: {noticia}");
        }


        public void SetDirectorDespacho(DirectorDespacho director) => this.directorDespacho = director;


        public void SetHandler(AbstractHandler handler) => this.cadenaMando = handler;
        public void SetFabrica(ICreadorEnvio fabrica) => this.fabrica = fabrica;
    }
}
