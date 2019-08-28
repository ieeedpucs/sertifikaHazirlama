using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SertifikaHazırlama
{
    public partial class formDGV : Form
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        public formDGV()
        {
            InitializeComponent();
        }

        private void ExcelKaydet_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook worKbooK;
            Microsoft.Office.Interop.Excel.Worksheet workSheet;

            excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = false;
            excel.DisplayAlerts = false;
            worKbooK = excel.Workbooks.Add(Type.Missing);

            workSheet = (Microsoft.Office.Interop.Excel.Worksheet)worKbooK.ActiveSheet;
            workSheet.Name = "Sayfa1";
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                workSheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                workSheet.Range[workSheet.Cells[1, 5], workSheet.Cells[1, 14]].Merge();
            }

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {

                    if (dataGridView1.Rows[i].Cells[j].Value == null)
                    {
                        workSheet.Cells[i + 2, j + 1] = "";
                    }
                    else
                    {
                        workSheet.Range[workSheet.Cells[i+2, 5], workSheet.Cells[i+2, 14]].Merge();
                        workSheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                }
            }
            worKbooK.SaveAs(desktopPath+ "\\Sertifikalar.xlsx");
            worKbooK.Close();
            excel.Quit();
        }
    }
}
