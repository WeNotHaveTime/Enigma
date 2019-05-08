namespace Enigma
{
    partial class F_Stage_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Stage_2));
            this.elipseControl1 = new Enigma.ElipseControl();
            this.L_Alph_Reflect = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.T_Reflector = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.B_Instruction = new System.Windows.Forms.Button();
            this.B_Next = new System.Windows.Forms.Button();
            this.B_Rand_Reflector = new System.Windows.Forms.Button();
            this.B_Back = new System.Windows.Forms.Button();
            this.CaptureModul = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.CaptureModul.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 50;
            this.elipseControl1.TargetControl = this;
            // 
            // L_Alph_Reflect
            // 
            this.L_Alph_Reflect.AutoEllipsis = true;
            this.L_Alph_Reflect.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.L_Alph_Reflect.ForeColor = System.Drawing.Color.White;
            this.L_Alph_Reflect.Location = new System.Drawing.Point(10, 154);
            this.L_Alph_Reflect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_Alph_Reflect.Name = "L_Alph_Reflect";
            this.L_Alph_Reflect.Size = new System.Drawing.Size(697, 25);
            this.L_Alph_Reflect.TabIndex = 269;
            this.L_Alph_Reflect.Text = "Алфавіт";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(696, 100);
            this.label1.TabIndex = 269;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // T_Reflector
            // 
            this.T_Reflector.BackColor = System.Drawing.Color.DarkGray;
            this.T_Reflector.Cursor = System.Windows.Forms.Cursors.Default;
            this.T_Reflector.ForeColor = System.Drawing.Color.White;
            this.T_Reflector.Location = new System.Drawing.Point(15, 185);
            this.T_Reflector.Margin = new System.Windows.Forms.Padding(6);
            this.T_Reflector.Name = "T_Reflector";
            this.T_Reflector.Size = new System.Drawing.Size(692, 33);
            this.T_Reflector.TabIndex = 270;
            this.T_Reflector.TextChanged += new System.EventHandler(this.T_Reflector_TextChanged);
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
            this.label3.Text = "Етап 2:";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CapturModul_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(191, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 42);
            this.label6.TabIndex = 272;
            this.label6.Text = "Рефлектор";
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CapturModul_MouseDown);
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
            this.B_Next.Location = new System.Drawing.Point(671, 2);
            this.B_Next.Margin = new System.Windows.Forms.Padding(0);
            this.B_Next.Name = "B_Next";
            this.B_Next.Size = new System.Drawing.Size(51, 47);
            this.B_Next.TabIndex = 277;
            this.B_Next.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.B_Next, "Далі");
            this.B_Next.UseVisualStyleBackColor = false;
            this.B_Next.Click += new System.EventHandler(this.B_Next_Click);
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
            this.B_Rand_Reflector.Location = new System.Drawing.Point(564, 0);
            this.B_Rand_Reflector.Name = "B_Rand_Reflector";
            this.B_Rand_Reflector.Size = new System.Drawing.Size(53, 49);
            this.B_Rand_Reflector.TabIndex = 271;
            this.B_Rand_Reflector.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.B_Rand_Reflector, "Випадковий рефлектор");
            this.B_Rand_Reflector.UseVisualStyleBackColor = false;
            this.B_Rand_Reflector.Click += new System.EventHandler(this.B_Rand_Reflector_Click);
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
            this.B_Back.TabIndex = 277;
            this.B_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.B_Back, "Назад");
            this.B_Back.UseVisualStyleBackColor = false;
            this.B_Back.Click += new System.EventHandler(this.B_Back_Click);
            // 
            // CaptureModul
            // 
            this.CaptureModul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.CaptureModul.Controls.Add(this.B_Back);
            this.CaptureModul.Controls.Add(this.B_Rand_Reflector);
            this.CaptureModul.Controls.Add(this.B_Next);
            this.CaptureModul.Controls.Add(this.B_Instruction);
            this.CaptureModul.Controls.Add(this.label6);
            this.CaptureModul.Controls.Add(this.label3);
            this.CaptureModul.Dock = System.Windows.Forms.DockStyle.Top;
            this.CaptureModul.Location = new System.Drawing.Point(0, 0);
            this.CaptureModul.Margin = new System.Windows.Forms.Padding(6);
            this.CaptureModul.Name = "CaptureModul";
            this.CaptureModul.Size = new System.Drawing.Size(722, 49);
            this.CaptureModul.TabIndex = 137;
            this.CaptureModul.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CapturModul_MouseDown);
            // 
            // F_Stage_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(722, 235);
            this.Controls.Add(this.T_Reflector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_Alph_Reflect);
            this.Controls.Add(this.CaptureModul);
            this.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "F_Stage_2";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stage3";
            this.Load += new System.EventHandler(this.F_Stage_2_Load);
            this.CaptureModul.ResumeLayout(false);
            this.CaptureModul.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ElipseControl elipseControl1;
        private System.Windows.Forms.TextBox T_Reflector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L_Alph_Reflect;
        private System.Windows.Forms.Panel CaptureModul;
        private System.Windows.Forms.Button B_Back;
        private System.Windows.Forms.Button B_Rand_Reflector;
        private System.Windows.Forms.Button B_Next;
        private System.Windows.Forms.Button B_Instruction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}