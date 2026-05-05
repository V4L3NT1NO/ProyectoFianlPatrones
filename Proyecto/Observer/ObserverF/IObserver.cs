using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.JavaScript;
using System.Text;

namespace ObserverF
{
    internal interface IObserver
    {
        void Actualizar(ISubject sujeto);
    }
}
