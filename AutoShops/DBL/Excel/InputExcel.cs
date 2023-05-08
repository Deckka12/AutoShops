using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoShops.DBL.Excel
{
    public static class InputExcel
    {
        public static void Input (DataGridView dataGridView1) {
            string fileCSV = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.csv)|*.csv|All files(*.*)|*.*";
            if(saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            for(int j = 0; j < dataGridView1.ColumnCount; j++)
            {
                fileCSV += (dataGridView1.Columns[j].HeaderText).ToString() + ";";
            }
            fileCSV += "\t\n";
            for(int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                for(int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    fileCSV += ( dataGridView1[j, i].Value ).ToString() + ";";
                }
                fileCSV += "\t\n";
            }
            StreamWriter wr = new StreamWriter(saveFileDialog.FileName, false, Encoding.GetEncoding("windows-1251"));
            wr.Write(fileCSV);
            wr.Close();
        }
    }
}
