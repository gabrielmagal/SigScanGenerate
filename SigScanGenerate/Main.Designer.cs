namespace SigScanGenerate
{
    partial class Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txbAob = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExportSig = new System.Windows.Forms.Button();
            this.btnCopyMask = new System.Windows.Forms.Button();
            this.txbMask = new System.Windows.Forms.TextBox();
            this.btnCopyPattern = new System.Windows.Forms.Button();
            this.txbPattern = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.txbAob);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aob";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(144, 39);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(113, 22);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txbAob
            // 
            this.txbAob.Location = new System.Drawing.Point(7, 16);
            this.txbAob.Name = "txbAob";
            this.txbAob.Size = new System.Drawing.Size(389, 20);
            this.txbAob.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExportSig);
            this.groupBox2.Controls.Add(this.btnCopyMask);
            this.groupBox2.Controls.Add(this.txbMask);
            this.groupBox2.Controls.Add(this.btnCopyPattern);
            this.groupBox2.Controls.Add(this.txbPattern);
            this.groupBox2.Location = new System.Drawing.Point(9, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 92);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generated";
            // 
            // btnExportSig
            // 
            this.btnExportSig.Location = new System.Drawing.Point(145, 66);
            this.btnExportSig.Name = "btnExportSig";
            this.btnExportSig.Size = new System.Drawing.Size(113, 22);
            this.btnExportSig.TabIndex = 4;
            this.btnExportSig.Text = "Copy to C++";
            this.btnExportSig.UseVisualStyleBackColor = true;
            this.btnExportSig.Click += new System.EventHandler(this.btnExportSig_Click);
            // 
            // btnCopyMask
            // 
            this.btnCopyMask.Location = new System.Drawing.Point(361, 39);
            this.btnCopyMask.Name = "btnCopyMask";
            this.btnCopyMask.Size = new System.Drawing.Size(41, 22);
            this.btnCopyMask.TabIndex = 3;
            this.btnCopyMask.Text = "copy";
            this.btnCopyMask.UseVisualStyleBackColor = true;
            this.btnCopyMask.Click += new System.EventHandler(this.btnCopyMask_Click);
            // 
            // txbMask
            // 
            this.txbMask.Enabled = false;
            this.txbMask.Location = new System.Drawing.Point(7, 40);
            this.txbMask.Name = "txbMask";
            this.txbMask.Size = new System.Drawing.Size(354, 20);
            this.txbMask.TabIndex = 2;
            // 
            // btnCopyPattern
            // 
            this.btnCopyPattern.Location = new System.Drawing.Point(361, 15);
            this.btnCopyPattern.Name = "btnCopyPattern";
            this.btnCopyPattern.Size = new System.Drawing.Size(41, 22);
            this.btnCopyPattern.TabIndex = 1;
            this.btnCopyPattern.Text = "copy";
            this.btnCopyPattern.UseVisualStyleBackColor = true;
            this.btnCopyPattern.Click += new System.EventHandler(this.btnCopyPattern_Click);
            // 
            // txbPattern
            // 
            this.txbPattern.Enabled = false;
            this.txbPattern.Location = new System.Drawing.Point(7, 16);
            this.txbPattern.Name = "txbPattern";
            this.txbPattern.Size = new System.Drawing.Size(354, 20);
            this.txbPattern.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "developed by 3ncryptorx";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(421, 203);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SigScanGenerate";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbAob;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCopyPattern;
        private System.Windows.Forms.TextBox txbPattern;
        private System.Windows.Forms.Button btnExportSig;
        private System.Windows.Forms.Button btnCopyMask;
        private System.Windows.Forms.TextBox txbMask;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label1;
    }
}

