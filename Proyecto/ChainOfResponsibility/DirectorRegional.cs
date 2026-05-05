public class DirectorRegional : AbstractHandler
    {
        public DirectorRegional()
        {
            NivelMaximo = (int)NivelGravedad.Alto;
        }

        protected override void resolver(Incidencia incidencia)
        {
            Console.WriteLine($"DirectorRegional resolvió: {incidencia}");
        }
    }