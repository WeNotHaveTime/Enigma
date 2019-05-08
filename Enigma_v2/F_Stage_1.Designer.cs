namespace Enigma
{
    partial class F_Stage_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Stage_1));
            this.CaptureModul = new System.Windows.Forms.Panel();
            this.B_Instruction = new System.Windows.Forms.Button();
            this.B_Next = new System.Windows.Forms.Button();
            this.B_Exit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CH_Sensitivity = new System.Windows.Forms.CheckBox();
            this.T_Alphabet = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.elipseControl1 = new Enigma.ElipseControl();
            this.CaptureModul.SuspendLayout();
            this.SuspendLayout();
            // 
            // CaptureModul
            // 
            this.CaptureModul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.CaptureModul.Controls.Add(this.B_Instruction);
            this.CaptureModul.Controls.Add(this.B_Next);
            this.CaptureModul.Controls.Add(this.B_Exit);
            this.CaptureModul.Controls.Add(this.label7);
            this.CaptureModul.Controls.Add(this.label3);
            this.CaptureModul.Dock = System.Windows.Forms.DockStyle.Top;
            this.CaptureModul.Location = new System.Drawing.Point(0, 0);
            this.CaptureModul.Margin = new System.Windows.Forms.Padding(6);
            this.CaptureModul.Name = "CaptureModul";
            this.CaptureModul.Size = new System.Drawing.Size(722, 49);
            this.CaptureModul.TabIndex = 136;
            this.CaptureModul.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CapturModul_MouseDown);
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
            this.B_Next.Location = new System.Drawing.Point(620, 2);
            this.B_Next.Margin = new System.Windows.Forms.Padding(0);
            this.B_Next.Name = "B_Next";
            this.B_Next.Size = new System.Drawing.Size(51, 47);
            this.B_Next.TabIndex = 279;
            this.B_Next.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.B_Next, "Далі");
            this.B_Next.UseVisualStyleBackColor = false;
            this.B_Next.Click += new System.EventHandler(this.B_Next_Click);
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
            this.B_Exit.TabIndex = 134;
            this.toolTip1.SetToolTip(this.B_Exit, "Скасувати");
            this.B_Exit.UseVisualStyleBackColor = false;
            this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(191, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 42);
            this.label7.TabIndex = 272;
            this.label7.Text = "Алфавіт";
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CapturModul_MouseDown);
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
            this.label3.Text = "Етап 1:";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CapturModul_MouseDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(697, 125);
            this.label8.TabIndex = 274;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // CH_Sensitivity
            // 
            this.CH_Sensitivity.AutoSize = true;
            this.CH_Sensitivity.ForeColor = System.Drawing.Color.White;
            this.CH_Sensitivity.Location = new System.Drawing.Point(463, 155);
            this.CH_Sensitivity.Name = "CH_Sensitivity";
            this.CH_Sensitivity.Size = new System.Drawing.Size(247, 29);
            this.CH_Sensitivity.TabIndex = 273;
            this.CH_Sensitivity.Text = "Чутливість до регістру";
            this.CH_Sensitivity.UseVisualStyleBackColor = true;
            // 
            // T_Alphabet
            // 
            this.T_Alphabet.AutoCompleteCustomSource.AddRange(new string[] {
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
            "АБВГҐДЕЁЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЪЫЬЮЯ",
            "0123456789",
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ!.,-?0123456789 АБВГҐДЕЁЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЪЫЬЮЯ",
            "АБВГДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ"});
            this.T_Alphabet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.T_Alphabet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.T_Alphabet.BackColor = System.Drawing.Color.DarkGray;
            this.T_Alphabet.Cursor = System.Windows.Forms.Cursors.Default;
            this.T_Alphabet.ForeColor = System.Drawing.Color.White;
            this.T_Alphabet.Location = new System.Drawing.Point(17, 193);
            this.T_Alphabet.Margin = new System.Windows.Forms.Padding(6);
            this.T_Alphabet.Name = "T_Alphabet";
            this.T_Alphabet.Size = new System.Drawing.Size(692, 33);
            this.T_Alphabet.TabIndex = 271;
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 50;
            this.elipseControl1.TargetControl = this;
            // 
            // F_Stage_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(722, 244);
            this.Controls.Add(this.CH_Sensitivity);
            this.Controls.Add(this.T_Alphabet);
            this.Controls.Add(this.CaptureModul);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "F_Stage_1";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.F_Stage1_Load);
            this.CaptureModul.ResumeLayout(false);
            this.CaptureModul.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel CaptureModul;
        private System.Windows.Forms.Button B_Instruction;
        private System.Windows.Forms.Button B_Exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox CH_Sensitivity;
        private System.Windows.Forms.TextBox T_Alphabet;
        private ElipseControl elipseControl1;
        private System.Windows.Forms.Button B_Next;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}