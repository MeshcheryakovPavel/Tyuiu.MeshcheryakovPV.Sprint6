
namespace Tyuiu.MeshcheryakovPV.Sprint6.Task0.V24
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
            this.groupBoxRead_MVP = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_MVP = new System.Windows.Forms.PictureBox();
            this.textBoxRead_MVP = new System.Windows.Forms.TextBox();
            this.groupBoxGetValue_MVP = new System.Windows.Forms.GroupBox();
            this.textBoxVarX_MVP = new System.Windows.Forms.TextBox();
            this.labelVarX_MVP = new System.Windows.Forms.Label();
            this.groupBoxResult_MVP = new System.Windows.Forms.GroupBox();
            this.labelResult_MVP = new System.Windows.Forms.Label();
            this.textBoxResult_MVP = new System.Windows.Forms.TextBox();
            this.buttonDone_MVP = new System.Windows.Forms.Button();
            this.buttonStudent_MVP = new System.Windows.Forms.Button();
            this.groupBoxRead_MVP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_MVP)).BeginInit();
            this.groupBoxGetValue_MVP.SuspendLayout();
            this.groupBoxResult_MVP.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRead_MVP
            // 
            this.groupBoxRead_MVP.Controls.Add(this.pictureBoxFormula_MVP);
            this.groupBoxRead_MVP.Controls.Add(this.textBoxRead_MVP);
            this.groupBoxRead_MVP.Location = new System.Drawing.Point(24, 29);
            this.groupBoxRead_MVP.Name = "groupBoxRead_MVP";
            this.groupBoxRead_MVP.Size = new System.Drawing.Size(753, 241);
            this.groupBoxRead_MVP.TabIndex = 0;
            this.groupBoxRead_MVP.TabStop = false;
            this.groupBoxRead_MVP.Text = "Условие";
            // 
            // pictureBoxFormula_MVP
            // 
            this.pictureBoxFormula_MVP.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_MVP.ErrorImage")));
            this.pictureBoxFormula_MVP.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_MVP.Image")));
            this.pictureBoxFormula_MVP.Location = new System.Drawing.Point(627, 19);
            this.pictureBoxFormula_MVP.Name = "pictureBoxFormula_MVP";
            this.pictureBoxFormula_MVP.Size = new System.Drawing.Size(108, 62);
            this.pictureBoxFormula_MVP.TabIndex = 4;
            this.pictureBoxFormula_MVP.TabStop = false;
            // 
            // textBoxRead_MVP
            // 
            this.textBoxRead_MVP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRead_MVP.Location = new System.Drawing.Point(6, 19);
            this.textBoxRead_MVP.Multiline = true;
            this.textBoxRead_MVP.Name = "textBoxRead_MVP";
            this.textBoxRead_MVP.ReadOnly = true;
            this.textBoxRead_MVP.Size = new System.Drawing.Size(453, 216);
            this.textBoxRead_MVP.TabIndex = 3;
            this.textBoxRead_MVP.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxGetValue_MVP
            // 
            this.groupBoxGetValue_MVP.Controls.Add(this.textBoxVarX_MVP);
            this.groupBoxGetValue_MVP.Controls.Add(this.labelVarX_MVP);
            this.groupBoxGetValue_MVP.Location = new System.Drawing.Point(24, 276);
            this.groupBoxGetValue_MVP.Name = "groupBoxGetValue_MVP";
            this.groupBoxGetValue_MVP.Size = new System.Drawing.Size(459, 104);
            this.groupBoxGetValue_MVP.TabIndex = 1;
            this.groupBoxGetValue_MVP.TabStop = false;
            this.groupBoxGetValue_MVP.Text = "Ввод данных";
            // 
            // textBoxVarX_MVP
            // 
            this.textBoxVarX_MVP.Location = new System.Drawing.Point(32, 43);
            this.textBoxVarX_MVP.Name = "textBoxVarX_MVP";
            this.textBoxVarX_MVP.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarX_MVP.TabIndex = 4;
            this.textBoxVarX_MVP.Text = "3";
            this.textBoxVarX_MVP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxVarX_KeyPress);
            // 
            // labelVarX_MVP
            // 
            this.labelVarX_MVP.AutoSize = true;
            this.labelVarX_MVP.Location = new System.Drawing.Point(29, 24);
            this.labelVarX_MVP.Name = "labelVarX_MVP";
            this.labelVarX_MVP.Size = new System.Drawing.Size(84, 13);
            this.labelVarX_MVP.TabIndex = 3;
            this.labelVarX_MVP.Text = "Переменная X:";
            // 
            // groupBoxResult_MVP
            // 
            this.groupBoxResult_MVP.Controls.Add(this.labelResult_MVP);
            this.groupBoxResult_MVP.Controls.Add(this.textBoxResult_MVP);
            this.groupBoxResult_MVP.Location = new System.Drawing.Point(501, 276);
            this.groupBoxResult_MVP.Name = "groupBoxResult_MVP";
            this.groupBoxResult_MVP.Size = new System.Drawing.Size(276, 104);
            this.groupBoxResult_MVP.TabIndex = 2;
            this.groupBoxResult_MVP.TabStop = false;
            this.groupBoxResult_MVP.Text = "Вывод данных";
            // 
            // labelResult_MVP
            // 
            this.labelResult_MVP.AutoSize = true;
            this.labelResult_MVP.Location = new System.Drawing.Point(24, 24);
            this.labelResult_MVP.Name = "labelResult_MVP";
            this.labelResult_MVP.Size = new System.Drawing.Size(59, 13);
            this.labelResult_MVP.TabIndex = 1;
            this.labelResult_MVP.Text = "Результат";
            // 
            // textBoxResult_MVP
            // 
            this.textBoxResult_MVP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResult_MVP.Location = new System.Drawing.Point(24, 43);
            this.textBoxResult_MVP.Name = "textBoxResult_MVP";
            this.textBoxResult_MVP.ReadOnly = true;
            this.textBoxResult_MVP.Size = new System.Drawing.Size(234, 20);
            this.textBoxResult_MVP.TabIndex = 0;
            // 
            // buttonDone_MVP
            // 
            this.buttonDone_MVP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDone_MVP.Location = new System.Drawing.Point(651, 386);
            this.buttonDone_MVP.Name = "buttonDone_MVP";
            this.buttonDone_MVP.Size = new System.Drawing.Size(125, 42);
            this.buttonDone_MVP.TabIndex = 3;
            this.buttonDone_MVP.Text = "Выполнить";
            this.buttonDone_MVP.UseVisualStyleBackColor = true;
            this.buttonDone_MVP.Click += new System.EventHandler(this.buttonDone_MVP_Click);
            // 
            // buttonStudent_MVP
            // 
            this.buttonStudent_MVP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudent_MVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStudent_MVP.Location = new System.Drawing.Point(602, 386);
            this.buttonStudent_MVP.Name = "buttonStudent_MVP";
            this.buttonStudent_MVP.Size = new System.Drawing.Size(42, 42);
            this.buttonStudent_MVP.TabIndex = 4;
            this.buttonStudent_MVP.Text = "?";
            this.buttonStudent_MVP.UseVisualStyleBackColor = true;
            this.buttonStudent_MVP.Click += new System.EventHandler(this.buttonStudent_MVP_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStudent_MVP);
            this.Controls.Add(this.buttonDone_MVP);
            this.Controls.Add(this.groupBoxResult_MVP);
            this.Controls.Add(this.groupBoxGetValue_MVP);
            this.Controls.Add(this.groupBoxRead_MVP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 24 | Мещеряков П.В.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxRead_MVP.ResumeLayout(false);
            this.groupBoxRead_MVP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_MVP)).EndInit();
            this.groupBoxGetValue_MVP.ResumeLayout(false);
            this.groupBoxGetValue_MVP.PerformLayout();
            this.groupBoxResult_MVP.ResumeLayout(false);
            this.groupBoxResult_MVP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRead_MVP;
        private System.Windows.Forms.GroupBox groupBoxGetValue_MVP;
        private System.Windows.Forms.GroupBox groupBoxResult_MVP;
        private System.Windows.Forms.TextBox textBoxRead_MVP;
        private System.Windows.Forms.PictureBox pictureBoxFormula_MVP;
        private System.Windows.Forms.Label labelVarX_MVP;
        private System.Windows.Forms.Label labelResult_MVP;
        private System.Windows.Forms.TextBox textBoxResult_MVP;
        private System.Windows.Forms.Button buttonDone_MVP;
        private System.Windows.Forms.Button buttonStudent_MVP;
        private System.Windows.Forms.TextBox textBoxVarX_MVP;
    }
}
