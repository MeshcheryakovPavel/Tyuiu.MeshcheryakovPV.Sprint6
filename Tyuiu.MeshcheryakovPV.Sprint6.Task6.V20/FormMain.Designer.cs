namespace Tyuiu.MeshcheryakovPV.Sprint6.Task6.V20
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_MPV));
            this.panelHat_MPV = new System.Windows.Forms.Panel();
            this.buttonDo_MPV = new System.Windows.Forms.Button();
            this.buttonOpenFile_MPV = new System.Windows.Forms.Button();
            this.buttonHelp_MPV = new System.Windows.Forms.Button();
            this.panelCondition_MPV = new System.Windows.Forms.Panel();
            this.groupBoxCondition_MPV = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_MPV = new System.Windows.Forms.TextBox();
            this.panelInput_MPV = new System.Windows.Forms.Panel();
            this.groupBoxInput_MPV = new System.Windows.Forms.GroupBox();
            this.textBoxInput_MPV = new System.Windows.Forms.TextBox();
            this.panelOutput_MPV = new System.Windows.Forms.Panel();
            this.groupBoxOutput_MPV = new System.Windows.Forms.GroupBox();
            this.textBoxResult_MPV = new System.Windows.Forms.TextBox();
            this.splitter_MPV = new System.Windows.Forms.Splitter();
            this.openFileDialogTask_MPV = new System.Windows.Forms.OpenFileDialog();
            this.toolTipIn_MPV = new System.Windows.Forms.ToolTip(this.components);
            this.panelHat_MPV.SuspendLayout();
            this.panelCondition_MPV.SuspendLayout();
            this.groupBoxCondition_MPV.SuspendLayout();
            this.panelInput_MPV.SuspendLayout();
            this.groupBoxInput_MPV.SuspendLayout();
            this.panelOutput_MPV.SuspendLayout();
            this.groupBoxOutput_MPV.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHat_MPV
            // 
            this.panelHat_MPV.BackColor = System.Drawing.SystemColors.Control;
            this.panelHat_MPV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHat_MPV.Controls.Add(this.buttonDo_MPV);
            this.panelHat_MPV.Controls.Add(this.buttonOpenFile_MPV);
            this.panelHat_MPV.Controls.Add(this.buttonHelp_MPV);
            this.panelHat_MPV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHat_MPV.Location = new System.Drawing.Point(0, 0);
            this.panelHat_MPV.Name = "panelHat_MPV";
            this.panelHat_MPV.Size = new System.Drawing.Size(990, 95);
            this.panelHat_MPV.TabIndex = 2;
            // 
            // buttonDo_MPV
            // 
            this.buttonDo_MPV.Enabled = false;
            this.buttonDo_MPV.Image = ((System.Drawing.Image)(resources.GetObject("buttonDo_MPV.Image")));
            this.buttonDo_MPV.Location = new System.Drawing.Point(98, 11);
            this.buttonDo_MPV.Name = "buttonDo_MPV";
            this.buttonDo_MPV.Size = new System.Drawing.Size(81, 70);
            this.buttonDo_MPV.TabIndex = 6;
            this.toolTipIn_MPV.SetToolTip(this.buttonDo_MPV, "Второе слово каждой строки в результирующею строку");
            this.buttonDo_MPV.UseVisualStyleBackColor = true;
            this.buttonDo_MPV.Click += new System.EventHandler(this.buttonDo_MPV_Click);
            // 
            // buttonOpenFile_MPV
            // 
            this.buttonOpenFile_MPV.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_MPV.Image")));
            this.buttonOpenFile_MPV.Location = new System.Drawing.Point(11, 11);
            this.buttonOpenFile_MPV.Name = "buttonOpenFile_MPV";
            this.buttonOpenFile_MPV.Size = new System.Drawing.Size(81, 70);
            this.buttonOpenFile_MPV.TabIndex = 5;
            this.toolTipIn_MPV.SetToolTip(this.buttonOpenFile_MPV, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            this.buttonOpenFile_MPV.UseVisualStyleBackColor = true;
            this.buttonOpenFile_MPV.Click += new System.EventHandler(this.buttonOpenFile_MPV_Click);
            // 
            // buttonHelp_MPV
            // 
            this.buttonHelp_MPV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_MPV.BackColor = System.Drawing.SystemColors.Control;
            this.buttonHelp_MPV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_MPV.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_MPV.Image")));
            this.buttonHelp_MPV.Location = new System.Drawing.Point(882, 20);
            this.buttonHelp_MPV.Name = "buttonHelp_MPV";
            this.buttonHelp_MPV.Size = new System.Drawing.Size(79, 50);
            this.buttonHelp_MPV.TabIndex = 4;
            this.toolTipIn_MPV.SetToolTip(this.buttonHelp_MPV, "Сведение о программе");
            this.buttonHelp_MPV.UseVisualStyleBackColor = false;
            this.buttonHelp_MPV.Click += new System.EventHandler(this.buttonHelp_MPV_Click);
            // 
            // panelCondition_MPV
            // 
            this.panelCondition_MPV.BackColor = System.Drawing.SystemColors.Control;
            this.panelCondition_MPV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCondition_MPV.Controls.Add(this.groupBoxCondition_MPV);
            this.panelCondition_MPV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCondition_MPV.Location = new System.Drawing.Point(0, 95);
            this.panelCondition_MPV.Name = "panelCondition_MPV";
            this.panelCondition_MPV.Size = new System.Drawing.Size(990, 110);
            this.panelCondition_MPV.TabIndex = 3;
            // 
            // groupBoxCondition_MPV
            // 
            this.groupBoxCondition_MPV.Controls.Add(this.textBoxCondition_MPV);
            this.groupBoxCondition_MPV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCondition_MPV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxCondition_MPV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_MPV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCondition_MPV.Name = "groupBoxCondition_MPV";
            this.groupBoxCondition_MPV.Size = new System.Drawing.Size(988, 108);
            this.groupBoxCondition_MPV.TabIndex = 1;
            this.groupBoxCondition_MPV.TabStop = false;
            this.groupBoxCondition_MPV.Text = "Условие:";
            // 
            // textBoxCondition_MPV
            // 
            this.textBoxCondition_MPV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCondition_MPV.Location = new System.Drawing.Point(7, 27);
            this.textBoxCondition_MPV.Multiline = true;
            this.textBoxCondition_MPV.Name = "textBoxCondition_MPV";
            this.textBoxCondition_MPV.ReadOnly = true;
            this.textBoxCondition_MPV.Size = new System.Drawing.Size(970, 63);
            this.textBoxCondition_MPV.TabIndex = 0;
            this.textBoxCondition_MPV.Text = "Дан файл InPutFileTask6V20.txt. Загрузить файл в textBoxIn через openFileDialog.\r\n" +
    "Вывести первое слово каждой строки в результирующею строку и вывести ее в textBo" +
    "xOut.";
            // 
            // panelInput_MPV
            // 
            this.panelInput_MPV.Controls.Add(this.groupBoxInput_MPV);
            this.panelInput_MPV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInput_MPV.Location = new System.Drawing.Point(0, 205);
            this.panelInput_MPV.Name = "panelInput_MPV";
            this.panelInput_MPV.Size = new System.Drawing.Size(492, 425);
            this.panelInput_MPV.TabIndex = 4;
            // 
            // groupBoxInput_MPV
            // 
            this.groupBoxInput_MPV.Controls.Add(this.textBoxInput_MPV);
            this.groupBoxInput_MPV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput_MPV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInput_MPV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput_MPV.Name = "groupBoxInput_MPV";
            this.groupBoxInput_MPV.Size = new System.Drawing.Size(492, 425);
            this.groupBoxInput_MPV.TabIndex = 0;
            this.groupBoxInput_MPV.TabStop = false;
            this.groupBoxInput_MPV.Text = "Ввод:";
            // 
            // textBoxInput_MPV
            // 
            this.textBoxInput_MPV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput_MPV.Location = new System.Drawing.Point(3, 23);
            this.textBoxInput_MPV.Multiline = true;
            this.textBoxInput_MPV.Name = "textBoxInput_MPV";
            this.textBoxInput_MPV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput_MPV.Size = new System.Drawing.Size(486, 399);
            this.textBoxInput_MPV.TabIndex = 0;
            // 
            // panelOutput_MPV
            // 
            this.panelOutput_MPV.Controls.Add(this.groupBoxOutput_MPV);
            this.panelOutput_MPV.Controls.Add(this.splitter_MPV);
            this.panelOutput_MPV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutput_MPV.Location = new System.Drawing.Point(492, 205);
            this.panelOutput_MPV.Name = "panelOutput_MPV";
            this.panelOutput_MPV.Size = new System.Drawing.Size(498, 425);
            this.panelOutput_MPV.TabIndex = 5;
            // 
            // groupBoxOutput_MPV
            // 
            this.groupBoxOutput_MPV.Controls.Add(this.textBoxResult_MPV);
            this.groupBoxOutput_MPV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput_MPV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutput_MPV.Location = new System.Drawing.Point(3, 0);
            this.groupBoxOutput_MPV.Name = "groupBoxOutput_MPV";
            this.groupBoxOutput_MPV.Size = new System.Drawing.Size(495, 425);
            this.groupBoxOutput_MPV.TabIndex = 1;
            this.groupBoxOutput_MPV.TabStop = false;
            this.groupBoxOutput_MPV.Text = "Вывод:";
            // 
            // textBoxResult_MPV
            // 
            this.textBoxResult_MPV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_MPV.Location = new System.Drawing.Point(3, 23);
            this.textBoxResult_MPV.Multiline = true;
            this.textBoxResult_MPV.Name = "textBoxResult_MPV";
            this.textBoxResult_MPV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_MPV.Size = new System.Drawing.Size(489, 399);
            this.textBoxResult_MPV.TabIndex = 1;
            // 
            // splitter_MPV
            // 
            this.splitter_MPV.Location = new System.Drawing.Point(0, 0);
            this.splitter_MPV.Name = "splitter_MPV";
            this.splitter_MPV.Size = new System.Drawing.Size(3, 425);
            this.splitter_MPV.TabIndex = 0;
            this.splitter_MPV.TabStop = false;
            // 
            // openFileDialogTask_MPV
            // 
            this.openFileDialogTask_MPV.FileName = "openFileDialog1";
            // 
            // toolTipIn_MPV
            // 
            this.toolTipIn_MPV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipIn_MPV.ToolTipTitle = "Подсказка";
            // 
            // FormMain_MPV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 630);
            this.Controls.Add(this.panelOutput_MPV);
            this.Controls.Add(this.panelInput_MPV);
            this.Controls.Add(this.panelCondition_MPV);
            this.Controls.Add(this.panelHat_MPV);
            this.MinimumSize = new System.Drawing.Size(1008, 677);
            this.Name = "FormMain_MPV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 20 | Мещеряков П.В.";
            this.panelHat_MPV.ResumeLayout(false);
            this.panelCondition_MPV.ResumeLayout(false);
            this.groupBoxCondition_MPV.ResumeLayout(false);
            this.groupBoxCondition_MPV.PerformLayout();
            this.panelInput_MPV.ResumeLayout(false);
            this.groupBoxInput_MPV.ResumeLayout(false);
            this.groupBoxInput_MPV.PerformLayout();
            this.panelOutput_MPV.ResumeLayout(false);
            this.groupBoxOutput_MPV.ResumeLayout(false);
            this.groupBoxOutput_MPV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHat_MPV;
        private System.Windows.Forms.Button buttonDo_MPV;
        private System.Windows.Forms.Button buttonOpenFile_MPV;
        private System.Windows.Forms.Button buttonHelp_MPV;
        private System.Windows.Forms.Panel panelCondition_MPV;
        private System.Windows.Forms.GroupBox groupBoxCondition_MPV;
        private System.Windows.Forms.TextBox textBoxCondition_MPV;
        private System.Windows.Forms.Panel panelInput_MPV;
        private System.Windows.Forms.GroupBox groupBoxInput_MPV;
        private System.Windows.Forms.TextBox textBoxInput_MPV;
        private System.Windows.Forms.Panel panelOutput_MPV;
        private System.Windows.Forms.GroupBox groupBoxOutput_MPV;
        private System.Windows.Forms.TextBox textBoxResult_MPV;
        private System.Windows.Forms.Splitter splitter_MPV;
        private System.Windows.Forms.ToolTip toolTipIn_MPV;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_MPV;
    }
}