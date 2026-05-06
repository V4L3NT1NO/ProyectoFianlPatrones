public class DirectorRegional : AbstractHandler
    {
        public DirectorRegional()
        {
            NivelMaximo = "Máximo";
        }

        protected override bool resolver(Incidencia incidencia)
        {
           if(incidencia.Nivel == NivelMaximo)
            {
                Console.WriteLine($"CoordinadorRegional resolvió: {incidencia}");
                return true;
            }else{return false;}
        }
    }