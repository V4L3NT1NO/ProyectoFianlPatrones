using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverF
{
    class OperadorCampo : IObserver
    {
        private string nombre;



        public AbstractHandler cadenaMando;

        public DirectorDespacho directorDespacho;

        public ICreadorEnvio fabrica;

        public OperadorCampo(string nombre) => this.nombre = nombre;

        
        public void SetFabrica(ICreadorEnvio fabrica) => this.fabrica = fabrica;

        public void SetDirectorDespacho(DirectorDespacho director) => this.directorDespacho = director;
        public void SetHandler(AbstractHandler handler) => this.cadenaMando = handler;

        public void Actualizar(String noticia)
        {
            Console.WriteLine($"[Operador {nombre}]: Recibida noticia: {noticia}");
        }
    }
}