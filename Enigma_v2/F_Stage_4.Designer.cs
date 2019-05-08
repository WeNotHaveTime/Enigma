namespace Enigma
{
    partial class F_Stage_4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Stage_4));
            this.CaptureModul = new System.Windows.Forms.Panel();
            this.B_Back = new System.Windows.Forms.Button();
            this.B_Save = new System.Windows.Forms.Button();
            this.B_Instruction = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.elipseControl1 = new Enigma.ElipseControl();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Remove_Couple = new System.Windows.Forms.Button();
            this.T_K2 = new System.Windows.Forms.TextBox();
            this.T_K1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.L_Alpha_K = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.CaptureModul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // CaptureModul
            // 
            this.CaptureModul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.CaptureModul.Controls.Add(this.B_Back);
            this.CaptureModul.Controls.Add(this.B_Save);
            this.CaptureModul.Controls.Add(this.B_Instruction);
            this.CaptureModul.Controls.Add(this.label6);
            this.CaptureModul.Controls.Add(this.label3);
            this.CaptureModul.Dock = System.Windows.Forms.DockStyle.Top;
            this.CaptureModul.Location = new System.Drawing.Point(0, 0);
            this.CaptureModul.Margin = new System.Windows.Forms.Padding(6);
            this.CaptureModul.Name = "CaptureModul";
            this.CaptureModul.Size = new System.Drawing.Size(722, 49);
            this.CaptureModul.TabIndex = 138;
            this.CaptureModul.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CapturModul_MouseDown);
            // 
            // B_Back
            // 
            this.B_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Back.BackgroundImage = global::Enigma.Properties.Resources.back;
            this.B_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Back.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.B_Back.FlatAppearance.BorderSize = 0;
            this.B_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Back.Font = new System.Drawing.Font("Segoe Script", 8.25F);
            this.B_Back.ForeColor = System.Drawing.Color.White;
            this.B_Back.Location = new System.Drawing.Point(622, 0);
            this.B_Back.Margin = new System.Windows.Forms.Padding(0);
            this.B_Back.Name = "B_Back";
            this.B_Back.Size = new System.Drawing.Size(51, 47);
            this.B_Back.TabIndex = 277;
            this.B_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.B_Back, "Назад");
            this.B_Back.UseVisualStyleBackColor = false;
            this.B_Back.Click += new System.EventHandler(this.B_Back_Click);
            // 
            // B_Save
            // 
            this.B_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Save.BackgroundImage = global::Enigma.Properties.Resources.check_icon;
            this.B_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Save.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.B_Save.FlatAppearance.BorderSize = 0;
            this.B_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Save.Font = new System.Drawing.Font("Segoe Script", 8.25F);
            this.B_Save.ForeColor = System.Drawing.Color.White;
            this.B_Save.Location = new System.Drawing.Point(673, 0);
            this.B_Save.Margin = new System.Windows.Forms.Padding(0);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(51, 47);
            this.B_Save.TabIndex = 277;
            this.B_Save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.B_Save, "Готово");
            this.B_Save.UseVisualStyleBackColor = false;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(191, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(347, 42);
            this.label6.TabIndex = 272;
            this.label6.Text = "Комутаційна панель";
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CapturModul_MouseDown);
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
            this.label3.Text = "Етап 4:";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CapturModul_MouseDown);
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 50;
            this.elipseControl1.TargetControl = this;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.Location = new System.Drawing.Point(590, 57);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.ShowCellErrors = false;
            this.dataGridView2.ShowCellToolTips = false;
            this.dataGridView2.ShowEditingIcon = false;
            this.dataGridView2.ShowRowErrors = false;
            this.dataGridView2.Size = new System.Drawing.Size(121, 178);
            this.dataGridView2.TabIndex = 274;
            this.dataGridView2.TabStop = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Пара";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // B_Remove_Couple
            // 
            this.B_Remove_Couple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Remove_Couple.BackgroundImage = global::Enigma.Properties.Resources.Close_icon;
            this.B_Remove_Couple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Remove_Couple.FlatAppearance.BorderSize = 0;
            this.B_Remove_Couple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Remove_Couple.Font = new System.Drawing.Font("Segoe Script", 8.25F);
            this.B_Remove_Couple.ForeColor = System.Drawing.Color.White;
            this.B_Remove_Couple.Location = new System.Drawing.Point(521, 171);
            this.B_Remove_Couple.Name = "B_Remove_Couple";
            this.B_Remove_Couple.Size = new System.Drawing.Size(64, 64);
            this.B_Remove_Couple.TabIndex = 273;
            this.B_Remove_Couple.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.B_Remove_Couple, "Видалити комутаційну пару");
            this.B_Remove_Couple.UseVisualStyleBackColor = false;
            this.B_Remove_Couple.Click += new System.EventHandler(this.B_Remove_Couple_Click);
            // 
            // T_K2
            // 
            this.T_K2.BackColor = System.Drawing.Color.DarkGray;
            this.T_K2.ForeColor = System.Drawing.Color.White;
            this.T_K2.Location = new System.Drawing.Point(198, 162);
            this.T_K2.MaxLength = 1;
            this.T_K2.Name = "T_K2";
            this.T_K2.Size = new System.Drawing.Size(44, 33);
            this.T_K2.TabIndex = 269;
            this.T_K2.TextChanged += new System.EventHandler(this.T_K2_TextChanged);
            // 
            // T_K1
            // 
            this.T_K1.BackColor = System.Drawing.Color.DarkGray;
            this.T_K1.ForeColor = System.Drawing.Color.White;
            this.T_K1.Location = new System.Drawing.Point(148, 162);
            this.T_K1.MaxLength = 1;
            this.T_K1.Name = "T_K1";
            this.T_K1.Size = new System.Drawing.Size(44, 33);
            this.T_K1.TabIndex = 268;
            this.T_K1.TextChanged += new System.EventHandler(this.T_K1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(519, 75);
            this.label5.TabIndex = 270;
            this.label5.Text = "Комутаційна панель використовується як додатковий\r\nспосіб задання пари заміни. За" +
    "міна в ході роботи\r\nпрограми буде використовуватись двічі.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 271;
            this.label2.Text = "Введіть пару:";
            // 
            // L_Alpha_K
            // 
            this.L_Alpha_K.AutoEllipsis = true;
            this.L_Alpha_K.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.L_Alpha_K.ForeColor = System.Drawing.Color.White;
            this.L_Alpha_K.Location = new System.Drawing.Point(11, 140);
            this.L_Alpha_K.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_Alpha_K.Name = "L_Alpha_K";
            this.L_Alpha_K.Size = new System.Drawing.Size(574, 25);
            this.L_Alpha_K.TabIndex = 272;
            this.L_Alpha_K.Text = "Алфавіт\r\n";
            // 
            // F_Stage_4
            // 
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(722, 246);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.B_Remove_Couple);
            this.Controls.Add(this.T_K2);
            this.Controls.Add(this.T_K1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.L_Alpha_K);
            this.Controls.Add(this.CaptureModul);
            this.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Stage_4";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.F_Stage_4_Load);
            this.CaptureModul.ResumeLayout(false);
            this.CaptureModul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CaptureModul;
        private System.Windows.Forms.Button B_Back;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.Button B_Instruction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private ElipseControl elipseControl1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button B_Remove_Couple;
        private System.Windows.Forms.TextBox T_K2;
        private System.Windows.Forms.TextBox T_K1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label L_Alpha_K;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}