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
            this.lblPath = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblXampp = new System.Windows.Forms.Label();
            this.edtProject = new System.Windows.Forms.TextBox();
            this.edtXampp = new System.Windows.Forms.TextBox();
            this.btnCarica = new System.Windows.Forms.Button();
            this.btnNuovo = new System.Windows.Forms.Button();
            this.grbServer = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNuovo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApri = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAvvia = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChiudi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEsci = new System.Windows.Forms.ToolStripMenuItem();
            this.grbConfigurazione.SuspendLayout();
            this.grbServer.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbConfigurazione
            // 
            this.grbConfigurazione.Controls.Add(this.lblPath);
            this.grbConfigurazione.Controls.Add(this.lblProject);
            this.grbConfigurazione.Controls.Add(this.lblXampp);
            this.grbConfigurazione.Controls.Add(this.edtProject);
            this.grbConfigurazione.Controls.Add(this.edtXampp);
            this.grbConfigurazione.Controls.Add(this.btnCarica);
            this.grbConfigurazione.Controls.Add(this.btnNuovo);
            this.grbConfigurazione.Location = new System.Drawing.Point(12, 27);
            this.grbConfigurazione.Name = "grbConfigurazione";
            this.grbConfigurazione.Size = new System.Drawing.Size(312, 133);
            this.grbConfigurazione.TabIndex = 0;
            this.grbConfigurazione.TabStop = false;
            this.grbConfigurazione.Text = "Configurazione";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPath.Location = new System.Drawing.Point(7, 114);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(0, 13);
            this.lblPath.TabIndex = 8;
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
            this.edtProject.Size = new System.Drawing.Size(228, 20);
            this.edtProject.TabIndex = 5;
            this.edtProject.Click += new System.EventHandler(this.edtProject_Click);
            // 
            // edtXampp
            // 
            this.edtXampp.Location = new System.Drawing.Point(78, 32);
            this.edtXampp.Name = "edtXampp";
            this.edtXampp.Size = new System.Drawing.Size(228, 20);
            this.edtXampp.TabIndex = 4;
            this.edtXampp.Click += new System.EventHandler(this.edtXampp_Click);
            // 
            // btnCarica
            // 
            this.btnCarica.Location = new System.Drawing.Point(190, 84);
            this.btnCarica.Name = "btnCarica";
            this.btnCarica.Size = new System.Drawing.Size(116, 23);
            this.btnCarica.TabIndex = 3;
            this.btnCarica.Text = "Apri configurazione";
            this.btnCarica.UseVisualStyleBackColor = true;
            this.btnCarica.Click += new System.EventHandler(this.btnCarica_Click);
            // 
            // btnNuovo
            // 
            this.btnNuovo.Location = new System.Drawing.Point(78, 84);
            this.btnNuovo.Name = "btnNuovo";
            this.btnNuovo.Size = new System.Drawing.Size(110, 23);
            this.btnNuovo.TabIndex = 0;
            this.btnNuovo.Text = "Crea configurazione";
            this.btnNuovo.UseVisualStyleBackColor = true;
            this.btnNuovo.Click += new System.EventHandler(this.btnNuovo_Click);
            // 
            // grbServer
            // 
            this.grbServer.Controls.Add(this.btnClose);
            this.grbServer.Controls.Add(this.btnOpen);
            this.grbServer.Location = new System.Drawing.Point(12, 166);
            this.grbServer.Name = "grbServer";
            this.grbServer.Size = new System.Drawing.Size(312, 50);
            this.grbServer.TabIndex = 1;
            this.grbServer.TabStop = false;
            this.grbServer.Text = "Server";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(194, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Chiudi progetto";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(78, 20);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(110, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Apri progetto";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuServer,
            this.menuHelp});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(336, 24);
            this.menu.TabIndex = 2;
            this.menu.Text = "menu";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNuovo,
            this.menuApri,
            this.menuEsci});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuInfo});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(24, 20);
            this.menuHelp.Text = "?";
            // 
            // menuNuovo
            // 
            this.menuNuovo.Name = "menuNuovo";
            this.menuNuovo.Size = new System.Drawing.Size(152, 22);
            this.menuNuovo.Text = "Nuovo";
            this.menuNuovo.Click += new System.EventHandler(this.menuNuovo_Click);
            // 
            // menuApri
            // 
            this.menuApri.Name = "menuApri";
            this.menuApri.Size = new System.Drawing.Size(152, 22);
            this.menuApri.Text = "Apri";
            this.menuApri.Click += new System.EventHandler(this.menuApri_Click);
            // 
            // menuInfo
            // 
            this.menuInfo.Name = "menuInfo";
            this.menuInfo.Size = new System.Drawing.Size(152, 22);
            this.menuInfo.Text = "Info";
            this.menuInfo.Click += new System.EventHandler(this.menuInfo_Click);
            // 
            // menuServer
            // 
            this.menuServer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAvvia,
            this.menuChiudi});
            this.menuServer.Name = "menuServer";
            this.menuServer.Size = new System.Drawing.Size(51, 20);
            this.menuServer.Text = "Server";
            // 
            // menuAvvia
            // 
            this.menuAvvia.Name = "menuAvvia";
            this.menuAvvia.Size = new System.Drawing.Size(152, 22);
            this.menuAvvia.Text = "Avvia";
            this.menuAvvia.Click += new System.EventHandler(this.menuAvvia_Click);
            // 
            // menuChiudi
            // 
            this.menuChiudi.Name = "menuChiudi";
            this.menuChiudi.Size = new System.Drawing.Size(152, 22);
            this.menuChiudi.Text = "Chiudi";
            this.menuChiudi.Click += new System.EventHandler(this.menuChiudi_Click);
            // 
            // menuEsci
            // 
            this.menuEsci.Name = "menuEsci";
            this.menuEsci.Size = new System.Drawing.Size(152, 22);
            this.menuEsci.Text = "Esci";
            this.menuEsci.Click += new System.EventHandler(this.menuEsci_Click);
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 221);
            this.Controls.Add(this.grbServer);
            this.Controls.Add(this.grbConfigurazione);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmServer";
            this.ShowIcon = false;
            this.Text = "Xampp Server";
            this.Load += new System.EventHandler(this.frmServer_Load);
            this.grbConfigurazione.ResumeLayout(false);
            this.grbConfigurazione.PerformLayout();
            this.grbServer.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuNuovo;
        private System.Windows.Forms.ToolStripMenuItem menuApri;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuInfo;
        private System.Windows.Forms.ToolStripMenuItem menuEsci;
        private System.Windows.Forms.ToolStripMenuItem menuServer;
        private System.Windows.Forms.ToolStripMenuItem menuAvvia;
        private System.Windows.Forms.ToolStripMenuItem menuChiudi;
    }
}

