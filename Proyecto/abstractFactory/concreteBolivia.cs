class concreteBolivia : IAbstractFactoryPais
{
    public IVehiculo crearVehiculo()
    {
        return new vehiculoBolivia();
    }
    public IAlmacen crearAlmacen()
    {
        return new almacenBolivia();
    }
    public IEtiqueta crearEtiquetaSeguimiento()
    {
        return new etiquetaBolivia();
    }
}