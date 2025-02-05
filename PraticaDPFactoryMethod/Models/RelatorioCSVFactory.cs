namespace PraticaDPFactoryMethod.Models
{
    public class RelatorioCSVFactory : RelatorioFactory
    {
        public override Relatorio CriarRelatorio()
        {
            return new RelatorioCSV();
        }
    }
}
