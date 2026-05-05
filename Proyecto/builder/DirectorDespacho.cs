class DirectorDespacho
{
    private IBuilderDespacho builder;
    public void setBuilder(IBuilderDespacho builder)
    {
        this.builder = builder;
    }

    public Despacho contruirLoacl()
    {
        this.builder.identificador();
        this.builder.descripcion();
        return this.builder.build();

    }

    public Despacho construirInternacional()
    {
        this.builder.identificador();
        this.builder.descripcion();
        this.builder.instruccionesManejo();
        this.builder.DocumentacionAduanera();
       
        return this.builder.build();
    }

    public Despacho construirOrdenAltoValor()
    {
        this.builder.identificador();
        this.builder.descripcion();
        this.builder.instruccionesManejo();
        this.builder.DocumentacionAduanera();
        this.builder.seguroTransito();
        return this.builder.build();
    }
}