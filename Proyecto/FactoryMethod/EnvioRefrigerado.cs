using Shared;
public class EnvioRefrigerado : IEnvio
{
    public float Peso { get; set; }
    public string Dimensiones { get; set; }
    public float DistanciaKm { get; set; }
    public int EnviosMensuales { get; set; }
    public string PaisDestino { get; set; }
    public float Temperatura { get; set; }

    public EnvioRefrigerado(float peso, string dimensiones, float distanciaKm, float temperatura)
    {
        Peso = peso;
        Dimensiones = dimensiones;
        DistanciaKm = distanciaKm;
        Temperatura = temperatura;
    }

    public string ObtenerInfo() =>
        $"[Refrigerado] Peso: {Peso}kg | Dimensiones: {Dimensiones} | Temp: {Temperatura}°C";
}