using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.MeshcheryakovPV.Sprint6.Task6.V20
{
    public partial class FormAbout_MVP : Form
    {
        public FormAbout_MVP()
        {
            InitializeComponent();
        }

        private void buttonOk_MVP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxInfo_MVP_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).SelectionStart = 0;
        }
    }
}
