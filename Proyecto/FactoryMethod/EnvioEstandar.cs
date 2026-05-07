using Shared;
using CompositeF;
public class EnvioEstandar : Envio
{
   
    private EnvioConfig configEnvio;

    private IEstrategiaCalculo estrategiaCalculo = new CalculoEstandar();
    public CamIntermedio comonenteCaminio = new CamIntermedio();


    public EnvioEstandar(EnvioConfig config)
    {
        this.configEnvio = config;
    }

    public override string ObtenerInfo()
    {
        var peso = configEnvio.Peso;
        var dimen = configEnvio.Dimensiones;
        var dist = configEnvio.DistanciaKm;

        return $"[Estandar] Peso: {peso}kg | Dimensiones: {dimen} | Distancia: {dist}km";
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

        
        var Resultado1 = this.comonenteCaminio.SumaCosto(); 
        var resultado2 = this.estrategiaCalculo.CalcularCosto(this,clienteActual);

        




        return Resultado1 + resultado2;
    }

    public override void setStrategy(IEstrategiaCalculo estrategia)
    {
        this.estrategiaCalculo = estrategia;
    }
    public override void agregarComponenteCaminio(IComponenteCamino componente)
    {
        this.comonenteCaminio.AñadirComponente(componente);
    }
    
}