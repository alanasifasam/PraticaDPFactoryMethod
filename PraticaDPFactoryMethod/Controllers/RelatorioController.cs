using Microsoft.AspNetCore.Mvc;
using PraticaDPFactoryMethod.Models;

namespace PraticaDPFactoryMethod.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RelatorioController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            // Criando diferentes fábricas
            RelatorioFactory factoryPDF = new RelatorioPDFFactory();
            RelatorioFactory factoryExcel = new RelatorioExcelFactory();
            RelatorioFactory factoryCSV = new RelatorioCSVFactory();

            // Criando os relatórios
            Relatorio relatorio1 = factoryPDF.CriarRelatorio();
            Relatorio relatorio2 = factoryExcel.CriarRelatorio();
            Relatorio relatorio3 = factoryCSV.CriarRelatorio();

            // Gerando os relatórios
            relatorio1.Gerar();
            relatorio2.Gerar();
            relatorio3.Gerar();

            return Ok();
        }
    }
}
