using Shared;
public class CreadorEnvioEstandar : ICreadorEnvio
    {
        public override Envio CrearEnvio(EnvioConfig config) =>
            new EnvioEstandar(config);


        public override bool Validar(EnvioConfig config)
        {
            if(config.Peso > 0 &&
            config.Dimensiones != null &&
            config.MontoAsegurado == null &&
            config.DistanciaKm >0 && 
            config.Temperatura == null &&
                config.PaisDestino != null&&
                config.cliente != null)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Error al colocar datos al envío, verifique que los valores y datos correspondan al tipo...");
                return false;
            }
        }
    }