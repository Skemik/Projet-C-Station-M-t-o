﻿
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
            this.timerRead = new System.Windows.Forms.Timer(this.components);
            this.grid = new System.Windows.Forms.DataGridView();
            this.validerConfig = new System.Windows.Forms.Button();
            this.idConfig = new System.Windows.Forms.TextBox();
            this.intervMaxConfig = new System.Windows.Forms.TextBox();
            this.intervMinConfig = new System.Windows.Forms.TextBox();
            this.labelConfig2 = new System.Windows.Forms.Label();
            this.labelConfig3 = new System.Windows.Forms.Label();
            this.labelConfig4 = new System.Windows.Forms.Label();
            this.labelConfig1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lireConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauverConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addConfig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM3";
            // 
            // timerRead
            // 
            this.timerRead.Enabled = true;
            this.timerRead.Interval = 500;
            this.timerRead.Tick += new System.EventHandler(this.timerRead_Tick);
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
            this.grid.Location = new System.Drawing.Point(12, 45);
            this.grid.Name = "grid";
            this.grid.RowHeadersVisible = false;
            this.grid.Size = new System.Drawing.Size(683, 375);
            this.grid.TabIndex = 0;
            // 
            // validerConfig
            // 
            this.validerConfig.Location = new System.Drawing.Point(22, 261);
            this.validerConfig.Name = "validerConfig";
            this.validerConfig.Size = new System.Drawing.Size(189, 23);
            this.validerConfig.TabIndex = 2;
            this.validerConfig.Text = "Sauvegarder Configuration";
            this.validerConfig.UseVisualStyleBackColor = true;
            this.validerConfig.Visible = false;
            this.validerConfig.Click += new System.EventHandler(this.validerConfig_Click);
            // 
            // idConfig
            // 
            this.idConfig.Location = new System.Drawing.Point(111, 72);
            this.idConfig.Name = "idConfig";
            this.idConfig.Size = new System.Drawing.Size(100, 20);
            this.idConfig.TabIndex = 3;
            this.idConfig.Visible = false;
            // 
            // intervMaxConfig
            // 
            this.intervMaxConfig.Location = new System.Drawing.Point(111, 133);
            this.intervMaxConfig.Name = "intervMaxConfig";
            this.intervMaxConfig.Size = new System.Drawing.Size(100, 20);
            this.intervMaxConfig.TabIndex = 4;
            this.intervMaxConfig.Visible = false;
            // 
            // intervMinConfig
            // 
            this.intervMinConfig.Location = new System.Drawing.Point(111, 102);
            this.intervMinConfig.Name = "intervMinConfig";
            this.intervMinConfig.Size = new System.Drawing.Size(100, 20);
            this.intervMinConfig.TabIndex = 4;
            this.intervMinConfig.Visible = false;
            // 
            // labelConfig2
            // 
            this.labelConfig2.AutoSize = true;
            this.labelConfig2.Location = new System.Drawing.Point(19, 75);
            this.labelConfig2.Name = "labelConfig2";
            this.labelConfig2.Size = new System.Drawing.Size(18, 13);
            this.labelConfig2.TabIndex = 5;
            this.labelConfig2.Text = "ID";
            this.labelConfig2.Visible = false;
            // 
            // labelConfig3
            // 
            this.labelConfig3.AutoSize = true;
            this.labelConfig3.Location = new System.Drawing.Point(19, 105);
            this.labelConfig3.Name = "labelConfig3";
            this.labelConfig3.Size = new System.Drawing.Size(70, 13);
            this.labelConfig3.TabIndex = 6;
            this.labelConfig3.Text = "Intervalle Min";
            this.labelConfig3.Visible = false;
            // 
            // labelConfig4
            // 
            this.labelConfig4.AutoSize = true;
            this.labelConfig4.Location = new System.Drawing.Point(19, 136);
            this.labelConfig4.Name = "labelConfig4";
            this.labelConfig4.Size = new System.Drawing.Size(73, 13);
            this.labelConfig4.TabIndex = 7;
            this.labelConfig4.Text = "Intervalle Max";
            this.labelConfig4.Visible = false;
            // 
            // labelConfig1
            // 
            this.labelConfig1.AutoSize = true;
            this.labelConfig1.Location = new System.Drawing.Point(65, 45);
            this.labelConfig1.Name = "labelConfig1";
            this.labelConfig1.Size = new System.Drawing.Size(101, 13);
            this.labelConfig1.TabIndex = 8;
            this.labelConfig1.Text = "Configurer Intervalle";
            this.labelConfig1.Visible = false;
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
            this.toolStripMenuItem2,
            this.configurationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(64, 20);
            this.toolStripMenuItem2.Text = "Voir Grid";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
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
            // addConfig
            // 
            this.addConfig.Location = new System.Drawing.Point(52, 175);
            this.addConfig.Name = "addConfig";
            this.addConfig.Size = new System.Drawing.Size(114, 23);
            this.addConfig.TabIndex = 10;
            this.addConfig.Text = "Ajouter Configuration";
            this.addConfig.UseVisualStyleBackColor = true;
            this.addConfig.Visible = false;
            this.addConfig.Click += new System.EventHandler(this.addConfig_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addConfig);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelConfig1);
            this.Controls.Add(this.labelConfig4);
            this.Controls.Add(this.labelConfig3);
            this.Controls.Add(this.labelConfig2);
            this.Controls.Add(this.intervMinConfig);
            this.Controls.Add(this.intervMaxConfig);
            this.Controls.Add(this.idConfig);
            this.Controls.Add(this.validerConfig);
            this.Controls.Add(this.grid);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Timer timerRead;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button validerConfig;
        private System.Windows.Forms.TextBox idConfig;
        private System.Windows.Forms.TextBox intervMaxConfig;
        private System.Windows.Forms.TextBox intervMinConfig;
        private System.Windows.Forms.Label labelConfig2;
        private System.Windows.Forms.Label labelConfig3;
        private System.Windows.Forms.Label labelConfig4;
        private System.Windows.Forms.Label labelConfig1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lireConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauverConfigToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderConfigurationToolStripMenuItem;
        private System.Windows.Forms.Button addConfig;
    }
}

