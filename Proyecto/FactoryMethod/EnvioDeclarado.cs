using Shared;
using CompositeF;
public class EnvioValorDeclarado : Envio
{
    private EnvioConfig configEnvio ;

    public CamIntermedio comonenteCaminio = new CamIntermedio();


    


    private IEstrategiaCalculo estrategiaCalculo = new CalculoEstandar();
    public EnvioValorDeclarado(EnvioConfig config)
    {
        this.configEnvio = config;
    }

    public override void agregarComponenteCaminio(IComponenteCamino componente)
    {
        this.comonenteCaminio.AñadirComponente(componente);
    }
    

    

    public override string ObtenerInfo(){
        var peso = this.configEnvio.Peso;
        var dimen = this.configEnvio.Dimensiones;
        var dist = this.configEnvio.DistanciaKm;
        var monto = this.configEnvio.MontoAsegurado;


        return $"[Valor Declarado] Peso: {peso}kg | Dimensiones: {dimen} | Distancia: {dist}km | Monto Asegurado: ${monto}";
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

        }
        else
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
}