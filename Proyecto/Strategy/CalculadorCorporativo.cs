


using Shared;
public class CalculoCorporativo : IEstrategiaCalculo
{
    public float CalcularCosto(Envio envio, Cliente cliente)
    {
        var config = envio.getConfig();
        
        float tarifaBase = 0.4f * config.DistanciaKm + 1.5f * config.Peso;
        float descuento = ObtenerDescuento(cliente.NumEnviosMensuales); //numDeEnvioMensuales
        float costo = tarifaBase * (1 - descuento);
        Console.WriteLine($"  [Corporativo] Base={tarifaBase:F2}, Descuento={descuento * 100}%, Total={costo:F2}");
        return costo;
    }

    private float ObtenerDescuento(int enviosMensuales)
    {
        if (enviosMensuales >= 100) return 0.20f;
        if (enviosMensuales >= 50)  return 0.10f;
        if (enviosMensuales >= 20)  return 0.05f;
        return 0f;
    }
}
