using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.JavaScript;
using System.Text;

namespace ObserverF
{
    internal interface IObserver
    {
        void Actualizar(String noticia);

        void SetHandler(AbstractHandler handler);

        void SetDirectorDespacho(DirectorDespacho director);

        void SetFabrica(ICreadorEnvio fabrica);
    }
}
