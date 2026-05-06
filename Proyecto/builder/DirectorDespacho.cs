class DirectorDespacho
{
    private IBuilderDespacho builder;
    public void setBuilder(IBuilderDespacho builder)
    {
        this.builder = builder;
    }

    public Despacho contruir()
    {
        if(builder == null)
        {
            throw new Exception("No se ha asignado un builder");
        }
        return this.builder.build();
    }
}