public class Incidencia
{
    public string Descripcion { get; set; }
    public NivelGravedad Nivel { get; set; }

    public Incidencia(string descripcion, NivelGravedad nivel)
    {
        Descripcion = descripcion;
        Nivel = nivel;
    }

    public override string ToString() => $"[{Nivel.ToString().ToUpper()}] {Descripcion}";
}