using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MeshcheryakovPV.Sprint6.Task2.V14.Lib;

namespace Tyuiu.MeshcheryakovPV.Sprint6.Task2.V14
{
    public partial class FormMain_MPV : Form
    {
        DataService ds = new DataService();
        public FormMain_MPV()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDone_MPV_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart_MPV.Text);
                int stop = Convert.ToInt32(textBoxStop_MPV.Text);
                int len = ds.GetMassFunction(start, stop).Length;
                double[] valueA = new double[len];
                valueA = ds.GetMassFunction(start, stop);
                this.chartResult_MPV.Titles.Add("График функции (2х-3/Cos(x)-2x)+5x-6");
                this.chartResult_MPV.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartResult_MPV.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewXY_MPV.Rows.Add(Convert.ToString(start), Convert.ToString(valueA[i]));
                    this.chartResult_MPV.Series[0].Points.AddXY(start, valueA[i]);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_MPV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-23-2 Мещеряков Павел Викторович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxStart_MPV_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStart_MPV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonDone_MPV_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_MPV.BackColor = Color.Red;
        }

        private void buttonDone_MPV_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_MPV.BackColor = Color.Green;
        }

        private void buttonDone_MPV_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_MPV.BackColor = Color.Blue;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
