namespace XamppServer
{
    partial class frmServer
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
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
            this.grbConfigurazione = new System.Windows.Forms.GroupBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblXampp = new System.Windows.Forms.Label();
            this.edtProject = new System.Windows.Forms.TextBox();
            this.edtXampp = new System.Windows.Forms.TextBox();
            this.btnCarica = new System.Windows.Forms.Button();
            this.btnNuovo = new System.Windows.Forms.Button();
            this.grbServer = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.grbConfigurazione.SuspendLayout();
            this.grbServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbConfigurazione
            // 
            this.grbConfigurazione.Controls.Add(this.lblProject);
            this.grbConfigurazione.Controls.Add(this.lblXampp);
            this.grbConfigurazione.Controls.Add(this.edtProject);
            this.grbConfigurazione.Controls.Add(this.edtXampp);
            this.grbConfigurazione.Controls.Add(this.btnCarica);
            this.grbConfigurazione.Controls.Add(this.btnNuovo);
            this.grbConfigurazione.Location = new System.Drawing.Point(12, 12);
            this.grbConfigurazione.Name = "grbConfigurazione";
            this.grbConfigurazione.Size = new System.Drawing.Size(282, 119);
            this.grbConfigurazione.TabIndex = 0;
            this.grbConfigurazione.TabStop = false;
            this.grbConfigurazione.Text = "Configurazione";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(7, 61);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(47, 13);
            this.lblProject.TabIndex = 7;
            this.lblProject.Text = "Progetto";
            // 
            // lblXampp
            // 
            this.lblXampp.AutoSize = true;
            this.lblXampp.Location = new System.Drawing.Point(7, 32);
            this.lblXampp.Name = "lblXampp";
            this.lblXampp.Size = new System.Drawing.Size(40, 13);
            this.lblXampp.TabIndex = 6;
            this.lblXampp.Text = "Xampp";
            // 
            // edtProject
            // 
            this.edtProject.Location = new System.Drawing.Point(78, 58);
            this.edtProject.Name = "edtProject";
            this.edtProject.Size = new System.Drawing.Size(198, 20);
            this.edtProject.TabIndex = 5;
            this.edtProject.Click += new System.EventHandler(this.edtProject_Click);
            this.edtProject.TextChanged += new System.EventHandler(this.edtProject_TextChanged);
            // 
            // edtXampp
            // 
            this.edtXampp.Location = new System.Drawing.Point(78, 32);
            this.edtXampp.Name = "edtXampp";
            this.edtXampp.Size = new System.Drawing.Size(198, 20);
            this.edtXampp.TabIndex = 4;
            this.edtXampp.Click += new System.EventHandler(this.edtXampp_Click);
            // 
            // btnCarica
            // 
            this.btnCarica.Location = new System.Drawing.Point(180, 84);
            this.btnCarica.Name = "btnCarica";
            this.btnCarica.Size = new System.Drawing.Size(96, 23);
            this.btnCarica.TabIndex = 3;
            this.btnCarica.Text = "Carica";
            this.btnCarica.UseVisualStyleBackColor = true;
            this.btnCarica.Click += new System.EventHandler(this.btnCarica_Click);
            // 
            // btnNuovo
            // 
            this.btnNuovo.Location = new System.Drawing.Point(78, 84);
            this.btnNuovo.Name = "btnNuovo";
            this.btnNuovo.Size = new System.Drawing.Size(96, 23);
            this.btnNuovo.TabIndex = 0;
            this.btnNuovo.Text = "Nuovo";
            this.btnNuovo.UseVisualStyleBackColor = true;
            this.btnNuovo.Click += new System.EventHandler(this.btnNuovo_Click);
            // 
            // grbServer
            // 
            this.grbServer.Controls.Add(this.btnClose);
            this.grbServer.Controls.Add(this.btnOpen);
            this.grbServer.Location = new System.Drawing.Point(12, 137);
            this.grbServer.Name = "grbServer";
            this.grbServer.Size = new System.Drawing.Size(282, 79);
            this.grbServer.TabIndex = 1;
            this.grbServer.TabStop = false;
            this.grbServer.Text = "Server";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(78, 49);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(198, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Chiudi";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(78, 20);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(198, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Apri progetto";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 225);
            this.Controls.Add(this.grbServer);
            this.Controls.Add(this.grbConfigurazione);
            this.Name = "frmServer";
            this.Text = "Xampp Server";
            this.Load += new System.EventHandler(this.frmServer_Load);
            this.grbConfigurazione.ResumeLayout(false);
            this.grbConfigurazione.PerformLayout();
            this.grbServer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbConfigurazione;
        private System.Windows.Forms.GroupBox grbServer;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblXampp;
        private System.Windows.Forms.TextBox edtProject;
        private System.Windows.Forms.TextBox edtXampp;
        private System.Windows.Forms.Button btnCarica;
        private System.Windows.Forms.Button btnNuovo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
    }
}

