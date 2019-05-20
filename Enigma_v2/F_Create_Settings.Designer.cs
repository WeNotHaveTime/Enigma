namespace Enigma
{
    partial class F_Create_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Create_Settings));
            this.CaptureModul = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.B_Instruction = new System.Windows.Forms.Button();
            this.B_Custom = new System.Windows.Forms.Button();
            this.B_Ok = new System.Windows.Forms.Button();
            this.B_Exit = new System.Windows.Forms.Button();
            this.L_Aplhabet = new System.Windows.Forms.Label();
            this.L_Rotors = new System.Windows.Forms.Label();
            this.L_Reflector = new System.Windows.Forms.Label();
            this.Num_Rotors = new System.Windows.Forms.NumericUpDown();
            this.L_Plugboard = new System.Windows.Forms.Label();
            this.Num_Plugboard = new System.Windows.Forms.NumericUpDown();
            this.C_Alphabet = new System.Windows.Forms.ComboBox();
            this.elipseControl1 = new Enigma.ElipseControl();
            this.CaptureModul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Rotors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Plugboard)).BeginInit();
            this.SuspendLayout();
            // 
            // CaptureModul
            // 
            this.CaptureModul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.CaptureModul.Controls.Add(this.label1);
            this.CaptureModul.Controls.Add(this.B_Instruction);
            this.CaptureModul.Controls.Add(this.B_Custom);
            this.CaptureModul.Controls.Add(this.B_Ok);
            this.CaptureModul.Controls.Add(this.B_Exit);
            this.CaptureModul.Dock = System.Windows.Forms.DockStyle.Top;
            this.CaptureModul.Location = new System.Drawing.Point(0, 0);
            this.CaptureModul.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CaptureModul.Name = "CaptureModul";
            this.CaptureModul.Size = new System.Drawing.Size(722, 49);
            this.CaptureModul.TabIndex = 18;
            this.CaptureModul.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CapturModul_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(56, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 42);
            this.label1.TabIndex = 15;
            this.label1.Text = "Атвоматизований спосіб\r\n";
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
            // B_Custom
            // 
            this.B_Custom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Custom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Custom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B_Custom.BackgroundImage")));
            this.B_Custom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Custom.FlatAppearance.BorderSize = 0;
            this.B_Custom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Custom.Location = new System.Drawing.Point(569, 0);
            this.B_Custom.Margin = new System.Windows.Forms.Padding(0);
            this.B_Custom.Name = "B_Custom";
            this.B_Custom.Size = new System.Drawing.Size(51, 47);
            this.B_Custom.TabIndex = 16;
            this.B_Custom.UseVisualStyleBackColor = false;
            this.B_Custom.Click += new System.EventHandler(this.B_Custom_Click);
            // 
            // B_Ok
            // 
            this.B_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Ok.BackgroundImage = global::Enigma.Properties.Resources.check_icon;
            this.B_Ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Ok.FlatAppearance.BorderSize = 0;
            this.B_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Ok.Location = new System.Drawing.Point(620, 0);
            this.B_Ok.Margin = new System.Windows.Forms.Padding(0);
            this.B_Ok.Name = "B_Ok";
            this.B_Ok.Size = new System.Drawing.Size(51, 47);
            this.B_Ok.TabIndex = 16;
            this.B_Ok.UseVisualStyleBackColor = false;
            this.B_Ok.Click += new System.EventHandler(this.B_Ok_Click);
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
            // L_Aplhabet
            // 
            this.L_Aplhabet.AutoSize = true;
            this.L_Aplhabet.Cursor = System.Windows.Forms.Cursors.Help;
            this.L_Aplhabet.ForeColor = System.Drawing.Color.White;
            this.L_Aplhabet.Location = new System.Drawing.Point(12, 55);
            this.L_Aplhabet.Name = "L_Aplhabet";
            this.L_Aplhabet.Size = new System.Drawing.Size(100, 25);
            this.L_Aplhabet.TabIndex = 277;
            this.L_Aplhabet.Text = "Алфавіт:";
            this.L_Aplhabet.Click += new System.EventHandler(this.L_Alphabet_Click);
            // 
            // L_Rotors
            // 
            this.L_Rotors.AutoSize = true;
            this.L_Rotors.Cursor = System.Windows.Forms.Cursors.Help;
            this.L_Rotors.ForeColor = System.Drawing.Color.White;
            this.L_Rotors.Location = new System.Drawing.Point(12, 127);
            this.L_Rotors.Name = "L_Rotors";
            this.L_Rotors.Size = new System.Drawing.Size(449, 25);
            this.L_Rotors.TabIndex = 277;
            this.L_Rotors.Text = "Ротори: вказати кількість випадкових роторів.\r\n";
            this.L_Rotors.Click += new System.EventHandler(this.L_Rotors_Click);
            // 
            // L_Reflector
            // 
            this.L_Reflector.AutoSize = true;
            this.L_Reflector.Cursor = System.Windows.Forms.Cursors.Help;
            this.L_Reflector.ForeColor = System.Drawing.Color.White;
            this.L_Reflector.Location = new System.Drawing.Point(12, 91);
            this.L_Reflector.Name = "L_Reflector";
            this.L_Reflector.Size = new System.Drawing.Size(364, 25);
            this.L_Reflector.TabIndex = 277;
            this.L_Reflector.Text = "Рефлектор буде створений випадковий.";
            this.L_Reflector.Click += new System.EventHandler(this.L_Reflector_Click);
            // 
            // Num_Rotors
            // 
            this.Num_Rotors.Location = new System.Drawing.Point(581, 119);
            this.Num_Rotors.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.Num_Rotors.Name = "Num_Rotors";
            this.Num_Rotors.Size = new System.Drawing.Size(129, 33);
            this.Num_Rotors.TabIndex = 278;
            // 
            // L_Plugboard
            // 
            this.L_Plugboard.AutoSize = true;
            this.L_Plugboard.Cursor = System.Windows.Forms.Cursors.Help;
            this.L_Plugboard.ForeColor = System.Drawing.Color.White;
            this.L_Plugboard.Location = new System.Drawing.Point(12, 166);
            this.L_Plugboard.Name = "L_Plugboard";
            this.L_Plugboard.Size = new System.Drawing.Size(443, 25);
            this.L_Plugboard.TabIndex = 277;
            this.L_Plugboard.Text = "Комуптаційна панель: вказати кількість пар.\r\n";
            this.L_Plugboard.Click += new System.EventHandler(this.L_Plugboard_Click);
            // 
            // Num_Plugboard
            // 
            this.Num_Plugboard.Location = new System.Drawing.Point(581, 164);
            this.Num_Plugboard.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Num_Plugboard.Name = "Num_Plugboard";
            this.Num_Plugboard.Size = new System.Drawing.Size(129, 33);
            this.Num_Plugboard.TabIndex = 278;
            // 
            // C_Alphabet
            // 
            this.C_Alphabet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.C_Alphabet.FormattingEnabled = true;
            this.C_Alphabet.Items.AddRange(new object[] {
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ!.,-?0123456789 АБВГҐДЕЁЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЪЫЬЮЯ",
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ"});
            this.C_Alphabet.Location = new System.Drawing.Point(118, 55);
            this.C_Alphabet.Name = "C_Alphabet";
            this.C_Alphabet.Size = new System.Drawing.Size(592, 33);
            this.C_Alphabet.TabIndex = 279;
            this.C_Alphabet.SelectedIndexChanged += new System.EventHandler(this.C_Alphabet_SelectedIndexChanged);
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 50;
            this.elipseControl1.TargetControl = this;
            // 
            // F_Create_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(722, 217);
            this.Controls.Add(this.C_Alphabet);
            this.Controls.Add(this.Num_Plugboard);
            this.Controls.Add(this.Num_Rotors);
            this.Controls.Add(this.L_Reflector);
            this.Controls.Add(this.L_Plugboard);
            this.Controls.Add(this.L_Rotors);
            this.Controls.Add(this.L_Aplhabet);
            this.Controls.Add(this.CaptureModul);
            this.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "F_Create_Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Creaate_Settings";
            this.Load += new System.EventHandler(this.F_Creaate_Settings_Load);
            this.CaptureModul.ResumeLayout(false);
            this.CaptureModul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Rotors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Plugboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CaptureModul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Instruction;
        private System.Windows.Forms.Button B_Exit;
        private ElipseControl elipseControl1;
        private System.Windows.Forms.Label L_Aplhabet;
        private System.Windows.Forms.Label L_Reflector;
        private System.Windows.Forms.Label L_Rotors;
        private System.Windows.Forms.NumericUpDown Num_Rotors;
        private System.Windows.Forms.Label L_Plugboard;
        private System.Windows.Forms.ComboBox C_Alphabet;
        private System.Windows.Forms.NumericUpDown Num_Plugboard;
        private System.Windows.Forms.Button B_Custom;
        private System.Windows.Forms.Button B_Ok;
    }
}