namespace PraticaDPFactoryMethod.Models
{
    public class RelatorioExcelFactory : RelatorioFactory
    {
        public override Relatorio CriarRelatorio()
        {
            return new RelatorioExcel();
        }
    }
}
