namespace Enigma
{
    partial class F_SettingsManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_SettingsManager));
            this.label1 = new System.Windows.Forms.Label();
            this.CaptureModul = new System.Windows.Forms.Panel();
            this.B_Export = new System.Windows.Forms.Button();
            this.B_Import = new System.Windows.Forms.Button();
            this.B_Instruction = new System.Windows.Forms.Button();
            this.B_Exit = new System.Windows.Forms.Button();
            this.T_Name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.B_Choose = new System.Windows.Forms.Button();
            this.B_Rem = new System.Windows.Forms.Button();
            this.B_Add = new System.Windows.Forms.Button();
            this.B_Combinations = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.elipseControl1 = new Enigma.ElipseControl();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaptureModul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(56, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 54);
            this.label1.TabIndex = 15;
            this.label1.Text = "Менеджер налаштувань";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CapturModul_MouseDown);
            // 
            // CaptureModul
            // 
            this.CaptureModul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.CaptureModul.Controls.Add(this.B_Export);
            this.CaptureModul.Controls.Add(this.label1);
            this.CaptureModul.Controls.Add(this.B_Import);
            this.CaptureModul.Controls.Add(this.B_Instruction);
            this.CaptureModul.Controls.Add(this.B_Exit);
            this.CaptureModul.Dock = System.Windows.Forms.DockStyle.Top;
            this.CaptureModul.Location = new System.Drawing.Point(0, 0);
            this.CaptureModul.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CaptureModul.Name = "CaptureModul";
            this.CaptureModul.Size = new System.Drawing.Size(722, 49);
            this.CaptureModul.TabIndex = 17;
            this.CaptureModul.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CapturModul_MouseDown);
            // 
            // B_Export
            // 
            this.B_Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Export.FlatAppearance.BorderSize = 0;
            this.B_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Export.ForeColor = System.Drawing.Color.White;
            this.B_Export.Location = new System.Drawing.Point(459, 2);
            this.B_Export.Margin = new System.Windows.Forms.Padding(0);
            this.B_Export.Name = "B_Export";
            this.B_Export.Size = new System.Drawing.Size(113, 47);
            this.B_Export.TabIndex = 265;
            this.B_Export.Text = "Експорт";
            this.toolTip1.SetToolTip(this.B_Export, "Експортувати в файл обрані налаштування");
            this.B_Export.UseVisualStyleBackColor = false;
            this.B_Export.Click += new System.EventHandler(this.B_Export_Click);
            // 
            // B_Import
            // 
            this.B_Import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Import.FlatAppearance.BorderSize = 0;
            this.B_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Import.ForeColor = System.Drawing.Color.White;
            this.B_Import.Location = new System.Drawing.Point(572, 2);
            this.B_Import.Margin = new System.Windows.Forms.Padding(0);
            this.B_Import.Name = "B_Import";
            this.B_Import.Size = new System.Drawing.Size(93, 47);
            this.B_Import.TabIndex = 266;
            this.B_Import.Text = "Імпорт";
            this.toolTip1.SetToolTip(this.B_Import, "Імпортувати налаштування");
            this.B_Import.UseVisualStyleBackColor = false;
            this.B_Import.Click += new System.EventHandler(this.B_Import_Click);
            // 
            // B_Instruction
            // 
            this.B_Instruction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Instruction.BackgroundImage = global::Enigma.Properties.Resources.Enigma_ENG_icon;
            this.B_Instruction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Instruction.Cursor = System.Windows.Forms.Cursors.Default;
            this.B_Instruction.FlatAppearance.BorderSize = 0;
            this.B_Instruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Instruction.Location = new System.Drawing.Point(0, 0);
            this.B_Instruction.Margin = new System.Windows.Forms.Padding(0);
            this.B_Instruction.Name = "B_Instruction";
            this.B_Instruction.Size = new System.Drawing.Size(51, 47);
            this.B_Instruction.TabIndex = 135;
            this.B_Instruction.UseVisualStyleBackColor = false;
            // 
            // B_Exit
            // 
            this.B_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Exit.BackgroundImage = global::Enigma.Properties.Resources.Close_icon;
            this.B_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Exit.FlatAppearance.BorderSize = 0;
            this.B_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Exit.Location = new System.Drawing.Point(671, 0);
            this.B_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(51, 47);
            this.B_Exit.TabIndex = 16;
            this.B_Exit.UseVisualStyleBackColor = false;
            this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
            // 
            // T_Name
            // 
            this.T_Name.BackColor = System.Drawing.Color.DarkGray;
            this.T_Name.Cursor = System.Windows.Forms.Cursors.Default;
            this.T_Name.ForeColor = System.Drawing.Color.White;
            this.T_Name.Location = new System.Drawing.Point(97, 296);
            this.T_Name.Margin = new System.Windows.Forms.Padding(6);
            this.T_Name.MaxLength = 50;
            this.T_Name.Name = "T_Name";
            this.T_Name.Size = new System.Drawing.Size(329, 39);
            this.T_Name.TabIndex = 246;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(11, 295);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 38);
            this.label7.TabIndex = 264;
            this.label7.Text = "Назва:";
            // 
            // B_Choose
            // 
            this.B_Choose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.B_Choose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Choose.BackgroundImage = global::Enigma.Properties.Resources.Hand_Touch_2_icon;
            this.B_Choose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Choose.FlatAppearance.BorderSize = 0;
            this.B_Choose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Choose.Font = new System.Drawing.Font("Segoe Script", 8.25F);
            this.B_Choose.ForeColor = System.Drawing.Color.White;
            this.B_Choose.Location = new System.Drawing.Point(645, 276);
            this.B_Choose.Name = "B_Choose";
            this.B_Choose.Size = new System.Drawing.Size(64, 64);
            this.B_Choose.TabIndex = 254;
            this.B_Choose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.B_Choose, "Обрати налаштування");
            this.B_Choose.UseVisualStyleBackColor = false;
            this.B_Choose.Click += new System.EventHandler(this.B_Choose_Click);
            // 
            // B_Rem
            // 
            this.B_Rem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.B_Rem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Rem.BackgroundImage = global::Enigma.Properties.Resources.Close_icon;
            this.B_Rem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Rem.FlatAppearance.BorderSize = 0;
            this.B_Rem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Rem.Font = new System.Drawing.Font("Segoe Script", 8.25F);
            this.B_Rem.ForeColor = System.Drawing.Color.White;
            this.B_Rem.Location = new System.Drawing.Point(505, 276);
            this.B_Rem.Name = "B_Rem";
            this.B_Rem.Size = new System.Drawing.Size(64, 64);
            this.B_Rem.TabIndex = 254;
            this.B_Rem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.B_Rem, "Видалити налаштування");
            this.B_Rem.UseVisualStyleBackColor = false;
            this.B_Rem.Click += new System.EventHandler(this.B_Rem_Click);
            // 
            // B_Add
            // 
            this.B_Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.B_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Add.BackgroundImage = global::Enigma.Properties.Resources.check_icon;
            this.B_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Add.FlatAppearance.BorderSize = 0;
            this.B_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Add.Font = new System.Drawing.Font("Segoe Script", 8.25F);
            this.B_Add.ForeColor = System.Drawing.Color.White;
            this.B_Add.Location = new System.Drawing.Point(435, 276);
            this.B_Add.Name = "B_Add";
            this.B_Add.Size = new System.Drawing.Size(64, 64);
            this.B_Add.TabIndex = 253;
            this.B_Add.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.B_Add, "Створити нові налаштування");
            this.B_Add.UseVisualStyleBackColor = false;
            this.B_Add.Click += new System.EventHandler(this.B_Add_Click);
            // 
            // B_Combinations
            // 
            this.B_Combinations.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.B_Combinations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Combinations.BackgroundImage = global::Enigma.Properties.Resources.Bakelite_icon;
            this.B_Combinations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Combinations.FlatAppearance.BorderSize = 0;
            this.B_Combinations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Combinations.Font = new System.Drawing.Font("Segoe Script", 8.25F);
            this.B_Combinations.ForeColor = System.Drawing.Color.White;
            this.B_Combinations.Location = new System.Drawing.Point(575, 276);
            this.B_Combinations.Name = "B_Combinations";
            this.B_Combinations.Size = new System.Drawing.Size(64, 64);
            this.B_Combinations.TabIndex = 254;
            this.B_Combinations.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.B_Combinations, "Переглянути дані та криптостійкість налаштувань");
            this.B_Combinations.UseVisualStyleBackColor = false;
            this.B_Combinations.Click += new System.EventHandler(this.B_Combinations_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "GG";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Enigma Settings|*.GG";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "GG";
            this.saveFileDialog1.Filter = "Enigma Settings|*.GG";
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 50;
            this.elipseControl1.TargetControl = this;
            // 
            // dataGV
            // 
            this.dataGV.AllowUserToAddRows = false;
            this.dataGV.AllowUserToDeleteRows = false;
            this.dataGV.AllowUserToResizeColumns = false;
            this.dataGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe Script", 10F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            this.dataGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe Script", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe Script", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGV.Location = new System.Drawing.Point(13, 59);
            this.dataGV.Margin = new System.Windows.Forms.Padding(4);
            this.dataGV.MultiSelect = false;
            this.dataGV.Name = "dataGV";
            this.dataGV.ReadOnly = true;
            this.dataGV.RowHeadersVisible = false;
            this.dataGV.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe Script", 10F);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            this.dataGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGV.RowTemplate.Height = 24;
            this.dataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV.ShowCellErrors = false;
            this.dataGV.ShowCellToolTips = false;
            this.dataGV.ShowEditingIcon = false;
            this.dataGV.ShowRowErrors = false;
            this.dataGV.Size = new System.Drawing.Size(696, 210);
            this.dataGV.TabIndex = 265;
            this.dataGV.TabStop = false;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 31.25968F;
            this.Column2.HeaderText = "Назва налаштувань";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // F_SettingsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(722, 363);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.B_Choose);
            this.Controls.Add(this.B_Combinations);
            this.Controls.Add(this.B_Rem);
            this.Controls.Add(this.B_Add);
            this.Controls.Add(this.T_Name);
            this.Controls.Add(this.CaptureModul);
            this.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "F_SettingsManager";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.F_SettingsManager_Load);
            this.CaptureModul.ResumeLayout(false);
            this.CaptureModul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel CaptureModul;
        private System.Windows.Forms.Button B_Instruction;
        private System.Windows.Forms.Button B_Exit;
        private ElipseControl elipseControl1;
        private System.Windows.Forms.TextBox T_Name;
        private System.Windows.Forms.Button B_Add;
        private System.Windows.Forms.Button B_Rem;
        private System.Windows.Forms.Button B_Choose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button B_Export;
        private System.Windows.Forms.Button B_Import;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button B_Combinations;
        public System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}