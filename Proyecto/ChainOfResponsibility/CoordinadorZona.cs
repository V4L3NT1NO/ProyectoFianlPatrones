public class CoordinadorZona : AbstractHandler
    {
        public CoordinadorZona()
        {
            NivelMaximo = (int)NivelGravedad.Bajo;
        }

        protected override void resolver(Incidencia incidencia)
        {
            Console.WriteLine($"CoordinadorZona resolvió: {incidencia}");
        }
    }