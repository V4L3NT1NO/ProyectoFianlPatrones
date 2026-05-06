public class Incidencia
{
    public string Descripcion { get; set; }
    public string Nivel { get; set; }

    public Incidencia(string descripcion, string nivel)
    {
        Descripcion = descripcion;
        Nivel = nivel;
    }

    public override string ToString() => $"[{Nivel.ToString().ToUpper()}] {Descripcion}";
}