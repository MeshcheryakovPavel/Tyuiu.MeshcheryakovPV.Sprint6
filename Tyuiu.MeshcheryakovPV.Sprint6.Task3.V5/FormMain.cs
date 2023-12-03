using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MeshcheryakovPV.Sprint6.Task3.V5.Lib;

namespace Tyuiu.MeshcheryakovPV.Sprint6.Task3.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] { { 30, -20,   7,  -8,  9 },
 { 32,  17, -14 , -7 , 33 },
 { 19, -19, -13,  14 ,-20 },
 { 11,  30, -1,  26 ,  6},
 { 30 ,-15 ,-20 , -5 , 15}};
        private void buttonDone_LMV_Click(object sender, EventArgs e)
        {
            int[,] matres = ds.Calculate(matrix);
            int n = matres.GetLength(0);
            int m = matres.GetLength(1);
            dataGridViewRes_LMV.ColumnCount = m;
            dataGridViewRes_LMV.RowCount = n;
            for (int i = 0; i < m; i++)
            {
                dataGridViewRes_LMV.Columns[i].Width = 25;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dataGridViewRes_LMV.Rows[i].Cells[j].Value = Convert.ToString(matres[i, j]);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            dataGridViewInPut_LMV.ColumnCount = m;
            dataGridViewInPut_LMV.RowCount = n;
            for (int i = 0; i < m; i++)
            {
                dataGridViewInPut_LMV.Columns[i].Width = 25;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dataGridViewInPut_LMV.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonHelp_LMV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПб-23-2 Мещеряков Павел Викторович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
