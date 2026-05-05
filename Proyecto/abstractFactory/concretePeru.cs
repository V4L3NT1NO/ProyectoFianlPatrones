class concretePeru: IAbstractFactoryPais
{
    public IAlmacen crearAlmacen()
    {
        return new almacenPeru();
    }

    public IEtiqueta crearEtiquetaSeguimiento()
    {
        return new etiquetaPeru();
    }

    public IVehiculo crearVehiculo()
    {
        return new vehiculoPeru();
    }
}