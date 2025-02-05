namespace PraticaDPFactoryMethod.Models
{
    public class RelatorioPDFFactory : RelatorioFactory
    {
        public override Relatorio CriarRelatorio()
        {
            return new RelatorioPDF();
        }
    }
}
