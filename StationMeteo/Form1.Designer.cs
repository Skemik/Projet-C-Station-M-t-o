
namespace StationMeteo
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.grid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lireConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauverConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voirGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.voirGraphiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iD1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iD2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iD3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iD4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iD5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherLesUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seConnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.grid_userTable = new System.Windows.Forms.DataGridView();
            this.grid_accessTable = new System.Windows.Forms.DataGridView();
            this.dataSetUtilisateur = new System.Data.DataSet();
            this.userControl_newuser = new StationMeteo.Utilisateur.UserControl_NouveauUtilisateur();
            this.userControl_Connexion = new StationMeteo.Utilisateur.UserControl_Connexion();
            this.graphControl1 = new StationMeteo.GraphControl();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_userTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_accessTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUtilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM3";
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToOrderColumns = true;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.ColumnHeadersVisible = false;
            this.grid.Location = new System.Drawing.Point(12, 61);
            this.grid.Name = "grid";
            this.grid.RowHeadersVisible = false;
            this.grid.Size = new System.Drawing.Size(677, 153);
            this.grid.TabIndex = 0;
            this.grid.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lireConfigToolStripMenuItem,
            this.sauverConfigToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // lireConfigToolStripMenuItem
            // 
            this.lireConfigToolStripMenuItem.Name = "lireConfigToolStripMenuItem";
            this.lireConfigToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            // 
            // sauverConfigToolStripMenuItem
            // 
            this.sauverConfigToolStripMenuItem.Name = "sauverConfigToolStripMenuItem";
            this.sauverConfigToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.sauverConfigToolStripMenuItem.Text = "Sauver config";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voirGrid,
            this.voirGraphiqueToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.gestionUtilisateursToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voirGrid
            // 
            this.voirGrid.Name = "voirGrid";
            this.voirGrid.Size = new System.Drawing.Size(64, 20);
            this.voirGrid.Text = "Voir Grid";
            this.voirGrid.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // voirGraphiqueToolStripMenuItem
            // 
            this.voirGraphiqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iD1ToolStripMenuItem,
            this.iD2ToolStripMenuItem,
            this.iD3ToolStripMenuItem,
            this.iD4ToolStripMenuItem,
            this.iD5ToolStripMenuItem});
            this.voirGraphiqueToolStripMenuItem.Name = "voirGraphiqueToolStripMenuItem";
            this.voirGraphiqueToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.voirGraphiqueToolStripMenuItem.Text = "Voir Graphique";
            // 
            // iD1ToolStripMenuItem
            // 
            this.iD1ToolStripMenuItem.Name = "iD1ToolStripMenuItem";
            this.iD1ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.iD1ToolStripMenuItem.Text = "ID 1";
            this.iD1ToolStripMenuItem.Click += new System.EventHandler(this.afficherGraphiqueID1);
            // 
            // iD2ToolStripMenuItem
            // 
            this.iD2ToolStripMenuItem.Name = "iD2ToolStripMenuItem";
            this.iD2ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.iD2ToolStripMenuItem.Text = "ID 2";
            this.iD2ToolStripMenuItem.Click += new System.EventHandler(this.afficherGraphiqueID2);
            // 
            // iD3ToolStripMenuItem
            // 
            this.iD3ToolStripMenuItem.Name = "iD3ToolStripMenuItem";
            this.iD3ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.iD3ToolStripMenuItem.Text = "ID 3";
            this.iD3ToolStripMenuItem.Click += new System.EventHandler(this.afficherGraphiqueID3);
            // 
            // iD4ToolStripMenuItem
            // 
            this.iD4ToolStripMenuItem.Name = "iD4ToolStripMenuItem";
            this.iD4ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.iD4ToolStripMenuItem.Text = "ID 4";
            this.iD4ToolStripMenuItem.Click += new System.EventHandler(this.afficherGraphiqueID4);
            // 
            // iD5ToolStripMenuItem
            // 
            this.iD5ToolStripMenuItem.Name = "iD5ToolStripMenuItem";
            this.iD5ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.iD5ToolStripMenuItem.Text = "ID 5";
            this.iD5ToolStripMenuItem.Click += new System.EventHandler(this.afficherGraphiqueID5);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.sauvegarderConfigurationToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(216, 22);
            this.toolStripMenuItem3.Text = "Lire Configuration";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.chargerConfig);
            // 
            // sauvegarderConfigurationToolStripMenuItem
            // 
            this.sauvegarderConfigurationToolStripMenuItem.Name = "sauvegarderConfigurationToolStripMenuItem";
            this.sauvegarderConfigurationToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.sauvegarderConfigurationToolStripMenuItem.Text = "Sauvegarder Configuration";
            this.sauvegarderConfigurationToolStripMenuItem.Click += new System.EventHandler(this.sauvegarderConfig);
            // 
            // gestionUtilisateursToolStripMenuItem
            // 
            this.gestionUtilisateursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherLesUtilisateursToolStripMenuItem,
            this.seConnecterToolStripMenuItem,
            this.ajouterUnUtilisateurToolStripMenuItem});
            this.gestionUtilisateursToolStripMenuItem.Name = "gestionUtilisateursToolStripMenuItem";
            this.gestionUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.gestionUtilisateursToolStripMenuItem.Text = "Gestion Utilisateurs";
            // 
            // afficherLesUtilisateursToolStripMenuItem
            // 
            this.afficherLesUtilisateursToolStripMenuItem.Name = "afficherLesUtilisateursToolStripMenuItem";
            this.afficherLesUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.afficherLesUtilisateursToolStripMenuItem.Text = "Afficher les Utilisateurs";
            this.afficherLesUtilisateursToolStripMenuItem.Click += new System.EventHandler(this.afficherUtilisateurs);
            // 
            // seConnecterToolStripMenuItem
            // 
            this.seConnecterToolStripMenuItem.Name = "seConnecterToolStripMenuItem";
            this.seConnecterToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.seConnecterToolStripMenuItem.Text = "Se connecter";
            this.seConnecterToolStripMenuItem.Click += new System.EventHandler(this.seConnecter);
            // 
            // ajouterUnUtilisateurToolStripMenuItem
            // 
            this.ajouterUnUtilisateurToolStripMenuItem.Name = "ajouterUnUtilisateurToolStripMenuItem";
            this.ajouterUnUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.ajouterUnUtilisateurToolStripMenuItem.Text = "Ajouter un Utilisateur";
            this.ajouterUnUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.afficherAjouterUnUtilisateurClick);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // grid_userTable
            // 
            this.grid_userTable.AllowUserToAddRows = false;
            this.grid_userTable.AllowUserToDeleteRows = false;
            this.grid_userTable.AllowUserToOrderColumns = true;
            this.grid_userTable.AllowUserToResizeColumns = false;
            this.grid_userTable.AllowUserToResizeRows = false;
            this.grid_userTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_userTable.Location = new System.Drawing.Point(12, 48);
            this.grid_userTable.Name = "grid_userTable";
            this.grid_userTable.ReadOnly = true;
            this.grid_userTable.RowHeadersVisible = false;
            this.grid_userTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grid_userTable.Size = new System.Drawing.Size(538, 193);
            this.grid_userTable.TabIndex = 12;
            this.grid_userTable.Visible = false;
            // 
            // grid_accessTable
            // 
            this.grid_accessTable.AllowUserToAddRows = false;
            this.grid_accessTable.AllowUserToDeleteRows = false;
            this.grid_accessTable.AllowUserToOrderColumns = true;
            this.grid_accessTable.AllowUserToResizeColumns = false;
            this.grid_accessTable.AllowUserToResizeRows = false;
            this.grid_accessTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_accessTable.Location = new System.Drawing.Point(12, 247);
            this.grid_accessTable.Name = "grid_accessTable";
            this.grid_accessTable.RowHeadersVisible = false;
            this.grid_accessTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grid_accessTable.Size = new System.Drawing.Size(538, 191);
            this.grid_accessTable.TabIndex = 13;
            this.grid_accessTable.Visible = false;
            // 
            // dataSetUtilisateur
            // 
            this.dataSetUtilisateur.DataSetName = "NewDataSet";
            // 
            // userControl_newuser
            // 
            this.userControl_newuser.Location = new System.Drawing.Point(12, 33);
            this.userControl_newuser.Name = "userControl_newuser";
            this.userControl_newuser.Size = new System.Drawing.Size(294, 299);
            this.userControl_newuser.TabIndex = 15;
            this.userControl_newuser.Visible = false;
            // 
            // userControl_Connexion
            // 
            this.userControl_Connexion.Location = new System.Drawing.Point(12, 27);
            this.userControl_Connexion.Name = "userControl_Connexion";
            this.userControl_Connexion.Size = new System.Drawing.Size(364, 367);
            this.userControl_Connexion.TabIndex = 14;
            this.userControl_Connexion.Visible = false;
            // 
            // graphControl1
            // 
            this.graphControl1.Location = new System.Drawing.Point(12, 33);
            this.graphControl1.Name = "graphControl1";
            this.graphControl1.Size = new System.Drawing.Size(432, 405);
            this.graphControl1.TabIndex = 11;
            this.graphControl1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl_newuser);
            this.Controls.Add(this.userControl_Connexion);
            this.Controls.Add(this.grid_accessTable);
            this.Controls.Add(this.grid_userTable);
            this.Controls.Add(this.graphControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grid);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_userTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_accessTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUtilisateur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lireConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauverConfigToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voirGrid;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirGraphiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iD1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iD2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iD3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iD4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iD5ToolStripMenuItem;
        private GraphControl graphControl1;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataGridView grid_userTable;
        private System.Windows.Forms.DataGridView grid_accessTable;
        private System.Data.DataSet dataSetUtilisateur;
        private System.Windows.Forms.ToolStripMenuItem gestionUtilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherLesUtilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seConnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnUtilisateurToolStripMenuItem;
        private Utilisateur.UserControl_NouveauUtilisateur userControl_newuser;
        private Utilisateur.UserControl_Connexion userControl_Connexion;
    }
}

