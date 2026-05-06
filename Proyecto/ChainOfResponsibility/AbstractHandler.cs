public abstract class AbstractHandler
{
    protected string NivelMaximo;
    private AbstractHandler _siguiente;

    public AbstractHandler setSiguiente(AbstractHandler siguiente)
    {
        _siguiente = siguiente;
        return siguiente;
    }

    public void manejar(Incidencia incidencia)
    {
        if (this.resolver(incidencia))
        {
            
        }
        else
        {
            if (_siguiente != null)
            {
                _siguiente.manejar(incidencia);
            }
            else
            {
                Console.WriteLine($"Nadie pudo resolver: {incidencia}");
            }
        }
        
    }

    protected abstract bool resolver(Incidencia incidencia);
}