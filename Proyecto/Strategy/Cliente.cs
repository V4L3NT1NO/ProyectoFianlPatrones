public class Cliente
{
    public string Nombre { get; set; }
    public string Direccion { get; set; }

    public int NumEnviosMensuales {get; set;}

    public ContratoCliente Contrato { get; set; }



    public Cliente(string nombre, string direccion, int numEnviosMensuales)
    {
        Nombre = nombre;
        Direccion = direccion;
        NumEnviosMensuales = numEnviosMensuales;
    }

    public void AsignarContrato(ContratoCliente contrato)
    {
        this.Contrato = contrato;
    }
    
}