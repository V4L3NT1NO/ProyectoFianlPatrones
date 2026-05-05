public class Envio
    {
        public float Peso { get; set; }
        public string Dimensiones { get; set; }
        public float DistanciaKm { get; set; }
        public int EnviosMensuales { get; set; }
        public string PaisDestino { get; set; }
        private IEstrategiaCalculo _estrategia;

        public Envio(float peso, string dimensiones, float distanciaKm)
        {
            Peso = peso;
            Dimensiones = dimensiones;
            DistanciaKm = distanciaKm;
        }

        public void SetEstrategia(IEstrategiaCalculo estrategia)
        {
            _estrategia = estrategia;
        }

        public float CalcularCosto()
        {
            if (_estrategia == null)
                throw new InvalidOperationException("No se ha asignado una estrategia de cálculo.");
            return _estrategia.CalcularCosto(this);
        }
    }