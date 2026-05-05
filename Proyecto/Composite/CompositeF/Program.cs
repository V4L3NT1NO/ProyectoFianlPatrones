using CompositeF;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SISTEMA DE PLANIFICACIÓN DE RUTAS (COMPOSITE) ===\n");

        // 1. CASO BASE: Tramos Simples (Hojas)
        // Representan trayectos directos punto a punto
        var tramoCochabambaQuillacollo = new CamSimple(costoBase: 15.50f, tiempoEstimado: 25);
        var tramoQuillacolloVinto = new CamSimple(costoBase: 10.00f, tiempoEstimado: 15);
        var tramoVintoSipeSipe = new CamSimple(costoBase: 12.00f, tiempoEstimado: 20);

        // 2. COMPOSITE NIVEL 1: Una Ruta Urbana
        // Agrupamos tramos simples en una sola entidad
        var rutaValleBajo = new CamIntermedio();
        rutaValleBajo.AñadirComponente(tramoCochabambaQuillacollo);
        rutaValleBajo.AñadirComponente(tramoQuillacolloVinto);
        rutaValleBajo.AñadirComponente(tramoVintoSipeSipe);

        // 3. COMPOSITE NIVEL 2: Ruta Nacional (Ruta Urbana + Tramos de Carretera)
        var tramoSipeSipeConfital = new CamSimple(costoBase: 50.00f, tiempoEstimado: 90);
        var tramoConfitalOruro = new CamSimple(costoBase: 45.00f, tiempoEstimado: 80);

        var rutaOccidente = new CamIntermedio();
        rutaOccidente.AñadirComponente(rutaValleBajo); // Añadimos un Composite dentro de otro
        rutaOccidente.AñadirComponente(tramoSipeSipeConfital);
        rutaOccidente.AñadirComponente(tramoConfitalOruro);

        // --- CÁLCULOS Y DEMOSTRACIÓN ---

        // Calculando el tramo más simple
        MostrarInfo("TRAMO SIMPLE (CBBA-QUILLACOLLO)", tramoCochabambaQuillacollo);

        // Calculando la ruta urbana (3 tramos)
        MostrarInfo("RUTA URBANA (VALLE BAJO)", rutaValleBajo);

        // Calculando la ruta compleja (Ruta Urbana + Carretera)
        // Aquí es donde la recursividad brilla: el sistema no sabe que hay niveles anidados
        MostrarInfo("RUTA COMPLEJA (CBBA-ORURO)", rutaOccidente);
    }

    // Método auxiliar para simular la consulta del Área de Planificación
    static void MostrarInfo(string nombre, IComponenteCamino ruta)
    {
        Console.WriteLine($"--- {nombre} ---");
        Console.WriteLine($"Costo Total:  {ruta.SumaCosto():C} Bs.");
        Console.WriteLine($"Tiempo Total: {ruta.ObtenerTiempo()} minutos");
        Console.WriteLine(new string('-', 40));
    }
}