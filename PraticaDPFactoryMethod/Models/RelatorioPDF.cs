namespace PraticaDPFactoryMethod.Models
{
    public class RelatorioPDF : Relatorio
    {
        public override void Gerar()
        {
            Console.WriteLine("Gerando relatório em PDF...");
        }
    }
}
