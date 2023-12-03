namespace Tyuiu.MeshcheryakovPV.Sprint6.Task2.V14
{
    partial class FormMain_MPV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(311, 291);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FormMain_MPV
            // 
            this.ClientSize = new System.Drawing.Size(1128, 532);
            this.Controls.Add(this.comboBox1);
            this.Name = "FormMain_MPV";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_MPV;
        private System.Windows.Forms.GroupBox groupBoxInPut_MPV;
        private System.Windows.Forms.Button buttonHelp_MPV;
        private System.Windows.Forms.Button buttonDone_MPV;
        private System.Windows.Forms.GroupBox groupBoxResult_MPV;
        private System.Windows.Forms.TextBox textBoxTask_MPV;
        private System.Windows.Forms.TextBox textBoxStop_MPV;
        private System.Windows.Forms.TextBox textBoxStart_MPV;
        private System.Windows.Forms.Label labelStop_MPV;
        private System.Windows.Forms.Label labelStart_MPV;
        private System.Windows.Forms.Label labelResult_MPV;
      
        private System.Windows.Forms.DataGridView dataGridViewXY_MPV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnY;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

