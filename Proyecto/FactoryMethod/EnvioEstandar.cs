using Shared;
public class EnvioEstandar : IEnvio
{
    public float Peso { get; set; }
    public string Dimensiones { get; set; }
    public float DistanciaKm { get; set; }
    public int EnviosMensuales { get; set; }
    public string PaisDestino { get; set; }

    public EnvioEstandar(float peso, string dimensiones, float distanciaKm)
    {
        Peso = peso;
        Dimensiones = dimensiones;
        DistanciaKm = distanciaKm;
    }

    public string ObtenerInfo() =>
        $"[Estándar] Peso: {Peso}kg | Dimensiones: {Dimensiones}";
}