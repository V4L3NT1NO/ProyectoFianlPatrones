using Shared;
public class CalculoInternacional : IEstrategiaCalculo
    {
        private readonly Dictionary<string, float> _aranceles = new()
        {
            { "Argentina", 0.15f },
            { "Brasil",    0.20f },
            { "Chile",     0.12f }
        };

        public float CalcularCosto(Envio envio, Cliente cliente1)
        {
            var config = envio.getConfig();

            float tarifaBase = 0.6f * config.DistanciaKm + 2.5f * config.Peso;
            float arancel = _aranceles.TryGetValue(config.PaisDestino, out float tasa) ? tasa : 0.18f;
            float gastoAduana = 50f;
            float costo = tarifaBase + (tarifaBase * arancel) + gastoAduana;
            Console.WriteLine($"  [Internacional] Base={tarifaBase:F2}, Arancel={arancel * 100}%, Aduana={gastoAduana}, Total={costo:F2}");
            return costo;
        }
    }