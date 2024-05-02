using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using OfficeOpenXml.Drawing.Chart;
using OfficeOpenXml.Style;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Act5new
{
    public class ExcelReportGenerator
    {
        // Method to generate an Excel template based on the provided DataTable
        public static byte[] GenerateExcelTemplate(DataTable dataTable)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                // Add header with company name and logo
                worksheet.Cells["C1"].Value = "Al's Rare Vinyl Records"; // Changed cell position
                worksheet.Cells["C1:G1"].Merge = true; // Merge cells for the header
                worksheet.Cells["C1"].Style.Font.Bold = true;
                worksheet.Cells["C1"].Style.Font.Size = 16;
                worksheet.Cells["C1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells["C1"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                // Add logo
                string logoPath = @"D:\ACADEMIX\2nd sem\EDP\Act5new\vinyl1.png";
                if (File.Exists(logoPath))
                {
                    // Add a shape behind the logo and set its fill color
                    ExcelShape backgroundShape = worksheet.Drawings.AddShape("Background", eShapeStyle.Rect);
                    backgroundShape.SetPosition(0, 0);
                    backgroundShape.SetSize(100, 100);
                    backgroundShape.Border.Fill.Color = Color.Transparent; // Optional: make the border transparent

                    // Add logo
                    var logo = worksheet.Drawings.AddPicture("Logo", new FileInfo(logoPath));
                    logo.SetPosition(0, 0);
                    logo.SetSize(100, 100);
                }

                // Add name placeholder above the signature
                worksheet.Cells[dataTable.Rows.Count + 3 - 7, 3].Value = "Name:"; // New cell for name, adjusted position
                worksheet.Cells[dataTable.Rows.Count + 3 - 7, 3, dataTable.Rows.Count + 3 - 7, 6].Merge = true; // Merge cells for "Name:"
                worksheet.Cells[dataTable.Rows.Count + 3 - 7, 3].Style.Font.Bold = true;

                // Add signature placeholder
                worksheet.Cells[dataTable.Rows.Count + 4 - 7, 3].Value = "Signature:";
                worksheet.Cells[dataTable.Rows.Count + 4 - 7, 3, dataTable.Rows.Count + 4 - 7, 6].Merge = true; // Merge cells for "Name:"
                worksheet.Cells[dataTable.Rows.Count + 4 - 7, 3].Style.Font.Bold = true;

                // Move the "Name" and "Signature" cells two cells to the right
                worksheet.Cells["C1"].Style.VerticalAlignment = ExcelVerticalAlignment.Top; // Align text to the top
                worksheet.Cells["C1:C" + (dataTable.Rows.Count + 5 - 7)].Style.VerticalAlignment = ExcelVerticalAlignment.Top; // Align text to the top

                // Add a new worksheet for the graph
                ExcelWorksheet graphWorksheet = excelPackage.Workbook.Worksheets.Add("Graph");

                // Add data to the graph worksheet and create a chart
                graphWorksheet.Cells["A1"].Value = "OrderID";
                graphWorksheet.Cells["B1"].Value = "TotalAmount";

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    graphWorksheet.Cells[i + 2, 1].Value = dataTable.Rows[i]["OrderID"];
                    graphWorksheet.Cells[i + 2, 2].Value = dataTable.Rows[i]["TotalAmount"];
                }

                // Create a chart using the data
                var chart = graphWorksheet.Drawings.AddChart("Chart", eChartType.ColumnClustered);
                chart.SetPosition(1, 0, 4, 0);
                chart.SetSize(600, 400);
                chart.Title.Text = "Total Amount per Order";
                chart.Series.Add(graphWorksheet.Cells["B2:B" + (dataTable.Rows.Count + 1)], graphWorksheet.Cells["A2:A" + (dataTable.Rows.Count + 1)]);

                // Save the Excel file
                return excelPackage.GetAsByteArray();
            }
        }

        // Method to generate the Excel report (unchanged from your original implementation)
        public static void GenerateExcelReport(DataTable dataTable)
        {
            byte[] excelBytes = GenerateExcelTemplate(dataTable);

            // Save the Excel file
            string filePath = @"D:\ACADEMIX\2nd sem\ExcelReport.xlsx";
            File.WriteAllBytes(filePath, excelBytes);

            MessageBox.Show("Excel report generated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}