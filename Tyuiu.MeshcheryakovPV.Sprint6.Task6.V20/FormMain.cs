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
using Tyuiu.MeshcheryakovPV.Sprint6.Task6.V20.Lib;

namespace Tyuiu.MeshcheryakovPV.Sprint6.Task6.V20
{
    public partial class FormMain_MPV : Form
    {
        public FormMain_MPV()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();

        private void buttonHelp_MPV_Click(object sender, EventArgs e)
        {
            FormAbout_MPV formAbout = new FormAbout_MPV();
            formAbout.ShowDialog();
        }



        private void buttonDo_MPV_Click(object sender, EventArgs e)
        {
            textBoxResult_MPV.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonOpenFile_MPV_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTask_MPV.ShowDialog();
                openFilePath = openFileDialogTask_MPV.FileName;
                textBoxInput_MPV.Text = File.ReadAllText(openFilePath);
                groupBoxOutput_MPV.Text = groupBoxOutput_MPV.Text + " " + openFileDialogTask_MPV.FileName;
                buttonDo_MPV.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Выберите файл :(", "Пожалуйста!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
