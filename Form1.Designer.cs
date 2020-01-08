namespace Radio_Simulasyon
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.yem = new System.Windows.Forms.PictureBox();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Bas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yem)).BeginInit();
            this.SuspendLayout();
            // 
            // yem
            // 
            this.yem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.yem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yem.BackgroundImage")));
            this.yem.Location = new System.Drawing.Point(541, 171);
            this.yem.Name = "yem";
            this.yem.Size = new System.Drawing.Size(30, 30);
            this.yem.TabIndex = 1;
            this.yem.TabStop = false;
            // 
            // timer5
            // 
            this.timer5.Interval = 120;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 2;
            // 
            // Bas
            // 
            this.Bas.Enabled = false;
            this.Bas.Location = new System.Drawing.Point(482, 354);
            this.Bas.Name = "Bas";
            this.Bas.Size = new System.Drawing.Size(30, 30);
            this.Bas.TabIndex = 3;
            this.Bas.Text = "B";
            this.Bas.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(827, 589);
            this.Controls.Add(this.Bas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.yem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox yem;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bas;
    }
}

