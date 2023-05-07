namespace KHP_PowerWatch
{
    partial class Database_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Database_Management));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DMbtn = new System.Windows.Forms.Button();
            this.PGbtn = new System.Windows.Forms.Button();
            this.CAbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.RMbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.DMbtn);
            this.groupBox1.Controls.Add(this.PGbtn);
            this.groupBox1.Controls.Add(this.CAbtn);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.Logoutbtn);
            this.groupBox1.Controls.Add(this.RMbtn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 524);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // DMbtn
            // 
            this.DMbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DMbtn.ForeColor = System.Drawing.Color.Goldenrod;
            this.DMbtn.Location = new System.Drawing.Point(54, 412);
            this.DMbtn.Name = "DMbtn";
            this.DMbtn.Size = new System.Drawing.Size(99, 40);
            this.DMbtn.TabIndex = 8;
            this.DMbtn.Text = "Database Management";
            this.DMbtn.UseVisualStyleBackColor = true;
            this.DMbtn.Click += new System.EventHandler(this.DMbtn_Click_1);
            // 
            // PGbtn
            // 
            this.PGbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PGbtn.ForeColor = System.Drawing.Color.Goldenrod;
            this.PGbtn.Location = new System.Drawing.Point(54, 334);
            this.PGbtn.Name = "PGbtn";
            this.PGbtn.Size = new System.Drawing.Size(99, 40);
            this.PGbtn.TabIndex = 7;
            this.PGbtn.Text = "PowerGrid Simulator";
            this.PGbtn.UseVisualStyleBackColor = true;
            this.PGbtn.Click += new System.EventHandler(this.PGbtn_Click_1);
            // 
            // CAbtn
            // 
            this.CAbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAbtn.ForeColor = System.Drawing.Color.Goldenrod;
            this.CAbtn.Location = new System.Drawing.Point(54, 259);
            this.CAbtn.Name = "CAbtn";
            this.CAbtn.Size = new System.Drawing.Size(99, 40);
            this.CAbtn.TabIndex = 6;
            this.CAbtn.Text = "Consumption Analysis";
            this.CAbtn.UseVisualStyleBackColor = true;
            this.CAbtn.Click += new System.EventHandler(this.CAbtn_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 141);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutbtn.ForeColor = System.Drawing.Color.Goldenrod;
            this.Logoutbtn.Location = new System.Drawing.Point(65, 508);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(75, 23);
            this.Logoutbtn.TabIndex = 4;
            this.Logoutbtn.Text = "Log Out";
            this.Logoutbtn.UseVisualStyleBackColor = true;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click_1);
            // 
            // RMbtn
            // 
            this.RMbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RMbtn.ForeColor = System.Drawing.Color.Goldenrod;
            this.RMbtn.Location = new System.Drawing.Point(54, 196);
            this.RMbtn.Name = "RMbtn";
            this.RMbtn.Size = new System.Drawing.Size(99, 40);
            this.RMbtn.TabIndex = 0;
            this.RMbtn.Text = "Realtime Monitoring";
            this.RMbtn.UseVisualStyleBackColor = true;
            this.RMbtn.Click += new System.EventHandler(this.RMbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(212, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1158, 66);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1115, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(552, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Database Management";
            // 
            // Database_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1370, 524);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Database_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database_Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DMbtn;
        private System.Windows.Forms.Button PGbtn;
        private System.Windows.Forms.Button CAbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.Button RMbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}