class concreteChile : IAbstractFactoryPais
{
    
    public IVehiculo crearVehiculo()
    {
        return new vehiculoChile();
    }
    public IAlmacen crearAlmacen()
    {
        return new almacenChile();
    }
    public IEtiqueta crearEtiquetaSeguimiento()
    {
        return new etiquetaChile();
    }
}