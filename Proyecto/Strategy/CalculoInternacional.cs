using Shared;
public class CalculoInternacional : IEstrategiaCalculo
    {
        private readonly Dictionary<string, float> _aranceles = new()
        {
            { "Argentina", 0.15f },
            { "Brasil",    0.20f },
            { "Chile",     0.12f }
        };

        public float CalcularCosto(IEnvio envio)
        {
            float tarifaBase = 0.6f * envio.DistanciaKm + 2.5f * envio.Peso;
            float arancel = _aranceles.TryGetValue(envio.PaisDestino, out float tasa) ? tasa : 0.18f;
            float gastoAduana = 50f;
            float costo = tarifaBase + (tarifaBase * arancel) + gastoAduana;
            Console.WriteLine($"  [Internacional] Base={tarifaBase:F2}, Arancel={arancel * 100}%, Aduana={gastoAduana}, Total={costo:F2}");
            return costo;
        }
    }