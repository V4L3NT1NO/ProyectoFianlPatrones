using ObserverF;
using CompositeF;
class Program
{
    static void Main(string[] args)
    {

        // Crear recepciones

        var recepcionClima = new RecepcionClima();
        var recepcionVehiculos = new RecepcionVehiculos();
        var recepcionCentro = new RecepcionCentro();


        //Crear Operadores
        var supervisor = new SupervisorRegional("Juan ");
        var operador1 = new OperadorCampo("Operador 1");

        //Sucribir

        recepcionClima.Suscribirse(operador1);
        recepcionVehiculos.Suscribirse(operador1);
        recepcionCentro.Suscribirse(operador1);

        recepcionClima.Suscribirse(supervisor);
        recepcionVehiculos.Suscribirse(supervisor);
        recepcionCentro.Suscribirse(supervisor);

        //Crear Cadena de mando (no me acuerdo el orden )

        var cadenaMando = new CoordinadorZona().setSiguiente(new GerenteOperaciones()).setSiguiente(new DirectorRegional());
        

        // agregar cadena a operadores
        operador1.SetHandler(cadenaMando);
        supervisor.SetHandler(cadenaMando);


        //Agregar Abstract

        var absFactoryBolivia = new concreteBolivia();
        var absFactoryPeru = new concretePeru();
        var absFactoryChile = new concreteChile();


        var directorDespacho = new DirectorDespacho();

        operador1.SetDirectorDespacho(directorDespacho);
        supervisor.SetDirectorDespacho(directorDespacho);



        








    }
}