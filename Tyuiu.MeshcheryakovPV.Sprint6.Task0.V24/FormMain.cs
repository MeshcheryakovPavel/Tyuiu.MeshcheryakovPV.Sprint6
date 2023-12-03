using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MeshcheryakovPV.Sprint6.Task0.V24.Lib;

namespace Tyuiu.MeshcheryakovPV.Sprint6.Task0.V24
{
    public partial class FormMain : Form
        {
            public FormMain()
            {
                InitializeComponent();
            }

            private void FormMain_Load(object sender, EventArgs e)
            {

            }

            private void buttonDone_MVP_Click(object sender, EventArgs e)
            {
                DataService ds = new DataService();
                try
                {
                    textBoxResult_MVP.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_MVP.Text)));
                }
                catch
                {
                    MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            private void buttonStudent_MVP_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Выполнил студент иипб 23-2 Мещеряков Павел Викторович", "Сообщение", MessageBoxButtons.OK);
            }

            private void TextBoxVarX_KeyPress(object sender, KeyPressEventArgs e)
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
                {
                    e.Handled = true;
                }
            }
        }
    }