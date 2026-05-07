using Shared;
public class CalculoEstandar : IEstrategiaCalculo
{
    private const float TarifaPorKm = 0.5f;
    private const float CargaBasePorKg = 2.0f;

    public float CalcularCosto(Envio envio, Cliente cliente)
    {
        var config = envio.getConfig();
        float costo = (TarifaPorKm * config.DistanciaKm) + (CargaBasePorKg * config.Peso);
        Console.WriteLine($"  [Estándar] {config.DistanciaKm}km × {TarifaPorKm} + {config.Peso}kg × {CargaBasePorKg} = {costo}");
        return costo;
    }
}








