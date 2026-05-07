public abstract class ContratoCliente
{
    public string Nombre { get; set; }
    public string descripcion { get; }

    public ContratoCliente(string nombre, string descripcion)
    {
        Nombre = nombre;
        this.descripcion = descripcion;
    }
}
