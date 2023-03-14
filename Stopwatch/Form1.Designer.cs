namespace Stopwatch
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
            this.lblMin = new System.Windows.Forms.Label();
            this.lbls = new System.Windows.Forms.Label();
            this.lblCs = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Button();
            this.lblstart = new System.Windows.Forms.Button();
            this.lblstop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(197, 118);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(64, 46);
            this.lblMin.TabIndex = 0;
            this.lblMin.Text = "00";
            // 
            // lbls
            // 
            this.lbls.AutoSize = true;
            this.lbls.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbls.Location = new System.Drawing.Point(341, 118);
            this.lbls.Name = "lbls";
            this.lbls.Size = new System.Drawing.Size(64, 46);
            this.lbls.TabIndex = 1;
            this.lbls.Text = "00";
            // 
            // lblCs
            // 
            this.lblCs.AutoSize = true;
            this.lblCs.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCs.Location = new System.Drawing.Point(493, 118);
            this.lblCs.Name = "lblCs";
            this.lblCs.Size = new System.Drawing.Size(64, 46);
            this.lblCs.TabIndex = 2;
            this.lblCs.Text = "00";
            // 
            // lblR
            // 
            this.lblR.Location = new System.Drawing.Point(501, 258);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(75, 23);
            this.lblR.TabIndex = 3;
            this.lblR.Text = "Reset";
            this.lblR.UseVisualStyleBackColor = true;
            this.lblR.Click += new System.EventHandler(this.lblR_Click);
            // 
            // lblstart
            // 
            this.lblstart.Location = new System.Drawing.Point(205, 258);
            this.lblstart.Name = "lblstart";
            this.lblstart.Size = new System.Drawing.Size(75, 23);
            this.lblstart.TabIndex = 4;
            this.lblstart.Text = "Start";
            this.lblstart.UseVisualStyleBackColor = true;
            this.lblstart.Click += new System.EventHandler(this.lblstart_Click);
            // 
            // lblstop
            // 
            this.lblstop.Location = new System.Drawing.Point(349, 258);
            this.lblstop.Name = "lblstop";
            this.lblstop.Size = new System.Drawing.Size(75, 23);
            this.lblstop.TabIndex = 5;
            this.lblstop.Text = "Stop";
            this.lblstop.UseVisualStyleBackColor = true;
            this.lblstop.Click += new System.EventHandler(this.lblstop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(435, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 46);
            this.label2.TabIndex = 7;
            this.label2.Text = ".";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblstop);
            this.Controls.Add(this.lblstart);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblCs);
            this.Controls.Add(this.lbls);
            this.Controls.Add(this.lblMin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lbls;
        private System.Windows.Forms.Label lblCs;
        private System.Windows.Forms.Button lblR;
        private System.Windows.Forms.Button lblstart;
        private System.Windows.Forms.Button lblstop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

