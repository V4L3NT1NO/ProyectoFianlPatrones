using Shared;
public class CreadorEnvioRefrigerado : ICreadorEnvio
    {
        private readonly float _peso;
        private readonly string _dimensiones;
        private readonly float _distanciaKm;
        private readonly float _temperatura;

        public CreadorEnvioRefrigerado(float peso, string dimensiones, float distanciaKm, float temperatura)
        {
            _peso = peso;
            _dimensiones = dimensiones;
            _distanciaKm = distanciaKm;
            _temperatura = temperatura;
        }

        public override IEnvio CrearEnvio() =>
            new EnvioRefrigerado(_peso, _dimensiones, _distanciaKm, _temperatura);
    }