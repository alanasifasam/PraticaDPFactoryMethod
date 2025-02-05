namespace PraticaDPFactoryMethod.Models
{
    public abstract class Relatorio
    {
        //poderia ser interface , é melhor depender de interface do que de classe abstrata. 
        public abstract void Gerar();
    }
}
