using ClosedXML.Excel;
using Fretefy.Test.Domain.Entities;
using System.Collections.Generic;
using System.IO;

namespace Fretefy.Test.Domain.Utils
{
    public class ExcelExporter
    {
        public static byte[] ExportarRegioes(IEnumerable<Regiao> regioes)
        {
            using var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Regiões");

            worksheet.Cell(1, 1).Value = "Região";
            worksheet.Cell(1, 2).Value = "Ativo";
            worksheet.Cell(1, 3).Value = "Cidade";
            worksheet.Cell(1, 4).Value = "UF";

            int row = 2;

            foreach (var regiao in regioes)
            {
                worksheet.Cell(row, 1).Value = regiao.Nome;
                worksheet.Cell(row, 2).Value = regiao.Ativo ? "Sim" : "Não";
                foreach (var cidade in regiao.Cidades)
                {
                    worksheet.Cell(row, 3).Value = cidade.Cidade.Nome;
                    worksheet.Cell(row, 4).Value = cidade.Cidade.UF;
                    row++;
                }
            }

            using var stream = new MemoryStream();
            workbook.SaveAs(stream);
            return stream.ToArray();
        }
    }
}
