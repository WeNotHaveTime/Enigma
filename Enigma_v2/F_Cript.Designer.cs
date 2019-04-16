namespace Enigma
{
    partial class F_Cript
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Cript));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.B_Settings = new System.Windows.Forms.Button();
            this.B_Cript = new System.Windows.Forms.Button();
            this.CaptureModul = new System.Windows.Forms.Panel();
            this.B_Instruction = new System.Windows.Forms.Button();
            this.B_Exit = new System.Windows.Forms.Button();
            this.elipseControl1 = new Enigma.ElipseControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.T_Input = new System.Windows.Forms.RichTextBox();
            this.T_Cript = new System.Windows.Forms.RichTextBox();
            this.CaptureModul.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(57, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enigma";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CapturModul_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Текст:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Шифр:";
            // 
            // B_Settings
            // 
            this.B_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Settings.FlatAppearance.BorderSize = 0;
            this.B_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Settings.ForeColor = System.Drawing.Color.White;
            this.B_Settings.Location = new System.Drawing.Point(620, 0);
            this.B_Settings.Margin = new System.Windows.Forms.Padding(0);
            this.B_Settings.Name = "B_Settings";
            this.B_Settings.Size = new System.Drawing.Size(168, 47);
            this.B_Settings.TabIndex = 12;
            this.B_Settings.Text = "Налаштування";
            this.B_Settings.UseVisualStyleBackColor = false;
            this.B_Settings.Click += new System.EventHandler(this.B_Settings_Click);
            // 
            // B_Cript
            // 
            this.B_Cript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Cript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Cript.FlatAppearance.BorderSize = 0;
            this.B_Cript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Cript.ForeColor = System.Drawing.Color.White;
            this.B_Cript.Location = new System.Drawing.Point(486, 0);
            this.B_Cript.Margin = new System.Windows.Forms.Padding(0);
            this.B_Cript.Name = "B_Cript";
            this.B_Cript.Size = new System.Drawing.Size(134, 47);
            this.B_Cript.TabIndex = 12;
            this.B_Cript.Text = "Шифрувати";
            this.B_Cript.UseVisualStyleBackColor = false;
            this.B_Cript.Click += new System.EventHandler(this.B_Cript_Click);
            // 
            // CaptureModul
            // 
            this.CaptureModul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.CaptureModul.Controls.Add(this.B_Instruction);
            this.CaptureModul.Dock = System.Windows.Forms.DockStyle.Top;
            this.CaptureModul.Location = new System.Drawing.Point(0, 0);
            this.CaptureModul.Name = "CaptureModul";
            this.CaptureModul.Size = new System.Drawing.Size(840, 51);
            this.CaptureModul.TabIndex = 14;
            this.CaptureModul.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CapturModul_MouseDown);
            // 
            // B_Instruction
            // 
            this.B_Instruction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.B_Instruction.TabIndex = 135;
            this.B_Instruction.UseVisualStyleBackColor = false;
            this.B_Instruction.Click += new System.EventHandler(this.B_Instruction_Click);
            // 
            // B_Exit
            // 
            this.B_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_Exit.BackgroundImage = global::Enigma.Properties.Resources.Close_icon;
            this.B_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Exit.FlatAppearance.BorderSize = 0;
            this.B_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Exit.Location = new System.Drawing.Point(788, 0);
            this.B_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(51, 47);
            this.B_Exit.TabIndex = 13;
            this.B_Exit.UseVisualStyleBackColor = false;
            this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 50;
            this.elipseControl1.TargetControl = this;
            // 
            // T_Input
            // 
            this.T_Input.BackColor = System.Drawing.Color.DarkGray;
            this.T_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.T_Input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.T_Input.DetectUrls = false;
            this.T_Input.ForeColor = System.Drawing.Color.White;
            this.T_Input.Location = new System.Drawing.Point(98, 59);
            this.T_Input.Name = "T_Input";
            this.T_Input.Size = new System.Drawing.Size(730, 272);
            this.T_Input.TabIndex = 1000;
            this.T_Input.Text = "";
            // 
            // T_Cript
            // 
            this.T_Cript.BackColor = System.Drawing.Color.DarkGray;
            this.T_Cript.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.T_Cript.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.T_Cript.DetectUrls = false;
            this.T_Cript.ForeColor = System.Drawing.Color.White;
            this.T_Cript.Location = new System.Drawing.Point(98, 339);
            this.T_Cript.Name = "T_Cript";
            this.T_Cript.ReadOnly = true;
            this.T_Cript.Size = new System.Drawing.Size(730, 110);
            this.T_Cript.TabIndex = 1000;
            this.T_Cript.Text = "";
            // 
            // F_Cript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(840, 472);
            this.ControlBox = false;
            this.Controls.Add(this.T_Cript);
            this.Controls.Add(this.T_Input);
            this.Controls.Add(this.B_Exit);
            this.Controls.Add(this.B_Cript);
            this.Controls.Add(this.B_Settings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CaptureModul);
            this.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "F_Cript";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.F_Cript_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WhoIam);
            this.CaptureModul.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ElipseControl elipseControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B_Settings;
        private System.Windows.Forms.Button B_Cript;
        private System.Windows.Forms.Button B_Exit;
        private System.Windows.Forms.Panel CaptureModul;
        private System.Windows.Forms.Button B_Instruction;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox T_Input;
        private System.Windows.Forms.RichTextBox T_Cript;
    }
}