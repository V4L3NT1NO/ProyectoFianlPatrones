interface IBuilderDespacho
{
    void identificador();
    void descripcion();
    void reset();
    void instruccionesManejo();
    void DocumentacionAduanera();
    void seguroTransito();

    Despacho build();

}