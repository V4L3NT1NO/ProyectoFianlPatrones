public class GerenteOperaciones : AbstractHandler
    {
        public GerenteOperaciones()
        {
            NivelMaximo = (int)NivelGravedad.Medio;
        }

        protected override void resolver(Incidencia incidencia)
        {
            Console.WriteLine($"GerenteOperaciones resolvió: {incidencia}");
        }
    }