
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
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portCOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouter_alarme_toolstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouter_config_toolstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.lire_config_toolstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.sauve_config_toolstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seConnecter_toolstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.seDeconnecter_toolstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.afficher_utilisateurs_toolstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.dataSetUtilisateur = new System.Data.DataSet();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUtilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM";
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
            this.iD3ToolStripMenuItem});
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
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portCOMToolStripMenuItem,
            this.ajouter_alarme_toolstrip,
            this.ajouter_config_toolstrip,
            this.lire_config_toolstrip,
            this.sauve_config_toolstrip});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // portCOMToolStripMenuItem
            // 
            this.portCOMToolStripMenuItem.Name = "portCOMToolStripMenuItem";
            this.portCOMToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.portCOMToolStripMenuItem.Text = "Port COM";
            this.portCOMToolStripMenuItem.Click += new System.EventHandler(this.portCOMToolStripMenuItem_Click);
            // 
            // ajouter_alarme_toolstrip
            // 
            this.ajouter_alarme_toolstrip.Name = "ajouter_alarme_toolstrip";
            this.ajouter_alarme_toolstrip.Size = new System.Drawing.Size(233, 22);
            this.ajouter_alarme_toolstrip.Text = "Ajouter Alarme";
            this.ajouter_alarme_toolstrip.Click += new System.EventHandler(this.ajouterAlarmeToolStripMenuItem_Click);
            // 
            // ajouter_config_toolstrip
            // 
            this.ajouter_config_toolstrip.Name = "ajouter_config_toolstrip";
            this.ajouter_config_toolstrip.Size = new System.Drawing.Size(233, 22);
            this.ajouter_config_toolstrip.Text = "Ajouter Intervalle";
            this.ajouter_config_toolstrip.Click += new System.EventHandler(this.sauvegarderConfig);
            // 
            // lire_config_toolstrip
            // 
            this.lire_config_toolstrip.Name = "lire_config_toolstrip";
            this.lire_config_toolstrip.Size = new System.Drawing.Size(233, 22);
            this.lire_config_toolstrip.Text = "Charger Configuration Trames";
            this.lire_config_toolstrip.Click += new System.EventHandler(this.chargerConfig);
            // 
            // sauve_config_toolstrip
            // 
            this.sauve_config_toolstrip.Name = "sauve_config_toolstrip";
            this.sauve_config_toolstrip.Size = new System.Drawing.Size(233, 22);
            this.sauve_config_toolstrip.Text = "Sauvegarder Configuration";
            this.sauve_config_toolstrip.Click += new System.EventHandler(this.sauverConfig_Click);
            // 
            // gestionUtilisateursToolStripMenuItem
            // 
            this.gestionUtilisateursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seConnecter_toolstrip,
            this.seDeconnecter_toolstrip,
            this.afficher_utilisateurs_toolstrip});
            this.gestionUtilisateursToolStripMenuItem.Name = "gestionUtilisateursToolStripMenuItem";
            this.gestionUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.gestionUtilisateursToolStripMenuItem.Text = "Gestion Utilisateurs";
            // 
            // seConnecter_toolstrip
            // 
            this.seConnecter_toolstrip.Name = "seConnecter_toolstrip";
            this.seConnecter_toolstrip.Size = new System.Drawing.Size(194, 22);
            this.seConnecter_toolstrip.Text = "Se connecter";
            this.seConnecter_toolstrip.Click += new System.EventHandler(this.seConnecter);
            // 
            // seDeconnecter_toolstrip
            // 
            this.seDeconnecter_toolstrip.Name = "seDeconnecter_toolstrip";
            this.seDeconnecter_toolstrip.Size = new System.Drawing.Size(194, 22);
            this.seDeconnecter_toolstrip.Text = "Se déconnecter";
            this.seDeconnecter_toolstrip.Click += new System.EventHandler(this.deconnexion);
            // 
            // afficher_utilisateurs_toolstrip
            // 
            this.afficher_utilisateurs_toolstrip.Name = "afficher_utilisateurs_toolstrip";
            this.afficher_utilisateurs_toolstrip.Size = new System.Drawing.Size(194, 22);
            this.afficher_utilisateurs_toolstrip.Text = "Afficher les Utilisateurs";
            this.afficher_utilisateurs_toolstrip.Click += new System.EventHandler(this.afficherUtilisateurs);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // dataSetUtilisateur
            // 
            this.dataSetUtilisateur.DataSetName = "NewDataSet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUtilisateur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lireConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauverConfigToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voirGrid;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lire_config_toolstrip;
        private System.Windows.Forms.ToolStripMenuItem ajouter_config_toolstrip;
        private System.Windows.Forms.ToolStripMenuItem voirGraphiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iD1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iD2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iD3ToolStripMenuItem;
/*        private GraphControl graphControl1;*/
        public System.Windows.Forms.Timer timer;
        private System.Data.DataSet dataSetUtilisateur;
        private System.Windows.Forms.ToolStripMenuItem gestionUtilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficher_utilisateurs_toolstrip;
        private System.Windows.Forms.ToolStripMenuItem seConnecter_toolstrip;
        private System.Windows.Forms.ToolStripMenuItem ajouter_alarme_toolstrip;
        private System.Windows.Forms.ToolStripMenuItem portCOMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seDeconnecter_toolstrip;
        private System.Windows.Forms.ToolStripMenuItem sauve_config_toolstrip;
    }
}

