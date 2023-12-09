using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.MeshcheryakovPV.Sprint6.Task5.V25.Lib; 

namespace Tyuiu.MeshcheryakovPV.Sprint6.Task5.V25
{
    public partial class FormMain_MPV : Form
    {
        public FormMain_MPV()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\pavel\source\repos\Tyuiu.MeshcheryakovPV.Sprint6\Tyuiu.MeshcheryakovPV.Sprint6.Task5.V25\bin\Debug\InPutFileTask5V25.txt";

        private void buttonHelp_MPV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПб-23-2 Мещеряков Павел Викторович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonHelp_MPV_MouseMove(object sender, MouseEventArgs e)
        {
            buttonHelp_MPV.Cursor = System.Windows.Forms.Cursors.Hand;
        }
        private void buttonDo_MPV_MouseMove(object sender, MouseEventArgs e)
        {
            buttonDo_MPV.Cursor = System.Windows.Forms.Cursors.Hand;
        }
        private void buttonOpen_MPV_MouseMove(object sender, MouseEventArgs e)
        {
            buttonOpen_MPV.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void buttonDo_MPV_Click(object sender, EventArgs e)
        {
            dataGridViewNums_MPV.ColumnCount = 2;
            dataGridViewNums_MPV.Columns[0].Width = 20;
            dataGridViewNums_MPV.Columns[1].Width = 50;

            this.chartDiag_MPV.ChartAreas[0].AxisX.Title = " Ось X";
            this.chartDiag_MPV.ChartAreas[0].AxisY.Title = " Ось Y";

            chartDiag_MPV.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_MPV.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_MPV.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }

        private void buttonOpen_MPV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
