class OrdenAltoValor : IBuilderDespacho
{
    private Despacho despacho;

    public OrdenAltoValor()
    {
        this.despacho = new Despacho();
    }

    public Despacho build()
    {
        this.identificador();
        this.descripcion();
        this.instruccionesManejo();
        this.DocumentacionAduanera();
        this.seguroTransito();
        return this.despacho;
    }

    public void descripcion()
    {
        this.despacho.contenido += "Descripción: Orden de alto valor. ";
    }

    public void identificador()
    {
        this.despacho.contenido += "ID: ORD-ALTOVALOR-001\n";
    }

    public void reset()
    {
        this.despacho = new Despacho();
    }

    
    public void instruccionesManejo()
    {
        this.despacho.contenido += "Instrucciones de manejo para orden de alto valor:\n";
        this.despacho.contenido += " - Manejar con cuidado extremo.\n";
        this.despacho.contenido += " - Almacenar en un lugar seguro.\n";
        this.despacho.contenido += " - Asegurar el paquete durante el transporte.\n";
    }
    public void DocumentacionAduanera()
    {
        this.despacho.contenido += "Documentación aduanera requerida para orden de alto valor:\n";
        this.despacho.contenido += " - Factura comercial detallada.\n";
        this.despacho.contenido += " - Certificado de autenticidad (si es necesario).\n";
        this.despacho.contenido += " - Documentos de transporte (conocimiento de embarque, guía aérea, etc.).\n";
    }

    public void seguroTransito()
    {
        this.despacho.contenido += "Seguro de tránsito para orden de alto valor:\n";
        this.despacho.contenido += " - Cobertura completa durante el transporte.\n";
        this.despacho.contenido += " - Protección contra pérdida, daño o robo.\n";
        this.despacho.contenido += " - Asistencia en caso de reclamos.\n";
    }
}