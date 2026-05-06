public class CoordinadorZona : AbstractHandler
    {
        public CoordinadorZona()
        {
            NivelMaximo = "Bajo";
        }

        protected override bool resolver(Incidencia incidencia)
        {
            if(incidencia.Nivel == NivelMaximo)
            {
                Console.WriteLine($"CoordinadorZona resolvió: {incidencia}");
                return true;
            }else{return false;}
        }
    }