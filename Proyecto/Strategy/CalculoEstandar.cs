public class CalculoEstandar : IEstrategiaCalculo
    {
        private const float TarifaPorKm = 0.5f;
        private const float CargaBasePorKg = 2.0f;

        public float CalcularCosto(Envio envio)
        {
            float costo = (TarifaPorKm * envio.DistanciaKm) + (CargaBasePorKg * envio.Peso);
            Console.WriteLine($"  [Estándar] {envio.DistanciaKm}km × {TarifaPorKm} + {envio.Peso}kg × {CargaBasePorKg} = {costo}");
            return costo;
        }
    }