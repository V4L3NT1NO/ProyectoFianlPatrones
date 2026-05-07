public class DiccionarioEstrategiaContrato

{
    public Dictionary<Type, IEstrategiaCalculo> mapaEstrategias = new Dictionary<Type, IEstrategiaCalculo>
    {
        { typeof(Contratoestandar), new CalculoEstandar() },
        { typeof(ContratoInternacional), new CalculoInternacional() },
        { typeof(ContratoCoorporativo), new CalculoCorporativo() }
    };
    
}