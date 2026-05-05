public abstract class AbstractHandler
{
    protected int NivelMaximo;
    private AbstactHandler _siguiente;

    public AbstractHandler setSiguiente(AbstactHandler siguiente)
    {
        _siguiente = siguiente;
        return siguiente;
    }

    public void manejar(Incidencia incidencia)
    {
        if((int)incidencia.Nivel <= NivelMaximo)
        {
            resolver(incidencia);
        }else if (_siguiente != null)
        {
            Console.WriteLine($"  → {GetType().Name} no tiene autoridad. Escalando...");
            _siguiente.manejar(incidencia);
        }else
        {
            Console.WriteLine($"Ningún manejador pudo resolver: {incidencia}");
        }
    }

    protected abstract void resolver(Incidencia incidencia);
}