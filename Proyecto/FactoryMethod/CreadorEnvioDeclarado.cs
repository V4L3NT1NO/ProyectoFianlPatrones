using Shared;
public class CreadorEnvioValorDeclarado : ICreadorEnvio
    {
        public override Envio CrearEnvio(EnvioConfig config) =>
            new EnvioValorDeclarado(config);

        public override bool Validar(EnvioConfig config){
            if(config.Peso <= 0 &&
             config.Dimensiones != null &&
              config.MontoAsegurado > 0 &&
               config.DistanciaKm >0 && 
               config.Temperatura == null &&
                config.PaisDestino != null &&
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



  