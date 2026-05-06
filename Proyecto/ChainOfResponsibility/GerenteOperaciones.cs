public class GerenteOperaciones : AbstractHandler
    {
        public GerenteOperaciones()
        {
            NivelMaximo = "Medio" ;
        }

        protected override bool resolver(Incidencia incidencia)
        {
           if(incidencia.Nivel == NivelMaximo)
            {
                Console.WriteLine($"GerenteOperaciones resolvió: {incidencia}");
                return true;
            }else{return false;}
        }
    }