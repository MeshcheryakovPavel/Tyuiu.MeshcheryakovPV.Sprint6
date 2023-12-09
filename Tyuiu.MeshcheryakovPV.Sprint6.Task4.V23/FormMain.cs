using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.MeshcheryakovPV.Sprint6.Task4.V23
{
    public partial class FormMain_MPV : Form
    {
        public FormMain_MPV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПб-23-2 Мещеряков Павел Викторович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
