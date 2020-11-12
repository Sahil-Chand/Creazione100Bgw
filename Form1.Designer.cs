namespace Creazione100Bgw
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAvvio2 = new System.Windows.Forms.Button();
            this.btnStop2 = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btnAvvio100 = new System.Windows.Forms.Button();
            this.btnStop100 = new System.Windows.Forms.Button();
            this.txt100 = new System.Windows.Forms.TextBox();
            this.Bgw = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnAvvio2
            // 
            this.btnAvvio2.Location = new System.Drawing.Point(33, 27);
            this.btnAvvio2.Name = "btnAvvio2";
            this.btnAvvio2.Size = new System.Drawing.Size(75, 23);
            this.btnAvvio2.TabIndex = 0;
            this.btnAvvio2.Text = "Avvia 2";
            this.btnAvvio2.UseVisualStyleBackColor = true;
            this.btnAvvio2.Click += new System.EventHandler(this.btnAvvio2_Click_1);
            // 
            // btnStop2
            // 
            this.btnStop2.Location = new System.Drawing.Point(33, 89);
            this.btnStop2.Name = "btnStop2";
            this.btnStop2.Size = new System.Drawing.Size(75, 23);
            this.btnStop2.TabIndex = 1;
            this.btnStop2.Text = "Stop 2";
            this.btnStop2.UseVisualStyleBackColor = true;
            this.btnStop2.Click += new System.EventHandler(this.btnStop2_Click_1);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(141, 27);
            this.txt2.Multiline = true;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(128, 385);
            this.txt2.TabIndex = 2;
            // 
            // btnAvvio100
            // 
            this.btnAvvio100.Location = new System.Drawing.Point(438, 27);
            this.btnAvvio100.Name = "btnAvvio100";
            this.btnAvvio100.Size = new System.Drawing.Size(89, 23);
            this.btnAvvio100.TabIndex = 3;
            this.btnAvvio100.Text = "Avvio 100";
            this.btnAvvio100.UseVisualStyleBackColor = true;
            this.btnAvvio100.Click += new System.EventHandler(this.btnAvvio100_Click_1);
            // 
            // btnStop100
            // 
            this.btnStop100.Location = new System.Drawing.Point(438, 89);
            this.btnStop100.Name = "btnStop100";
            this.btnStop100.Size = new System.Drawing.Size(89, 23);
            this.btnStop100.TabIndex = 4;
            this.btnStop100.Text = "Stop 100";
            this.btnStop100.UseVisualStyleBackColor = true;
            this.btnStop100.Click += new System.EventHandler(this.btnStop100_Click_1);
            // 
            // txt100
            // 
            this.txt100.Location = new System.Drawing.Point(571, 27);
            this.txt100.Multiline = true;
            this.txt100.Name = "txt100";
            this.txt100.Size = new System.Drawing.Size(128, 385);
            this.txt100.TabIndex = 5;
            // 
            // Bgw
            // 
            this.Bgw.WorkerReportsProgress = true;
            this.Bgw.WorkerSupportsCancellation = true;
            this.Bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Bgw_DoWork_1);
            this.Bgw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Bgw_ProgressChanged_1);
            this.Bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Bgw_RunWorkerCompleted_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt100);
            this.Controls.Add(this.btnStop100);
            this.Controls.Add(this.btnAvvio100);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.btnStop2);
            this.Controls.Add(this.btnAvvio2);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAvvio2;
        private System.Windows.Forms.Button btnStop2;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btnAvvio100;
        private System.Windows.Forms.Button btnStop100;
        private System.Windows.Forms.TextBox txt100;
        private System.ComponentModel.BackgroundWorker Bgw;
    }
}

