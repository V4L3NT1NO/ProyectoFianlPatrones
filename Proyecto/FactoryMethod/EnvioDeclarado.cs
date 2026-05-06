using Shared;
public class EnvioValorDeclarado : IEnvio
{
    public float Peso { get; set; }
    public string Dimensiones { get; set; }
    public float DistanciaKm { get; set; }
    public int EnviosMensuales { get; set; }
    public string PaisDestino { get; set; }
    public float MontoAsegurado { get; set; }

    public EnvioValorDeclarado(float peso, string dimensiones, float distanciaKm, float montoAsegurado)
    {
        Peso = peso;
        Dimensiones = dimensiones;
        DistanciaKm = distanciaKm;
        MontoAsegurado = montoAsegurado;
    }

    public string ObtenerInfo() =>
        $"[Valor Declarado] Peso: {Peso}kg | Dimensiones: {Dimensiones} | Monto: ${MontoAsegurado}";
}