namespace Tyuiu.MeshcheryakovPV.Sprint6.Task3.V5
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_MPV = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxResult_MPV = new System.Windows.Forms.GroupBox();
            this.dataGridViewRes_MPV = new System.Windows.Forms.DataGridView();
            this.labelResult_MPV = new System.Windows.Forms.Label();
            this.buttonHelp_MPV = new System.Windows.Forms.Button();
            this.buttonDone_MPV = new System.Windows.Forms.Button();
            this.groupBoxInPut_MPV = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_MPV = new System.Windows.Forms.DataGridView();
            this.labelInPut_MPV = new System.Windows.Forms.Label();
            this.groupBoxTask_MPV.SuspendLayout();
            this.groupBoxResult_MPV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_MPV)).BeginInit();
            this.groupBoxInPut_MPV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_MPV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_MPV
            // 
            this.groupBoxTask_MPV.Controls.Add(this.textBox1);
            this.groupBoxTask_MPV.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_MPV.Name = "groupBoxTask_MPV";
            this.groupBoxTask_MPV.Size = new System.Drawing.Size(277, 425);
            this.groupBoxTask_MPV.TabIndex = 0;
            this.groupBoxTask_MPV.TabStop = false;
            this.groupBoxTask_MPV.Text = "Условие";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(264, 393);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBoxResult_MPV
            // 
            this.groupBoxResult_MPV.Controls.Add(this.labelResult_MPV);
            this.groupBoxResult_MPV.Controls.Add(this.dataGridViewRes_MPV);
            this.groupBoxResult_MPV.Location = new System.Drawing.Point(553, 12);
            this.groupBoxResult_MPV.Name = "groupBoxResult_MPV";
            this.groupBoxResult_MPV.Size = new System.Drawing.Size(235, 381);
            this.groupBoxResult_MPV.TabIndex = 1;
            this.groupBoxResult_MPV.TabStop = false;
            this.groupBoxResult_MPV.Text = "Вывод данных";
            // 
            // dataGridViewRes_MPV
            // 
            this.dataGridViewRes_MPV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_MPV.ColumnHeadersVisible = false;
            this.dataGridViewRes_MPV.Location = new System.Drawing.Point(22, 76);
            this.dataGridViewRes_MPV.Name = "dataGridViewRes_MPV";
            this.dataGridViewRes_MPV.RowHeadersVisible = false;
            this.dataGridViewRes_MPV.RowHeadersWidth = 62;
            this.dataGridViewRes_MPV.RowTemplate.Height = 28;
            this.dataGridViewRes_MPV.Size = new System.Drawing.Size(194, 225);
            this.dataGridViewRes_MPV.TabIndex = 0;
            // 
            // labelResult_MPV
            // 
            this.labelResult_MPV.AutoSize = true;
            this.labelResult_MPV.Location = new System.Drawing.Point(65, 39);
            this.labelResult_MPV.Name = "labelResult_MPV";
            this.labelResult_MPV.Size = new System.Drawing.Size(93, 20);
            this.labelResult_MPV.TabIndex = 1;
            this.labelResult_MPV.Text = "Результат:";
            // 
            // buttonHelp_MPV
            // 
            this.buttonHelp_MPV.Location = new System.Drawing.Point(606, 399);
            this.buttonHelp_MPV.Name = "buttonHelp_MPV";
            this.buttonHelp_MPV.Size = new System.Drawing.Size(37, 39);
            this.buttonHelp_MPV.TabIndex = 2;
            this.buttonHelp_MPV.Text = " ? ";
            this.buttonHelp_MPV.UseVisualStyleBackColor = true;
         
            // 
            // buttonDone_MPV
            // 
            this.buttonDone_MPV.Location = new System.Drawing.Point(649, 399);
            this.buttonDone_MPV.Name = "buttonDone_MPV";
            this.buttonDone_MPV.Size = new System.Drawing.Size(139, 39);
            this.buttonDone_MPV.TabIndex = 3;
            this.buttonDone_MPV.Text = "Выполнить";
            this.buttonDone_MPV.UseVisualStyleBackColor = true;

            // 
            // groupBoxInPut_MPV
            // 
            this.groupBoxInPut_MPV.Controls.Add(this.labelInPut_MPV);
            this.groupBoxInPut_MPV.Controls.Add(this.dataGridViewInPut_MPV);
            this.groupBoxInPut_MPV.Location = new System.Drawing.Point(297, 13);
            this.groupBoxInPut_MPV.Name = "groupBoxInPut_MPV";
            this.groupBoxInPut_MPV.Size = new System.Drawing.Size(250, 380);
            this.groupBoxInPut_MPV.TabIndex = 4;
            this.groupBoxInPut_MPV.TabStop = false;
            this.groupBoxInPut_MPV.Text = "Исходные данные";
            // 
            // dataGridViewInPut_MPV
            // 
            this.dataGridViewInPut_MPV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_MPV.ColumnHeadersVisible = false;
            this.dataGridViewInPut_MPV.Location = new System.Drawing.Point(23, 75);
            this.dataGridViewInPut_MPV.Name = "dataGridViewInPut_MPV";
            this.dataGridViewInPut_MPV.RowHeadersVisible = false;
            this.dataGridViewInPut_MPV.RowHeadersWidth = 62;
            this.dataGridViewInPut_MPV.RowTemplate.Height = 28;
            this.dataGridViewInPut_MPV.Size = new System.Drawing.Size(194, 225);
            this.dataGridViewInPut_MPV.TabIndex = 0;
            // 
            // labelInPut_MPV
            // 
            this.labelInPut_MPV.AutoSize = true;
            this.labelInPut_MPV.Location = new System.Drawing.Point(77, 38);
            this.labelInPut_MPV.Name = "labelInPut_MPV";
            this.labelInPut_MPV.Size = new System.Drawing.Size(80, 20);
            this.labelInPut_MPV.TabIndex = 1;
            this.labelInPut_MPV.Text = "Матрица:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxInPut_MPV);
            this.Controls.Add(this.buttonDone_MPV);
            this.Controls.Add(this.buttonHelp_MPV);
            this.Controls.Add(this.groupBoxResult_MPV);
            this.Controls.Add(this.groupBoxTask_MPV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 5 | Мещеряков П.В. ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_MPV.ResumeLayout(false);
            this.groupBoxTask_MPV.PerformLayout();
            this.groupBoxResult_MPV.ResumeLayout(false);
            this.groupBoxResult_MPV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_MPV)).EndInit();
            this.groupBoxInPut_MPV.ResumeLayout(false);
            this.groupBoxInPut_MPV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_MPV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_MPV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxResult_MPV;
        private System.Windows.Forms.Label labelResult_MPV;
        private System.Windows.Forms.DataGridView dataGridViewRes_MPV;
        private System.Windows.Forms.Button buttonHelp_MPV;
        private System.Windows.Forms.Button buttonDone_MPV;
        private System.Windows.Forms.GroupBox groupBoxInPut_MPV;
        private System.Windows.Forms.Label labelInPut_MPV;
        private System.Windows.Forms.DataGridView dataGridViewInPut_MPV;
    }
}

