class DistribucionLocal : IBuilderDespacho
{
    private Despacho despacho;

    public DistribucionLocal(Despacho despacho)
    {
        this.despacho = despacho;
    }

    public Despacho build()
    {
        this.identificador();
        this.descripcion();
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

    

    public void reset()
    {
        despacho.contenido = "";
    }


}