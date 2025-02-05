namespace PraticaDPFactoryMethod.Models
{
    public class RelatorioExcel : Relatorio
    {
        public override void Gerar()
        {
            Console.WriteLine("Gerando relatório em Excel...");
        }
    }
}
