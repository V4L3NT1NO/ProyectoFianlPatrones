namespace Shared
{
    public interface IEnvio
    {
        float Peso { get; set; }
        string Dimensiones { get; set; }
        float DistanciaKm { get; set; }
        int EnviosMensuales { get; set; }
        string PaisDestino { get; set; }
        string ObtenerInfo();
    }
}