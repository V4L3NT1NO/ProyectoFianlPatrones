namespace Shared;
using CompositeF;


    public abstract class Envio
    {

        protected DiccionarioEstrategiaContrato diccioario = new DiccionarioEstrategiaContrato();
        public abstract string ObtenerInfo();

        public abstract EnvioConfig getConfig();

        public abstract float getPeso();
        public abstract string getDimensiones();

        public abstract float CalcularCosto();
        public abstract void setStrategy(IEstrategiaCalculo estrategia);

        public abstract void  agregarComponenteCaminio(IComponenteCamino componente);

        
    }
