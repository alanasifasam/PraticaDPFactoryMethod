namespace PraticaDPFactoryMethod.Models
{
    public class RelatorioCSV : Relatorio
    {
        public override void Gerar()
        {
            Console.WriteLine("Gerando relatório em CSV...");
        }
    }
}
