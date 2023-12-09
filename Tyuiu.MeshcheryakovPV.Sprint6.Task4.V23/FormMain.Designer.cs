namespace Tyuiu.MeshcheryakovPV.Sprint6.Task4.V23


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxCondition_MPV = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_MPV = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrix_MPV = new System.Windows.Forms.DataGridView();
            this.buttonHelp_MPV = new System.Windows.Forms.Button();
            this.buttonPerform_MPV = new System.Windows.Forms.Button();
            this.groupBoxOutput_MPV = new System.Windows.Forms.GroupBox();
            this.labelResult_MPV = new System.Windows.Forms.Label();
            this.groupBoxCondition_MPV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_MPV)).BeginInit();
            this.groupBoxOutput_MPV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_MPV
            // 
            this.groupBoxCondition_MPV.Controls.Add(this.textBoxCondition_MPV);
            this.groupBoxCondition_MPV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_MPV.Location = new System.Drawing.Point(12, 21);
            this.groupBoxCondition_MPV.Name = "groupBoxCondition_MPV";
            this.groupBoxCondition_MPV.Size = new System.Drawing.Size(559, 383);
            this.groupBoxCondition_MPV.TabIndex = 6;
            this.groupBoxCondition_MPV.TabStop = false;
            this.groupBoxCondition_MPV.Text = "Условие";
            // 
            // textBoxCondition_MPV
            // 
            this.textBoxCondition_MPV.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCondition_MPV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition_MPV.Location = new System.Drawing.Point(6, 26);
            this.textBoxCondition_MPV.Multiline = true;
            this.textBoxCondition_MPV.Name = "textBoxCondition_MPV";
            this.textBoxCondition_MPV.Size = new System.Drawing.Size(479, 321);
            this.textBoxCondition_MPV.TabIndex = 0;
            this.textBoxCondition_MPV.Text = resources.GetString("textBoxCondition_MPV.Text");
            // 
            // dataGridViewMatrix_MPV
            // 
            this.dataGridViewMatrix_MPV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_MPV.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_MPV.Location = new System.Drawing.Point(23, 80);
            this.dataGridViewMatrix_MPV.Name = "dataGridViewMatrix_MPV";
            this.dataGridViewMatrix_MPV.RowHeadersVisible = false;
            this.dataGridViewMatrix_MPV.RowHeadersWidth = 51;
            this.dataGridViewMatrix_MPV.RowTemplate.Height = 24;
            this.dataGridViewMatrix_MPV.Size = new System.Drawing.Size(325, 297);
            this.dataGridViewMatrix_MPV.TabIndex = 7;
            // 
            // buttonHelp_MPV
            // 
            this.buttonHelp_MPV.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonHelp_MPV.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonHelp_MPV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_MPV.Location = new System.Drawing.Point(763, 523);
            this.buttonHelp_MPV.Name = "buttonHelp_MPV";
            this.buttonHelp_MPV.Size = new System.Drawing.Size(49, 43);
            this.buttonHelp_MPV.TabIndex = 10;
            this.buttonHelp_MPV.Text = "?";
            this.buttonHelp_MPV.UseVisualStyleBackColor = false;
            this.buttonHelp_MPV.Click += new System.EventHandler(this.buttonHelp_MPV_Click);
            // 
            // buttonPerform_MPV
            // 
            this.buttonPerform_MPV.BackColor = System.Drawing.SystemColors.Control;
            this.buttonPerform_MPV.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonPerform_MPV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPerform_MPV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPerform_MPV.Location = new System.Drawing.Point(846, 523);
            this.buttonPerform_MPV.Name = "buttonPerform_MPV";
            this.buttonPerform_MPV.Size = new System.Drawing.Size(160, 43);
            this.buttonPerform_MPV.TabIndex = 9;
            this.buttonPerform_MPV.Text = "Выполнить";
            this.buttonPerform_MPV.UseVisualStyleBackColor = false;
            this.buttonPerform_MPV.Click += new System.EventHandler(this.buttonPerform_MPV_Click);
            // 
            // groupBoxOutput_MPV
            // 
            this.groupBoxOutput_MPV.Controls.Add(this.labelResult_MPV);
            this.groupBoxOutput_MPV.Controls.Add(this.dataGridViewMatrix_MPV);
            this.groupBoxOutput_MPV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutput_MPV.Location = new System.Drawing.Point(616, 21);
            this.groupBoxOutput_MPV.Name = "groupBoxOutput_MPV";
            this.groupBoxOutput_MPV.Size = new System.Drawing.Size(390, 406);
            this.groupBoxOutput_MPV.TabIndex = 8;
            this.groupBoxOutput_MPV.TabStop = false;
            this.groupBoxOutput_MPV.Text = "Вывод данных";
            // 
            // labelResult_MPV
            // 
            this.labelResult_MPV.AutoSize = true;
            this.labelResult_MPV.Location = new System.Drawing.Point(9, 38);
            this.labelResult_MPV.Name = "labelResult_MPV";
            this.labelResult_MPV.Size = new System.Drawing.Size(100, 22);
            this.labelResult_MPV.TabIndex = 1;
            this.labelResult_MPV.Text = "Результат:";
            // 
            // FormMain_MPV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 593);
            this.Controls.Add(this.buttonHelp_MPV);
            this.Controls.Add(this.buttonPerform_MPV);
            this.Controls.Add(this.groupBoxOutput_MPV);
            this.Controls.Add(this.groupBoxCondition_MPV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_MPV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 23 | Мещеряков П.В.";
            this.groupBoxCondition_MPV.ResumeLayout(false);
            this.groupBoxCondition_MPV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_MPV)).EndInit();
            this.groupBoxOutput_MPV.ResumeLayout(false);
            this.groupBoxOutput_MPV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_MPV;
        private System.Windows.Forms.TextBox textBoxCondition_MPV;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_MPV;
        private System.Windows.Forms.Button buttonHelp_MPV;
        private System.Windows.Forms.Button buttonPerform_MPV;
        private System.Windows.Forms.GroupBox groupBoxOutput_MPV;
        private System.Windows.Forms.Label labelResult_MPV;
    }
}
