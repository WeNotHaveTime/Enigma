namespace Enigma
{
    partial class F_Help_for_Cript
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Help_for_Cript));
            this.CaptureModul = new System.Windows.Forms.Panel();
            this.B_WHO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.B_Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.elipseControl1 = new Enigma.ElipseControl();
            this.CaptureModul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CaptureModul
            // 
            this.CaptureModul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.CaptureModul.Controls.Add(this.B_WHO);
            this.CaptureModul.Controls.Add(this.label1);
            this.CaptureModul.Controls.Add(this.B_Exit);
            this.CaptureModul.Dock = System.Windows.Forms.DockStyle.Top;
            this.CaptureModul.Location = new System.Drawing.Point(0, 0);
            this.CaptureModul.Name = "CaptureModul";
            this.CaptureModul.Size = new System.Drawing.Size(722, 51);
            this.CaptureModul.TabIndex = 17;
            this.CaptureModul.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CapturModul_MouseDown);
            // 
            // B_WHO
            // 
            this.B_WHO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.B_WHO.BackgroundImage = global::Enigma.Properties.Resources.Enigma_ENG_icon;
            this.B_WHO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_WHO.Cursor = System.Windows.Forms.Cursors.Help;
            this.B_WHO.FlatAppearance.BorderSize = 0;
            this.B_WHO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_WHO.Location = new System.Drawing.Point(0, 0);
            this.B_WHO.Margin = new System.Windows.Forms.Padding(0);
            this.B_WHO.Name = "B_WHO";
            this.B_WHO.Size = new System.Drawing.Size(51, 47);
            this.B_WHO.TabIndex = 135;
            this.B_WHO.UseVisualStyleBackColor = false;
            this.B_WHO.Click += new System.EventHandler(this.B_WHO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(54, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 42);
            this.label1.TabIndex = 15;
            this.label1.Text = "Enigma";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CapturModul_MouseDown);
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
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 412);
            this.label2.TabIndex = 18;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(87, 469);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(195, 38);
            this.linkLabel1.TabIndex = 136;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Wikipedia.org";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Enigma.Properties.Resources.Enigma;
            this.pictureBox1.Location = new System.Drawing.Point(375, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 50;
            this.elipseControl1.TargetControl = this;
            // 
            // F_Help_for_Cript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(5, 0);
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(722, 523);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CaptureModul);
            this.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "F_Help_for_Cript";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Help_for_Cript";
            this.Load += new System.EventHandler(this.F_Help_for_Cript_Load);
            this.CaptureModul.ResumeLayout(false);
            this.CaptureModul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CaptureModul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B_WHO;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ElipseControl elipseControl1;
    }
}