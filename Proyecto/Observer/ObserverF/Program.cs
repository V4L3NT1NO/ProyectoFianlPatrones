using ObserverF;
using System;

class Program
{
    static void Main(string[] args)
    {
        // --- CONFIGURACIÓN INICIAL ---

        // Creamos los Sujetos (Fuentes de eventos)
        var recepcionClima = new RecepcionClima();
        var recepcionVehiculos = new RecepcionVehiculos();
        var gestionCapacidad = new RecepcionCentro(); // El tercer sujeto solicitado

        // Creamos los Observadores (Operadores)
        var operadorJuan = new OperadorCampo("Juan");
        var operadorMaria = new OperadorCampo("Maria");
        var supervisorHugo = new SupervisorRegional();

        // Suscripción (Párrafo 9: "Los operadores pueden incorporarse o retirarse")
        recepcionClima.Suscribirse(operadorJuan);
        recepcionClima.Suscribirse(supervisorHugo);

        recepcionVehiculos.Suscribirse(operadorMaria);

        gestionCapacidad.Suscribirse(supervisorHugo);

        // --- ESCENARIO 1: EL MEJOR DE LOS CASOS (Operación Normal) ---
        Console.WriteLine(">>> ESCENARIO: OPERACIÓN NORMAL EN QUILLACOLLO <<<");

        recepcionClima.EstadoClima = "Soleado";
        recepcionClima.RequiereCierre = false;
        recepcionClima.Notificar(); // Nadie debería alarmarse

        recepcionVehiculos.DispVehiculo = true;
        recepcionVehiculos.Notificar();

        Console.WriteLine("\n" + new string('=', 50) + "\n");

        // --- ESCENARIO 2: EL PEOR DE LOS CASOS (Crisis operativa) ---
        // (Párrafo 8: "cierres temporales por condiciones climáticas o saturación")
        Console.WriteLine(">>> ESCENARIO: CRISIS - TORMENTA Y SATURACIÓN <<<");

        // 1. Cambio climático brusco
        recepcionClima.EstadoClima = "Tormenta Eléctrica Grave";
        recepcionClima.RequiereCierre = true;

        // El Operador Juan reaccionará estacionando, 
        // El Supervisor Hugo recibirá la alerta para gestión de riesgos.
        recepcionClima.Notificar();

        // 2. Saturación de capacidad
        gestionCapacidad.PorcentajeOcupacion = 95; // 95% de capacidad

        // Solo el Supervisor está suscrito a capacidad, 
        // él decidirá desviar la carga sin molestar a los de campo.
        gestionCapacidad.Notificar();

        // --- ESCENARIO 3: RETIRO DE OPERADOR (Párrafo 9) ---
        Console.WriteLine("\n>>> CAMBIO DE TURNO: Maria se retira <<<");
        recepcionVehiculos.Desuscribir(operadorMaria);

        recepcionVehiculos.DispVehiculo = false;
        recepcionVehiculos.Notificar(); // Maria ya no recibe la señal porque terminó su turno.
    }
}