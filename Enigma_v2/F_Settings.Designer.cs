namespace Enigma
{
    partial class F_Settings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Settings));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.CaptureModul = new System.Windows.Forms.Panel();
            this.B_Export = new System.Windows.Forms.Button();
            this.B_Import = new System.Windows.Forms.Button();
            this.B_Done = new System.Windows.Forms.Button();
            this.B_Instruction = new System.Windows.Forms.Button();
            this.B_Exit = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Num_Ring = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.L_Alpha_Rotor = new System.Windows.Forms.Label();
            this.T_New_Rotor = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_K2 = new System.Windows.Forms.TextBox();
            this.T_K1 = new System.Windows.Forms.TextBox();
            this.T_Reflector = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.L_Alpha_K = new System.Windows.Forms.Label();
            this.L_Alph_Reflect = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.B_Remove_Couple = new System.Windows.Forms.Button();
            this.B_Rand_Reflector = new System.Windows.Forms.Button();
            this.B_All_reset = new System.Windows.Forms.Button();
            this.B_Reset = new System.Windows.Forms.Button();
            this.B_Down = new System.Windows.Forms.Button();
            this.B_Up = new System.Windows.Forms.Button();
            this.B_Rem_Rotor = new System.Windows.Forms.Button();
            this.B_Rand_Rotor = new System.Windows.Forms.Button();
            this.B_Add_Rotor = new System.Windows.Forms.Button();
            this.L_Combinations = new System.Windows.Forms.Label();
            this.B_Compinations = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.elipseControl1 = new Enigma.ElipseControl();
            this.CaptureModul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Ring)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label3.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(57, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 54);
            this.label3.TabIndex = 132;
            this.label3.Text = "Налаштування";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CapturModul_MouseDown);
            // 
            // CaptureModul
            // 
            this.CaptureModul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.CaptureModul.Controls.Add(this.B_Export);
            this.CaptureModul.Controls.Add(this.B_Import);
            this.CaptureModul.Controls.Add(this.B_Done);
            this.CaptureModul.Controls.Add(this.B_Instruction);
            this.CaptureModul.Controls.Add(this.B_Exit);
            this.CaptureModul.Controls.Add(this.label3);
            this.CaptureModul.Dock = System.Windows.Forms.DockStyle.Top;
            this.CaptureModul.Location = new System.Drawing.Point(0, 0);
            this.CaptureModul.Margin = new System.Windows.Forms.Padding(6);
            this.CaptureModul.Name = "CaptureModul";
            this.CaptureModul.Size = new System.Drawing.Size(1190, 49);
            this.CaptureModul.TabIndex = 135;
            this.CaptureModul.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CapturModul_MouseDown);
            // 
            // B_Export
            // 
            this.B_Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Export.FlatAppearance.BorderSize = 0;
            this.B_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Export.ForeColor = System.Drawing.Color.White;
            this.B_Export.Location = new System.Drawing.Point(845, 0);
            this.B_Export.Margin = new System.Windows.Forms.Padding(0);
            this.B_Export.Name = "B_Export";
            this.B_Export.Size = new System.Drawing.Size(113, 47);
            this.B_Export.TabIndex = 135;
            this.B_Export.Text = "Експорт";
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
            this.B_Import.Location = new System.Drawing.Point(958, 0);
            this.B_Import.Margin = new System.Windows.Forms.Padding(0);
            this.B_Import.Name = "B_Import";
            this.B_Import.Size = new System.Drawing.Size(93, 47);
            this.B_Import.TabIndex = 135;
            this.B_Import.Text = "Імпорт";
            this.B_Import.UseVisualStyleBackColor = false;
            this.B_Import.Click += new System.EventHandler(this.B_Import_Click);
            // 
            // B_Done
            // 
            this.B_Done.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Done.FlatAppearance.BorderSize = 0;
            this.B_Done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Done.ForeColor = System.Drawing.Color.White;
            this.B_Done.Location = new System.Drawing.Point(1051, 0);
            this.B_Done.Margin = new System.Windows.Forms.Padding(0);
            this.B_Done.Name = "B_Done";
            this.B_Done.Size = new System.Drawing.Size(88, 47);
            this.B_Done.TabIndex = 135;
            this.B_Done.Text = "Готово";
            this.toolTip1.SetToolTip(this.B_Done, "Зберегти зміни");
            this.B_Done.UseVisualStyleBackColor = false;
            this.B_Done.Click += new System.EventHandler(this.B_Done_Click);
            // 
            // B_Instruction
            // 
            this.B_Instruction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Instruction.BackgroundImage = global::Enigma.Properties.Resources.Enigma_ENG_icon;
            this.B_Instruction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Instruction.Cursor = System.Windows.Forms.Cursors.Help;
            this.B_Instruction.FlatAppearance.BorderSize = 0;
            this.B_Instruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Instruction.Location = new System.Drawing.Point(0, 0);
            this.B_Instruction.Margin = new System.Windows.Forms.Padding(0);
            this.B_Instruction.Name = "B_Instruction";
            this.B_Instruction.Size = new System.Drawing.Size(51, 47);
            this.B_Instruction.TabIndex = 134;
            this.B_Instruction.UseVisualStyleBackColor = false;
            this.B_Instruction.Click += new System.EventHandler(this.B_Instruction_Click);
            // 
            // B_Exit
            // 
            this.B_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Exit.BackgroundImage = global::Enigma.Properties.Resources.Close_icon;
            this.B_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Exit.FlatAppearance.BorderSize = 0;
            this.B_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Exit.Location = new System.Drawing.Point(1139, 0);
            this.B_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(51, 47);
            this.B_Exit.TabIndex = 134;
            this.toolTip1.SetToolTip(this.B_Exit, "Скасувати");
            this.B_Exit.UseVisualStyleBackColor = false;
            this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1173, 305);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Ротори";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1173, 305);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Рефлектор та Комутаційна панель";
            // 
            // Num_Ring
            // 
            this.Num_Ring.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Num_Ring.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.Num_Ring.Location = new System.Drawing.Point(1039, 281);
            this.Num_Ring.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.Num_Ring.Name = "Num_Ring";
            this.Num_Ring.Size = new System.Drawing.Size(133, 39);
            this.Num_Ring.TabIndex = 245;
            this.Num_Ring.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.Num_Ring, "Зміна початкової позиції ротору");
            this.Num_Ring.Click += new System.EventHandler(this.Num_Ring_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe Script", 10F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe Script", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe Script", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(18, 165);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe Script", 10F);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(1016, 219);
            this.dataGridView1.TabIndex = 244;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // Column3
            // 
            this.Column3.FillWeight = 12.18274F;
            this.Column3.HeaderText = "№";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 256.5576F;
            this.Column1.HeaderText = "Ротор";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 31.25968F;
            this.Column2.HeaderText = "Позиція";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // L_Alpha_Rotor
            // 
            this.L_Alpha_Rotor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Alpha_Rotor.AutoSize = true;
            this.L_Alpha_Rotor.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.L_Alpha_Rotor.ForeColor = System.Drawing.Color.White;
            this.L_Alpha_Rotor.Location = new System.Drawing.Point(13, 98);
            this.L_Alpha_Rotor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_Alpha_Rotor.Name = "L_Alpha_Rotor";
            this.L_Alpha_Rotor.Size = new System.Drawing.Size(1178, 32);
            this.L_Alpha_Rotor.TabIndex = 243;
            this.L_Alpha_Rotor.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ!.,-?0123456789 АБВГҐДЕЁЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЪЫЬЮЯ";
            // 
            // T_New_Rotor
            // 
            this.T_New_Rotor.BackColor = System.Drawing.Color.DarkGray;
            this.T_New_Rotor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.T_New_Rotor.Cursor = System.Windows.Forms.Cursors.Default;
            this.T_New_Rotor.ForeColor = System.Drawing.Color.White;
            this.T_New_Rotor.Location = new System.Drawing.Point(18, 129);
            this.T_New_Rotor.Margin = new System.Windows.Forms.Padding(6);
            this.T_New_Rotor.Name = "T_New_Rotor";
            this.T_New_Rotor.Size = new System.Drawing.Size(941, 39);
            this.T_New_Rotor.TabIndex = 242;
            this.toolTip1.SetToolTip(this.T_New_Rotor, "Ротор");
            this.T_New_Rotor.TextChanged += new System.EventHandler(this.T_New_Rotor_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe Script", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.Location = new System.Drawing.Point(1051, 416);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe Script", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Gray;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.ShowCellErrors = false;
            this.dataGridView2.ShowCellToolTips = false;
            this.dataGridView2.ShowEditingIcon = false;
            this.dataGridView2.ShowRowErrors = false;
            this.dataGridView2.Size = new System.Drawing.Size(121, 262);
            this.dataGridView2.TabIndex = 267;
            this.dataGridView2.TabStop = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Пара";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // T_K2
            // 
            this.T_K2.BackColor = System.Drawing.Color.DarkGray;
            this.T_K2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.T_K2.ForeColor = System.Drawing.Color.White;
            this.T_K2.Location = new System.Drawing.Point(379, 543);
            this.T_K2.MaxLength = 1;
            this.T_K2.Name = "T_K2";
            this.T_K2.Size = new System.Drawing.Size(44, 39);
            this.T_K2.TabIndex = 261;
            this.T_K2.TextChanged += new System.EventHandler(this.T_K2_TextChanged);
            // 
            // T_K1
            // 
            this.T_K1.BackColor = System.Drawing.Color.DarkGray;
            this.T_K1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.T_K1.ForeColor = System.Drawing.Color.White;
            this.T_K1.Location = new System.Drawing.Point(329, 543);
            this.T_K1.MaxLength = 1;
            this.T_K1.Name = "T_K1";
            this.T_K1.Size = new System.Drawing.Size(44, 39);
            this.T_K1.TabIndex = 260;
            this.T_K1.TextChanged += new System.EventHandler(this.T_K1_TextChanged);
            // 
            // T_Reflector
            // 
            this.T_Reflector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.T_Reflector.BackColor = System.Drawing.Color.DarkGray;
            this.T_Reflector.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.T_Reflector.Cursor = System.Windows.Forms.Cursors.Default;
            this.T_Reflector.ForeColor = System.Drawing.Color.White;
            this.T_Reflector.Location = new System.Drawing.Point(18, 447);
            this.T_Reflector.Margin = new System.Windows.Forms.Padding(6);
            this.T_Reflector.Name = "T_Reflector";
            this.T_Reflector.Size = new System.Drawing.Size(941, 39);
            this.T_Reflector.TabIndex = 258;
            this.toolTip1.SetToolTip(this.T_Reflector, "Рефлектор");
            this.T_Reflector.TextChanged += new System.EventHandler(this.T_Reflector_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 486);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 64);
            this.label5.TabIndex = 262;
            this.label5.Text = "Комутаційна\r\n   панель:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 38);
            this.label4.TabIndex = 263;
            this.label4.Text = "Ротори:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(192, 546);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 32);
            this.label2.TabIndex = 264;
            this.label2.Text = "Введіть пару:";
            // 
            // L_Alpha_K
            // 
            this.L_Alpha_K.AutoSize = true;
            this.L_Alpha_K.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.L_Alpha_K.ForeColor = System.Drawing.Color.White;
            this.L_Alpha_K.Location = new System.Drawing.Point(192, 486);
            this.L_Alpha_K.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_Alpha_K.Name = "L_Alpha_K";
            this.L_Alpha_K.Size = new System.Drawing.Size(606, 64);
            this.L_Alpha_K.TabIndex = 265;
            this.L_Alpha_K.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ!.,-?0123456789 \r\nАБВГҐДЕЁЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЪЫЬЮЯ";
            // 
            // L_Alph_Reflect
            // 
            this.L_Alph_Reflect.AutoSize = true;
            this.L_Alph_Reflect.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.L_Alph_Reflect.ForeColor = System.Drawing.Color.White;
            this.L_Alph_Reflect.Location = new System.Drawing.Point(13, 416);
            this.L_Alph_Reflect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_Alph_Reflect.Name = "L_Alph_Reflect";
            this.L_Alph_Reflect.Size = new System.Drawing.Size(1178, 32);
            this.L_Alph_Reflect.TabIndex = 257;
            this.L_Alph_Reflect.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ!.,-?0123456789 АБВГҐДЕЁЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЪЫЬЮЯ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 606);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 32);
            this.label1.TabIndex = 264;
            this.label1.Text = "Кількість комбінайцій які будуть потрібні для взлому:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Enigma.Properties.Resources._11111;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(140, 389);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 25);
            this.pictureBox1.TabIndex = 268;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // B_Remove_Couple
            // 
            this.B_Remove_Couple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Remove_Couple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Remove_Couple.BackgroundImage = global::Enigma.Properties.Resources.Close_icon;
            this.B_Remove_Couple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Remove_Couple.FlatAppearance.BorderSize = 0;
            this.B_Remove_Couple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Remove_Couple.Font = new System.Drawing.Font("Segoe Script", 8.25F);
            this.B_Remove_Couple.ForeColor = System.Drawing.Color.White;
            this.B_Remove_Couple.Location = new System.Drawing.Point(970, 614);
            this.B_Remove_Couple.Name = "B_Remove_Couple";
            this.B_Remove_Couple.Size = new System.Drawing.Size(64, 64);
            this.B_Remove_Couple.TabIndex = 266;
            this.B_Remove_Couple.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.B_Remove_Couple, "Видалити обрану комутаційну пару");
            this.B_Remove_Couple.UseVisualStyleBackColor = false;
            this.B_Remove_Couple.Click += new System.EventHandler(this.B_Remove_Couple_Click);
            // 
            // B_Rand_Reflector
            // 
            this.B_Rand_Reflector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Rand_Reflector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Rand_Reflector.BackgroundImage = global::Enigma.Properties.Resources.Gaming_Dice_icon;
            this.B_Rand_Reflector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Rand_Reflector.FlatAppearance.BorderSize = 0;
            this.B_Rand_Reflector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Rand_Reflector.Font = new System.Drawing.Font("Segoe Script", 8.25F);
            this.B_Rand_Reflector.ForeColor = System.Drawing.Color.White;
            this.B_Rand_Reflector.Location = new System.Drawing.Point(970, 416);
            this.B_Rand_Reflector.Name = "B_Rand_Reflector";
            this.B_Rand_Reflector.Size = new System.Drawing.Size(64, 64);
            this.B_Rand_Reflector.TabIndex = 259;
            this.B_Rand_Reflector.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.B_Rand_Reflector, "Створити рефлектор з випадковою послідовнісстю літер");
            this.B_Rand_Reflector.UseVisualStyleBackColor = false;
            this.B_Rand_Reflector.Click += new System.EventHandler(this.B_Random_Reflector_Click);
            // 
            // B_All_reset
            // 
            this.B_All_reset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.B_All_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_All_reset.BackgroundImage = global::Enigma.Properties.Resources.Reset_icon;
            this.B_All_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_All_reset.FlatAppearance.BorderSize = 0;
            this.B_All_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_All_reset.Font = new System.Drawing.Font("Segoe Script", 8.25F);
            this.B_All_reset.ForeColor = System.Drawing.Color.White;
            this.B_All_reset.Location = new System.Drawing.Point(1108, 320);
            this.B_All_reset.Name = "B_All_reset";
            this.B_All_reset.Padding = new System.Windows.Forms.Padding(1);
            this.B_All_reset.Size = new System.Drawing.Size(64, 64);
            this.B_All_reset.TabIndex = 246;
            this.B_All_reset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.B_All_reset, "Скинути початкову позицію всіх роторів");
            this.B_All_reset.UseVisualStyleBackColor = false;
            this.B_All_reset.Click += new System.EventHandler(this.B_Reset_All_Click);
            // 
            // B_Reset
            // 
            this.B_Reset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.B_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Reset.BackgroundImage = global::Enigma.Properties.Resources.Repeat_4_icon;
            this.B_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Reset.FlatAppearance.BorderSize = 0;
            this.B_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Reset.Font = new System.Drawing.Font("Segoe Script", 8.25F);
            this.B_Reset.ForeColor = System.Drawing.Color.White;
            this.B_Reset.Location = new System.Drawing.Point(1039, 320);
            this.B_Reset.Name = "B_Reset";
            this.B_Reset.Size = new System.Drawing.Size(65, 64);
            this.B_Reset.TabIndex = 247;
            this.B_Reset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.B_Reset, "Скинути початкову позицію обраного ротора");
            this.B_Reset.UseVisualStyleBackColor = false;
            this.B_Reset.Click += new System.EventHandler(this.B_Reset_Click);
            // 
            // B_Down
            // 
            this.B_Down.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.B_Down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B_Down.BackgroundImage")));
            this.B_Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Down.FlatAppearance.BorderSize = 0;
            this.B_Down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Down.Font = new System.Drawing.Font("Segoe Script", 8.25F);
            this.B_Down.ForeColor = System.Drawing.Color.White;
            this.B_Down.Location = new System.Drawing.Point(1108, 199);
            this.B_Down.Name = "B_Down";
            this.B_Down.Size = new System.Drawing.Size(64, 64);
            this.B_Down.TabIndex = 248;
            this.B_Down.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.B_Down, "Змінити порядок роторів опустивши по таблиці виділений ротор");
            this.B_Down.UseVisualStyleBackColor = false;
            this.B_Down.Click += new System.EventHandler(this.B_Down_Click);
            // 
            // B_Up
            // 
            this.B_Up.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.B_Up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B_Up.BackgroundImage")));
            this.B_Up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Up.FlatAppearance.BorderSize = 0;
            this.B_Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Up.Font = new System.Drawing.Font("Segoe Script", 8.25F);
            this.B_Up.ForeColor = System.Drawing.Color.White;
            this.B_Up.Location = new System.Drawing.Point(1039, 199);
            this.B_Up.Name = "B_Up";
            this.B_Up.Size = new System.Drawing.Size(64, 64);
            this.B_Up.TabIndex = 249;
            this.B_Up.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.B_Up, "Змінити порядок роторів піднявши по таблиці виділений ротор");
            this.B_Up.UseVisualStyleBackColor = false;
            this.B_Up.Click += new System.EventHandler(this.B_Up_Click);
            // 
            // B_Rem_Rotor
            // 
            this.B_Rem_Rotor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.B_Rem_Rotor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Rem_Rotor.BackgroundImage = global::Enigma.Properties.Resources.Close_icon;
            this.B_Rem_Rotor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Rem_Rotor.FlatAppearance.BorderSize = 0;
            this.B_Rem_Rotor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Rem_Rotor.Font = new System.Drawing.Font("Segoe Script", 8.25F);
            this.B_Rem_Rotor.ForeColor = System.Drawing.Color.White;
            this.B_Rem_Rotor.Location = new System.Drawing.Point(1108, 98);
            this.B_Rem_Rotor.Name = "B_Rem_Rotor";
            this.B_Rem_Rotor.Size = new System.Drawing.Size(64, 64);
            this.B_Rem_Rotor.TabIndex = 250;
            this.B_Rem_Rotor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.B_Rem_Rotor, "Видалити обраний ротор");
            this.B_Rem_Rotor.UseVisualStyleBackColor = false;
            this.B_Rem_Rotor.Click += new System.EventHandler(this.B_Remove_Rotor_Click);
            // 
            // B_Rand_Rotor
            // 
            this.B_Rand_Rotor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.B_Rand_Rotor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Rand_Rotor.BackgroundImage = global::Enigma.Properties.Resources.Gaming_Dice_icon;
            this.B_Rand_Rotor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Rand_Rotor.FlatAppearance.BorderSize = 0;
            this.B_Rand_Rotor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Rand_Rotor.Font = new System.Drawing.Font("Segoe Script", 8.25F);
            this.B_Rand_Rotor.ForeColor = System.Drawing.Color.White;
            this.B_Rand_Rotor.Location = new System.Drawing.Point(1038, 98);
            this.B_Rand_Rotor.Name = "B_Rand_Rotor";
            this.B_Rand_Rotor.Size = new System.Drawing.Size(64, 64);
            this.B_Rand_Rotor.TabIndex = 251;
            this.B_Rand_Rotor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.B_Rand_Rotor, "Створити ротор з випадковою послідовністю символів");
            this.B_Rand_Rotor.UseVisualStyleBackColor = false;
            this.B_Rand_Rotor.Click += new System.EventHandler(this.B_Random_Rotor_Click);
            // 
            // B_Add_Rotor
            // 
            this.B_Add_Rotor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.B_Add_Rotor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Add_Rotor.BackgroundImage = global::Enigma.Properties.Resources.check_icon;
            this.B_Add_Rotor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Add_Rotor.FlatAppearance.BorderSize = 0;
            this.B_Add_Rotor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Add_Rotor.Font = new System.Drawing.Font("Segoe Script", 8.25F);
            this.B_Add_Rotor.ForeColor = System.Drawing.Color.White;
            this.B_Add_Rotor.Location = new System.Drawing.Point(970, 98);
            this.B_Add_Rotor.Name = "B_Add_Rotor";
            this.B_Add_Rotor.Size = new System.Drawing.Size(64, 64);
            this.B_Add_Rotor.TabIndex = 252;
            this.B_Add_Rotor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.B_Add_Rotor, "Додати новий ротор за допомогою ручного вводу");
            this.B_Add_Rotor.UseVisualStyleBackColor = false;
            this.B_Add_Rotor.Click += new System.EventHandler(this.B_New_Rotor_Click);
            // 
            // L_Combinations
            // 
            this.L_Combinations.AutoSize = true;
            this.L_Combinations.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.L_Combinations.ForeColor = System.Drawing.Color.White;
            this.L_Combinations.Location = new System.Drawing.Point(71, 647);
            this.L_Combinations.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_Combinations.Name = "L_Combinations";
            this.L_Combinations.Size = new System.Drawing.Size(23, 32);
            this.L_Combinations.TabIndex = 264;
            this.L_Combinations.Text = "_";
            // 
            // B_Compinations
            // 
            this.B_Compinations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Compinations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Compinations.BackgroundImage = global::Enigma.Properties.Resources.Bakelite_icon;
            this.B_Compinations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Compinations.FlatAppearance.BorderSize = 0;
            this.B_Compinations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Compinations.Font = new System.Drawing.Font("Segoe Script", 8.25F);
            this.B_Compinations.ForeColor = System.Drawing.Color.White;
            this.B_Compinations.Location = new System.Drawing.Point(18, 631);
            this.B_Compinations.Name = "B_Compinations";
            this.B_Compinations.Size = new System.Drawing.Size(48, 43);
            this.B_Compinations.TabIndex = 266;
            this.B_Compinations.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.B_Compinations.UseVisualStyleBackColor = false;
            this.B_Compinations.Click += new System.EventHandler(this.B_Compinations_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 386);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 38);
            this.label6.TabIndex = 263;
            this.label6.Text = "Рефлектор:";
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 50;
            this.elipseControl1.TargetControl = this;
            // 
            // F_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1190, 697);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.B_Compinations);
            this.Controls.Add(this.B_Remove_Couple);
            this.Controls.Add(this.T_K2);
            this.Controls.Add(this.T_K1);
            this.Controls.Add(this.T_Reflector);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.L_Combinations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.L_Alpha_K);
            this.Controls.Add(this.L_Alph_Reflect);
            this.Controls.Add(this.B_Rand_Reflector);
            this.Controls.Add(this.B_All_reset);
            this.Controls.Add(this.B_Reset);
            this.Controls.Add(this.B_Down);
            this.Controls.Add(this.B_Up);
            this.Controls.Add(this.B_Rem_Rotor);
            this.Controls.Add(this.Num_Ring);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.L_Alpha_Rotor);
            this.Controls.Add(this.T_New_Rotor);
            this.Controls.Add(this.B_Rand_Rotor);
            this.Controls.Add(this.B_Add_Rotor);
            this.Controls.Add(this.CaptureModul);
            this.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_Settings";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Налаштування";
            this.Load += new System.EventHandler(this.F_Settings_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WhoIam);
            this.CaptureModul.ResumeLayout(false);
            this.CaptureModul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Ring)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button B_Exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel CaptureModul;
        private ElipseControl elipseControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button B_Instruction;
        private System.Windows.Forms.Button B_Export;
        private System.Windows.Forms.Button B_Import;
        private System.Windows.Forms.Button B_Done;
        private System.Windows.Forms.Button B_All_reset;
        private System.Windows.Forms.Button B_Reset;
        private System.Windows.Forms.Button B_Down;
        private System.Windows.Forms.Button B_Up;
        private System.Windows.Forms.Button B_Rem_Rotor;
        private System.Windows.Forms.NumericUpDown Num_Ring;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label L_Alpha_Rotor;
        private System.Windows.Forms.TextBox T_New_Rotor;
        private System.Windows.Forms.Button B_Rand_Rotor;
        private System.Windows.Forms.Button B_Add_Rotor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button B_Remove_Couple;
        private System.Windows.Forms.TextBox T_K2;
        private System.Windows.Forms.TextBox T_K1;
        private System.Windows.Forms.TextBox T_Reflector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label L_Alpha_K;
        private System.Windows.Forms.Label L_Alph_Reflect;
        private System.Windows.Forms.Button B_Rand_Reflector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Compinations;
        private System.Windows.Forms.Label L_Combinations;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}