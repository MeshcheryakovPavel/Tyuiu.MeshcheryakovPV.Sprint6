namespace Tyuiu.MeshcheryakovPV.Sprint6.Task7.V10
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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.panelTask = new System.Windows.Forms.Panel();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.panelInput = new System.Windows.Forms.Panel();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.dataGridViewInput = new System.Windows.Forms.DataGridView();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutput = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButtons = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogTask = new System.Windows.Forms.SaveFileDialog();
            this.panelButtons.SuspendLayout();
            this.panelTask.SuspendLayout();
            this.groupBoxTask.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).BeginInit();
            this.panelOutput.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelButtons.Controls.Add(this.buttonAbout);
            this.panelButtons.Controls.Add(this.buttonSave);
            this.panelButtons.Controls.Add(this.buttonDone);
            this.panelButtons.Controls.Add(this.buttonOpen);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1173, 122);
            this.panelButtons.TabIndex = 0;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAbout.Location = new System.Drawing.Point(1042, 19);
            this.buttonAbout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(112, 94);
            this.buttonAbout.TabIndex = 3;
            this.toolTipButtons.SetToolTip(this.buttonAbout, "Сведения о программе\r\n");
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            this.buttonAbout.MouseEnter += new System.EventHandler(this.buttonAbout_MouseEnter);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSave.Location = new System.Drawing.Point(266, 19);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(112, 94);
            this.buttonSave.TabIndex = 2;
            this.toolTipButtons.SetToolTip(this.buttonSave, "Сохранить обработанные данные в файл в формате CSV");
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            this.buttonSave.MouseEnter += new System.EventHandler(this.buttonSave_MouseEnter);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDone.Location = new System.Drawing.Point(144, 19);
            this.buttonDone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(112, 94);
            this.buttonDone.TabIndex = 1;
            this.toolTipButtons.SetToolTip(this.buttonDone, "Выполнить обработку данных\r\n");
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            this.buttonDone.MouseEnter += new System.EventHandler(this.buttonDone_MouseEnter);
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonOpen.Location = new System.Drawing.Point(20, 19);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(112, 94);
            this.buttonOpen.TabIndex = 0;
            this.toolTipButtons.SetToolTip(this.buttonOpen, "Открыть файл для обработки данных в формате CSV\r\n");
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            this.buttonOpen.MouseEnter += new System.EventHandler(this.buttonOpen_MouseEnter);
            // 
            // panelTask
            // 
            this.panelTask.Controls.Add(this.groupBoxTask);
            this.panelTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask.Location = new System.Drawing.Point(0, 122);
            this.panelTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTask.Name = "panelTask";
            this.panelTask.Size = new System.Drawing.Size(1173, 156);
            this.panelTask.TabIndex = 1;
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.BackColor = System.Drawing.Color.Gray;
            this.groupBoxTask.Controls.Add(this.textBoxTask);
            this.groupBoxTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask.ForeColor = System.Drawing.Color.White;
            this.groupBoxTask.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxTask.Size = new System.Drawing.Size(1173, 156);
            this.groupBoxTask.TabIndex = 0;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие:";
            // 
            // textBoxTask
            // 
            this.textBoxTask.BackColor = System.Drawing.Color.LightGray;
            this.textBoxTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask.Location = new System.Drawing.Point(4, 29);
            this.textBoxTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.Size = new System.Drawing.Size(1165, 122);
            this.textBoxTask.TabIndex = 0;
            this.textBoxTask.TextChanged += new System.EventHandler(this.textBoxTask_TextChanged);
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.Gray;
            this.panelInput.Controls.Add(this.groupBoxInput);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInput.Location = new System.Drawing.Point(0, 278);
            this.panelInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(591, 430);
            this.panelInput.TabIndex = 2;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.dataGridViewInput);
            this.groupBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput.ForeColor = System.Drawing.Color.White;
            this.groupBoxInput.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxInput.Size = new System.Drawing.Size(591, 430);
            this.groupBoxInput.TabIndex = 0;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод:";
            // 
            // dataGridViewInput
            // 
            this.dataGridViewInput.AllowUserToDeleteRows = false;
            this.dataGridViewInput.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput.ColumnHeadersVisible = false;
            this.dataGridViewInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInput.Location = new System.Drawing.Point(4, 29);
            this.dataGridViewInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewInput.Name = "dataGridViewInput";
            this.dataGridViewInput.ReadOnly = true;
            this.dataGridViewInput.RowHeadersVisible = false;
            this.dataGridViewInput.RowHeadersWidth = 51;
            this.dataGridViewInput.RowTemplate.Height = 24;
            this.dataGridViewInput.Size = new System.Drawing.Size(583, 396);
            this.dataGridViewInput.TabIndex = 0;
            // 
            // panelOutput
            // 
            this.panelOutput.BackColor = System.Drawing.Color.Gray;
            this.panelOutput.Controls.Add(this.groupBoxOutput);
            this.panelOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutput.Location = new System.Drawing.Point(591, 278);
            this.panelOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(582, 430);
            this.panelOutput.TabIndex = 3;
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.dataGridViewOutput);
            this.groupBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput.ForeColor = System.Drawing.Color.White;
            this.groupBoxOutput.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxOutput.Size = new System.Drawing.Size(582, 430);
            this.groupBoxOutput.TabIndex = 0;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Вывод:";
            // 
            // dataGridViewOutput
            // 
            this.dataGridViewOutput.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput.ColumnHeadersVisible = false;
            this.dataGridViewOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutput.Location = new System.Drawing.Point(4, 29);
            this.dataGridViewOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewOutput.Name = "dataGridViewOutput";
            this.dataGridViewOutput.ReadOnly = true;
            this.dataGridViewOutput.RowHeadersVisible = false;
            this.dataGridViewOutput.RowHeadersWidth = 51;
            this.dataGridViewOutput.RowTemplate.Height = 24;
            this.dataGridViewOutput.Size = new System.Drawing.Size(574, 396);
            this.dataGridViewOutput.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(591, 278);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 430);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTipButtons
            // 
            this.toolTipButtons.IsBalloon = true;
            this.toolTipButtons.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButtons.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 708);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelOutput);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.panelTask);
            this.Controls.Add(this.panelButtons);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1187, 741);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 8 | Мещеряков П.В.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelButtons.ResumeLayout(false);
            this.panelTask.ResumeLayout(false);
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            this.panelInput.ResumeLayout(false);
            this.groupBoxInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).EndInit();
            this.panelOutput.ResumeLayout(false);
            this.groupBoxOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Panel panelTask;
        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.DataGridView dataGridViewInput;
        private System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.DataGridView dataGridViewOutput;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.ToolTip toolTipButtons;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTask;
    }
}

