public class EnvioConfig
{
    public float Peso { get; set; }
    public string Dimensiones { get; set; }
    public float DistanciaKm { get; set; }
    public string PaisDestino { get; set; }

    public Cliente cliente { get; set; }

    public float? MontoAsegurado { get; set; }
    public float? Temperatura { get; set; }

    
}