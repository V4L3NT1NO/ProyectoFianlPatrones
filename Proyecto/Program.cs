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

        var coordinador = new CoordinadorZona();
        var gerente = new GerenteOperaciones();
        var director = new DirectorRegional();


        coordinador.setSiguiente(gerente);
        gerente.setSiguiente(director);

        var cadenaMando = coordinador;
            
        

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





        //pruebas

        var builderInternacional = new Internacional();
        directorDespacho.setBuilder(builderInternacional);
        var archivo = operador1.directorDespacho.contruir();
        Console.WriteLine($"Archivo construido: {archivo.contenido}");


        var incidenciaClimea = new Incidencia("Clima","Medio");

        operador1.cadenaMando.manejar(incidenciaClimea);




        //Crear Cliente

        var clienteNuevo = new Cliente( "Empresa XYZ","Calle de la esquina",5);
        clienteNuevo.AsignarContrato(new ContratoCoorporativo("Contrato1","Este es solamente un contrato de prueba"));
        //Crear un envío

        var config = new EnvioConfig
        {
            Peso = 5.5f,
            Dimensiones = "30x20x15 cm",
            DistanciaKm = 150f,
            PaisDestino = "Chile",
            Temperatura = -5f,
            cliente = clienteNuevo
        };

        var fabrica = new CreadorEnvioRefrigerado();
        var envio =  fabrica.EntregarEnvio(config);

        if(envio != null){
        Console.WriteLine($"Envío procesado: {envio.ObtenerInfo()}");
//Utilizar el strategy

        Console.WriteLine($"Costo del envío: {envio.CalcularCosto()}");
        }

        envio.agregarComponenteCaminio(new CamSimple(20f, 100));

        if(envio != null){
        Console.WriteLine($"Envío procesado: {envio.ObtenerInfo()}");
//Utilizar el strategy

        Console.WriteLine($"Costo del envío: {envio.CalcularCosto()}");
        }



        //Pruebas de notificacion de recepciones
        recepcionClima.Notificar("El clima esta feo");
        recepcionVehiculos.Notificar("Hay vehículos disponibles");
        recepcionCentro.Notificar("El centro de distribución está saturado");


        

       












    }
}