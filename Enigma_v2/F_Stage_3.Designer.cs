namespace Enigma
{
    partial class F_Stage_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Stage_3));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CaptureModul = new System.Windows.Forms.Panel();
            this.B_Back = new System.Windows.Forms.Button();
            this.L_Num_Rotors = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.B_Next = new System.Windows.Forms.Button();
            this.B_Instruction = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Num_Ring = new System.Windows.Forms.NumericUpDown();
            this.L_Alpha_Rotor = new System.Windows.Forms.Label();
            this.T_New_Rotor = new System.Windows.Forms.TextBox();
            this.elipseControl1 = new Enigma.ElipseControl();
            this.label1 = new System.Windows.Forms.Label();
            this.B_All_reset = new System.Windows.Forms.Button();
            this.B_Reset = new System.Windows.Forms.Button();
            this.B_Down = new System.Windows.Forms.Button();
            this.B_Up = new System.Windows.Forms.Button();
            this.B_Rem_Rotor = new System.Windows.Forms.Button();
            this.B_Rand_Rotor = new System.Windows.Forms.Button();
            this.B_Add_Rotor = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Num_Rotors = new System.Windows.Forms.NumericUpDown();
            this.CaptureModul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Ring)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Rotors)).BeginInit();
            this.SuspendLayout();
            // 
            // CaptureModul
            // 
            this.CaptureModul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.CaptureModul.Controls.Add(this.B_Back);
            this.CaptureModul.Controls.Add(this.L_Num_Rotors);
            this.CaptureModul.Controls.Add(this.label4);
            this.CaptureModul.Controls.Add(this.B_Next);
            this.CaptureModul.Controls.Add(this.B_Instruction);
            this.CaptureModul.Controls.Add(this.label3);
            this.CaptureModul.Dock = System.Windows.Forms.DockStyle.Top;
            this.CaptureModul.Location = new System.Drawing.Point(0, 0);
            this.CaptureModul.Margin = new System.Windows.Forms.Padding(6);
            this.CaptureModul.Name = "CaptureModul";
            this.CaptureModul.Size = new System.Drawing.Size(722, 49);
            this.CaptureModul.TabIndex = 137;
            this.CaptureModul.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CapturModul_MouseDown);
            // 
            // B_Back
            // 
            this.B_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Back.BackgroundImage = global::Enigma.Properties.Resources.back;
            this.B_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Back.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.B_Back.FlatAppearance.BorderSize = 0;
            this.B_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Back.Font = new System.Drawing.Font("Segoe Script", 8.25F);
            this.B_Back.ForeColor = System.Drawing.Color.White;
            this.B_Back.Location = new System.Drawing.Point(620, 1);
            this.B_Back.Margin = new System.Windows.Forms.Padding(0);
            this.B_Back.Name = "B_Back";
            this.B_Back.Size = new System.Drawing.Size(51, 47);
            this.B_Back.TabIndex = 278;
            this.B_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.B_Back, "Назад");
            this.B_Back.UseVisualStyleBackColor = false;
            this.B_Back.Click += new System.EventHandler(this.B_Back_Click);
            // 
            // L_Num_Rotors
            // 
            this.L_Num_Rotors.AutoSize = true;
            this.L_Num_Rotors.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Num_Rotors.ForeColor = System.Drawing.Color.Black;
            this.L_Num_Rotors.Location = new System.Drawing.Point(336, 5);
            this.L_Num_Rotors.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_Num_Rotors.Name = "L_Num_Rotors";
            this.L_Num_Rotors.Size = new System.Drawing.Size(38, 42);
            this.L_Num_Rotors.TabIndex = 275;
            this.L_Num_Rotors.Text = "0";
            this.L_Num_Rotors.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CapturModul_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(206, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 42);
            this.label4.TabIndex = 275;
            this.label4.Text = "Ротори:";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CapturModul_MouseDown);
            // 
            // B_Next
            // 
            this.B_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Next.BackgroundImage = global::Enigma.Properties.Resources.next_icon;
            this.B_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Next.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.B_Next.FlatAppearance.BorderSize = 0;
            this.B_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Next.Font = new System.Drawing.Font("Segoe Script", 8.25F);
            this.B_Next.ForeColor = System.Drawing.Color.White;
            this.B_Next.Location = new System.Drawing.Point(671, 2);
            this.B_Next.Margin = new System.Windows.Forms.Padding(0);
            this.B_Next.Name = "B_Next";
            this.B_Next.Size = new System.Drawing.Size(51, 47);
            this.B_Next.TabIndex = 279;
            this.B_Next.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.B_Next, "Далі");
            this.B_Next.UseVisualStyleBackColor = false;
            this.B_Next.Click += new System.EventHandler(this.B_Next_Click);
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
            this.B_Instruction.TabIndex = 134;
            this.B_Instruction.UseVisualStyleBackColor = false;
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
            this.label3.Size = new System.Drawing.Size(141, 42);
            this.label3.TabIndex = 132;
            this.label3.Text = "Етап 3:";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CapturModul_MouseDown);
            // 
            // Num_Ring
            // 
            this.Num_Ring.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.Num_Ring.Location = new System.Drawing.Point(574, 363);
            this.Num_Ring.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.Num_Ring.Name = "Num_Ring";
            this.Num_Ring.Size = new System.Drawing.Size(134, 33);
            this.Num_Ring.TabIndex = 267;
            this.Num_Ring.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.Num_Ring, "Змінити позицію ротору");
            this.Num_Ring.ValueChanged += new System.EventHandler(this.Num_Ring_ValueChanged);
            // 
            // L_Alpha_Rotor
            // 
            this.L_Alpha_Rotor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Alpha_Rotor.AutoEllipsis = true;
            this.L_Alpha_Rotor.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.L_Alpha_Rotor.ForeColor = System.Drawing.Color.White;
            this.L_Alpha_Rotor.Location = new System.Drawing.Point(13, 180);
            this.L_Alpha_Rotor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_Alpha_Rotor.Name = "L_Alpha_Rotor";
            this.L_Alpha_Rotor.Size = new System.Drawing.Size(486, 25);
            this.L_Alpha_Rotor.TabIndex = 265;
            this.L_Alpha_Rotor.Text = "Алфавіт";
            // 
            // T_New_Rotor
            // 
            this.T_New_Rotor.BackColor = System.Drawing.Color.DarkGray;
            this.T_New_Rotor.Cursor = System.Windows.Forms.Cursors.Default;
            this.T_New_Rotor.ForeColor = System.Drawing.Color.White;
            this.T_New_Rotor.Location = new System.Drawing.Point(18, 211);
            this.T_New_Rotor.Margin = new System.Windows.Forms.Padding(6);
            this.T_New_Rotor.Name = "T_New_Rotor";
            this.T_New_Rotor.Size = new System.Drawing.Size(483, 33);
            this.T_New_Rotor.TabIndex = 264;
            this.T_New_Rotor.TextChanged += new System.EventHandler(this.T_New_Rotor_TextChanged);
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 50;
            this.elipseControl1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(651, 125);
            this.label1.TabIndex = 265;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // B_All_reset
            // 
            this.B_All_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_All_reset.BackgroundImage = global::Enigma.Properties.Resources.Reset_icon;
            this.B_All_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_All_reset.FlatAppearance.BorderSize = 0;
            this.B_All_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_All_reset.Font = new System.Drawing.Font("Segoe Script", 8.25F);
            this.B_All_reset.ForeColor = System.Drawing.Color.White;
            this.B_All_reset.Location = new System.Drawing.Point(644, 402);
            this.B_All_reset.Name = "B_All_reset";
            this.B_All_reset.Padding = new System.Windows.Forms.Padding(1);
            this.B_All_reset.Size = new System.Drawing.Size(64, 64);
            this.B_All_reset.TabIndex = 268;
            this.B_All_reset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.B_All_reset, "Скинути всі позиції роторів");
            this.B_All_reset.UseVisualStyleBackColor = false;
            this.B_All_reset.Click += new System.EventHandler(this.B_All_Reset_Click);
            // 
            // B_Reset
            // 
            this.B_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Reset.BackgroundImage = global::Enigma.Properties.Resources.Repeat_4_icon;
            this.B_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Reset.FlatAppearance.BorderSize = 0;
            this.B_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Reset.Font = new System.Drawing.Font("Segoe Script", 8.25F);
            this.B_Reset.ForeColor = System.Drawing.Color.White;
            this.B_Reset.Location = new System.Drawing.Point(575, 402);
            this.B_Reset.Name = "B_Reset";
            this.B_Reset.Size = new System.Drawing.Size(65, 64);
            this.B_Reset.TabIndex = 269;
            this.B_Reset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.B_Reset, "Скинути позицію ротору");
            this.B_Reset.UseVisualStyleBackColor = false;
            this.B_Reset.Click += new System.EventHandler(this.B_Reset_Click);
            // 
            // B_Down
            // 
            this.B_Down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B_Down.BackgroundImage")));
            this.B_Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Down.FlatAppearance.BorderSize = 0;
            this.B_Down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Down.Font = new System.Drawing.Font("Segoe Script", 8.25F);
            this.B_Down.ForeColor = System.Drawing.Color.White;
            this.B_Down.Location = new System.Drawing.Point(644, 293);
            this.B_Down.Name = "B_Down";
            this.B_Down.Size = new System.Drawing.Size(64, 64);
            this.B_Down.TabIndex = 270;
            this.B_Down.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.B_Down, "Перемістити ротор вгору");
            this.B_Down.UseVisualStyleBackColor = false;
            this.B_Down.Click += new System.EventHandler(this.B_Down_Click);
            // 
            // B_Up
            // 
            this.B_Up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B_Up.BackgroundImage")));
            this.B_Up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Up.FlatAppearance.BorderSize = 0;
            this.B_Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Up.Font = new System.Drawing.Font("Segoe Script", 8.25F);
            this.B_Up.ForeColor = System.Drawing.Color.White;
            this.B_Up.Location = new System.Drawing.Point(574, 293);
            this.B_Up.Name = "B_Up";
            this.B_Up.Size = new System.Drawing.Size(64, 64);
            this.B_Up.TabIndex = 271;
            this.B_Up.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.B_Up, "Перемістити ротор вгору");
            this.B_Up.UseVisualStyleBackColor = false;
            this.B_Up.Click += new System.EventHandler(this.B_Up_Click);
            // 
            // B_Rem_Rotor
            // 
            this.B_Rem_Rotor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Rem_Rotor.BackgroundImage = global::Enigma.Properties.Resources.Close_icon;
            this.B_Rem_Rotor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Rem_Rotor.FlatAppearance.BorderSize = 0;
            this.B_Rem_Rotor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Rem_Rotor.Font = new System.Drawing.Font("Segoe Script", 8.25F);
            this.B_Rem_Rotor.ForeColor = System.Drawing.Color.White;
            this.B_Rem_Rotor.Location = new System.Drawing.Point(644, 180);
            this.B_Rem_Rotor.Name = "B_Rem_Rotor";
            this.B_Rem_Rotor.Size = new System.Drawing.Size(64, 64);
            this.B_Rem_Rotor.TabIndex = 272;
            this.B_Rem_Rotor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.B_Rem_Rotor, "Видалити ротор");
            this.B_Rem_Rotor.UseVisualStyleBackColor = false;
            this.B_Rem_Rotor.Click += new System.EventHandler(this.B_Rem_Rotor_Click);
            // 
            // B_Rand_Rotor
            // 
            this.B_Rand_Rotor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Rand_Rotor.BackgroundImage = global::Enigma.Properties.Resources.Gaming_Dice_icon;
            this.B_Rand_Rotor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Rand_Rotor.FlatAppearance.BorderSize = 0;
            this.B_Rand_Rotor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Rand_Rotor.Font = new System.Drawing.Font("Segoe Script", 8.25F);
            this.B_Rand_Rotor.ForeColor = System.Drawing.Color.White;
            this.B_Rand_Rotor.Location = new System.Drawing.Point(574, 180);
            this.B_Rand_Rotor.Name = "B_Rand_Rotor";
            this.B_Rand_Rotor.Size = new System.Drawing.Size(64, 64);
            this.B_Rand_Rotor.TabIndex = 273;
            this.B_Rand_Rotor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.B_Rand_Rotor, "Випадковий ротор");
            this.B_Rand_Rotor.UseVisualStyleBackColor = false;
            this.B_Rand_Rotor.Click += new System.EventHandler(this.B_Rand_Rotor_Click);
            // 
            // B_Add_Rotor
            // 
            this.B_Add_Rotor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Add_Rotor.BackgroundImage = global::Enigma.Properties.Resources.check_icon;
            this.B_Add_Rotor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Add_Rotor.FlatAppearance.BorderSize = 0;
            this.B_Add_Rotor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Add_Rotor.Font = new System.Drawing.Font("Segoe Script", 8.25F);
            this.B_Add_Rotor.ForeColor = System.Drawing.Color.White;
            this.B_Add_Rotor.Location = new System.Drawing.Point(506, 180);
            this.B_Add_Rotor.Name = "B_Add_Rotor";
            this.B_Add_Rotor.Size = new System.Drawing.Size(64, 64);
            this.B_Add_Rotor.TabIndex = 274;
            this.B_Add_Rotor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.B_Add_Rotor, "Додати ротор");
            this.B_Add_Rotor.UseVisualStyleBackColor = false;
            this.B_Add_Rotor.Click += new System.EventHandler(this.B_Add_Rotor_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe Script", 10F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
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
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe Script", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(18, 247);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe Script", 10F);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(551, 219);
            this.dataGridView1.TabIndex = 275;
            this.dataGridView1.TabStop = false;
            this.toolTip1.SetToolTip(this.dataGridView1, "Колекція роторів");
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseDoubleClick);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DataGridView1_RowsRemoved);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 20.93909F;
            this.Column1.HeaderText = "Ротор";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 4.060913F;
            this.Column2.HeaderText = "Позиція";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Num_Rotors
            // 
            this.Num_Rotors.Location = new System.Drawing.Point(574, 247);
            this.Num_Rotors.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num_Rotors.Name = "Num_Rotors";
            this.Num_Rotors.Size = new System.Drawing.Size(134, 33);
            this.Num_Rotors.TabIndex = 276;
            this.Num_Rotors.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.Num_Rotors, "Згенерувати дану кількість випадкових роторів");
            this.Num_Rotors.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // F_Stage_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(722, 479);
            this.Controls.Add(this.Num_Rotors);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.B_All_reset);
            this.Controls.Add(this.B_Reset);
            this.Controls.Add(this.B_Down);
            this.Controls.Add(this.B_Up);
            this.Controls.Add(this.B_Rem_Rotor);
            this.Controls.Add(this.Num_Ring);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_Alpha_Rotor);
            this.Controls.Add(this.T_New_Rotor);
            this.Controls.Add(this.B_Rand_Rotor);
            this.Controls.Add(this.B_Add_Rotor);
            this.Controls.Add(this.CaptureModul);
            this.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "F_Stage_3";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.F_Stage_3_Load);
            this.CaptureModul.ResumeLayout(false);
            this.CaptureModul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Ring)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Rotors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CaptureModul;
        private System.Windows.Forms.Button B_Instruction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button B_All_reset;
        private System.Windows.Forms.Button B_Reset;
        private System.Windows.Forms.Button B_Down;
        private System.Windows.Forms.Button B_Up;
        private System.Windows.Forms.Button B_Rem_Rotor;
        private System.Windows.Forms.NumericUpDown Num_Ring;
        private System.Windows.Forms.Label L_Alpha_Rotor;
        private System.Windows.Forms.TextBox T_New_Rotor;
        private System.Windows.Forms.Button B_Rand_Rotor;
        private System.Windows.Forms.Button B_Add_Rotor;
        private ElipseControl elipseControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Back;
        private System.Windows.Forms.Button B_Next;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown Num_Rotors;
        private System.Windows.Forms.Label L_Num_Rotors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}