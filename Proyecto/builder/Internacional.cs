class Internacional : IBuilderDespacho
{
    public Despacho despacho;

    public Internacional()
    {
        this.despacho = new Despacho();
    }

    public Despacho build(){
        return this.despacho;
    }

    public void descripcion()
    {
        this.despacho.contenido += "Despacho Internacional: \n";
        this.despacho.contenido += " - Envío a cualquier parte del mundo.\n";
        this.despacho.contenido += " - Seguimiento en tiempo real.\n";
        this.despacho.contenido += " - Seguro incluido.\n";
    }

    public void identificador()
    {
        this.despacho.contenido += "ID: DESP-INTL-001\n";
    }

    public void reset()
    {
        this.despacho = new Despacho();
    }


    public void instruccionesManejo()
    {
        this.despacho.contenido += "Instrucciones de manejo para despacho internacional:\n";
        this.despacho.contenido += " - Asegúrese de que el paquete esté bien embalado.\n";
        this.despacho.contenido += " - Incluya toda la documentación necesaria para aduanas.\n";
        this.despacho.contenido += " - Verifique las restricciones de envío para el país de destino.\n";
        
    }

    public void DocumentacionAduanera()
    {
        this.despacho.contenido += "Documentación aduanera requerida para despacho internacional:\n";
        this.despacho.contenido += " - Factura comercial.\n";
        this.despacho.contenido += " - Lista de empaque.\n";
        this.despacho.contenido += " - Certificado de origen (si es necesario).\n";
        this.despacho.contenido += " - Documentos de transporte (conocimiento de embarque, guía aérea, etc.).\n";
    }

    public void seguroTransito()
    {
        
    }
}