using Shared;
public class EnvioRefrigerado : Envio
{
    

    private EnvioConfig configEnvio;

    private IEstrategiaCalculo estrategiaCalculo = new CalculoEstandar();

    public EnvioRefrigerado(EnvioConfig config)
    {
        this.configEnvio = config;
    }

    public override string ObtenerInfo()
    {
        var peso = configEnvio.Peso;
        var dimen = configEnvio.Dimensiones;
        var dist = configEnvio.DistanciaKm;
        var temp = configEnvio.Temperatura;

        return $"[Refrigerado] Peso: {peso}kg | Dimensiones: {dimen} | Distancia: {dist}km | Temperatura: {temp}°C";
    }

    public override EnvioConfig getConfig()
    {
        return this.configEnvio;
    }

    public override float getPeso()
    {
        return this.configEnvio.Peso;
    }
 
    public override string getDimensiones()
    {
        return this.configEnvio.Dimensiones;
    }

    public override float CalcularCosto()
    {

        var clienteActual =  this.configEnvio.cliente;
        var contratoActual =clienteActual.Contrato.GetType();

        

        if(diccioario.mapaEstrategias.TryGetValue(contratoActual, out var estrategia)){
            this.setStrategy(estrategia);

        }else
        {
            Console.WriteLine("Tipo de contrato no soportado para calculos, por defecto se usó el calculo estandar");
            this.setStrategy(new CalculoEstandar());
        }





        return this.estrategiaCalculo.CalcularCosto(this,clienteActual);
    }

    public override void setStrategy(IEstrategiaCalculo estrategia)
    {
        this.estrategiaCalculo = estrategia;
    }
}