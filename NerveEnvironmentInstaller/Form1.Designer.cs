namespace NerveEnvironmentInstaller
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonStartInstall = new System.Windows.Forms.Button();
            this.labelProgress = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCanel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instalacjia środowiska";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.Location = new System.Drawing.Point(20, 71);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(454, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // buttonStartInstall
            // 
            this.buttonStartInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartInstall.Location = new System.Drawing.Point(148, 158);
            this.buttonStartInstall.Name = "buttonStartInstall";
            this.buttonStartInstall.Size = new System.Drawing.Size(186, 29);
            this.buttonStartInstall.TabIndex = 2;
            this.buttonStartInstall.Text = "Rozpocznij instalacjie";
            this.buttonStartInstall.UseVisualStyleBackColor = true;
            this.buttonStartInstall.Click += new System.EventHandler(this.buttonStartInstall_Click);
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(20, 107);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(10, 15);
            this.labelProgress.TabIndex = 3;
            this.labelProgress.Text = ".";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.buttonCanel);
            this.panel1.Controls.Add(this.buttonStartInstall);
            this.panel1.Controls.Add(this.labelProgress);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(494, 321);
            this.panel1.TabIndex = 4;
            // 
            // buttonCanel
            // 
            this.buttonCanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCanel.Location = new System.Drawing.Point(148, 202);
            this.buttonCanel.Name = "buttonCanel";
            this.buttonCanel.Size = new System.Drawing.Size(186, 29);
            this.buttonCanel.TabIndex = 4;
            this.buttonCanel.Text = "Anuluj";
            this.buttonCanel.UseVisualStyleBackColor = true;
            this.buttonCanel.Visible = false;
            this.buttonCanel.Click += new System.EventHandler(this.buttonCanel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "NerveEnvironmentInstaller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private ProgressBar progressBar1;
        private Button buttonStartInstall;
        private Label labelProgress;
        private Panel panel1;
        private Button buttonCanel;
    }
}