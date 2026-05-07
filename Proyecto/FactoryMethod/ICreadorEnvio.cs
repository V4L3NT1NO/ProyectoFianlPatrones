using Shared;
public abstract class ICreadorEnvio
    {
        public abstract Envio CrearEnvio(EnvioConfig config);

        public Envio EntregarEnvio(EnvioConfig config)
        {
            if(!Validar(config))
            {
                Console.WriteLine("  Configuración no válida para este tipo de envío.");
                return null;
            }
            else
            {
                var envio = CrearEnvio(config);
                Console.WriteLine($"  Envío creado → {envio.ObtenerInfo()}");
                return envio;
            }
        }

        public abstract bool Validar(EnvioConfig config);
        
    }