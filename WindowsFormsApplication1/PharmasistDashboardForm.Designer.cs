namespace WindowsFormsApplication1
{
    partial class PharmasistDashboardForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1090, 114);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pharmasist Dashboard";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Pharmacist_amico;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button11);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.button9);
            this.panel4.Controls.Add(this.button10);
            this.panel4.Controls.Add(this.button8);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Location = new System.Drawing.Point(0, 114);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1090, 426);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(772, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(13)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(616, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Log Out";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.SystemColors.Control;
            this.button11.Location = new System.Drawing.Point(928, 374);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(150, 40);
            this.button11.TabIndex = 2;
            this.button11.Text = "Admin Panel";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(869, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 110);
            this.button3.TabIndex = 0;
            this.button3.Text = "Add Medicine";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(317, 180);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 110);
            this.button5.TabIndex = 0;
            this.button5.Text = "Sell Medicine";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(83, 180);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 110);
            this.button6.TabIndex = 1;
            this.button6.Text = "Buy Medicine";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(83, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 110);
            this.button4.TabIndex = 0;
            this.button4.Text = "Manage Medicines";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(869, 22);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(200, 110);
            this.button7.TabIndex = 0;
            this.button7.Text = "Add Prescriptions";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.Location = new System.Drawing.Point(596, 22);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(200, 110);
            this.button9.TabIndex = 2;
            this.button9.Text = "Add Service";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.Location = new System.Drawing.Point(596, 180);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(200, 110);
            this.button10.TabIndex = 3;
            this.button10.Text = "Manage Service";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Location = new System.Drawing.Point(317, 22);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(200, 110);
            this.button8.TabIndex = 1;
            this.button8.Text = "Manage Prescriptions";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // PharmasistDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 540);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PharmasistDashboardForm";
            this.Text = "Form7";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PharmasistDashboardForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
    }
}