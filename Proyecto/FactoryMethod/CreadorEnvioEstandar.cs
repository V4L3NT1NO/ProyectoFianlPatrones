using Shared;
public class CreadorEnvioEstandar : ICreadorEnvio
    {
        private readonly float _peso;
        private readonly string _dimensiones;
        private readonly float _distanciaKm;

        public CreadorEnvioEstandar(float peso, string dimensiones, float distanciaKm)
        {
            _peso = peso;
            _dimensiones = dimensiones;
            _distanciaKm = distanciaKm;
        }

        public override IEnvio CrearEnvio() =>
            new EnvioEstandar(_peso, _dimensiones, _distanciaKm);
    }