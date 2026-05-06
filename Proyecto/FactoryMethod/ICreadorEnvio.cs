using Shared;
public abstract class ICreadorEnvio
    {
        public abstract IEnvio CrearEnvio();

        public void ProcesarEnvio()
        {
            IEnvio envio = CrearEnvio();
            Console.WriteLine($"  Envío creado → {envio.ObtenerInfo()}");
        }
    }