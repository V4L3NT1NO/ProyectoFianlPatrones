using Shared;
public class CreadorEnvioValorDeclarado : ICreadorEnvio
    {
        private readonly float _peso;
        private readonly string _dimensiones;
        private readonly float _distanciaKm;
        private readonly float _montoAsegurado;

        public CreadorEnvioValorDeclarado(float peso, string dimensiones, float distanciaKm, float montoAsegurado)
        {
            _peso = peso;
            _dimensiones = dimensiones;
            _distanciaKm = distanciaKm;
            _montoAsegurado = montoAsegurado;
        }

        public override IEnvio CrearEnvio() =>
            new EnvioValorDeclarado(_peso, _dimensiones, _distanciaKm, _montoAsegurado);
    }