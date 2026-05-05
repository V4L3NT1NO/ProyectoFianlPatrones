class DistribucionLocal : IBuilderDespacho
{
    private Despacho despacho;

    public DistribucionLocal(Despacho despacho)
    {
        this.despacho = despacho;
    }

    public Despacho build()
    {
        return this.despacho;
    }

    public void identificador()
    {
        despacho.contenido += "ID: DESP-LOCAL-001\n";
    }

    public void descripcion()
    {
        despacho.contenido += "Descripción: Distribución Local.\n";
    }

    public void instruccionesManejo()
    {
    }

    public void DocumentacionAduanera()
    {
    }

    public void seguroTransito()
    {
    }

    public void reset()
    {
        despacho.contenido = "";
    }


}