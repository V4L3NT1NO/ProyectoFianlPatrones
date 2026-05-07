using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverF
{
    internal interface ISubject
    {
        void Suscribirse(IObserver operador);

        void Desuscribir(IObserver operador);

        void Notificar(String mensaje);
    }
}