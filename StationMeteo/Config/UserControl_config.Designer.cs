namespace StationMeteo
{
    partial class UserControl_config
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_config = new System.Windows.Forms.GroupBox();
            this.addConfig = new System.Windows.Forms.Button();
            this.labelConfig1 = new System.Windows.Forms.Label();
            this.labelConfig4 = new System.Windows.Forms.Label();
            this.labelConfig3 = new System.Windows.Forms.Label();
            this.labelConfig2 = new System.Windows.Forms.Label();
            this.intervMinConfig = new System.Windows.Forms.TextBox();
            this.intervMaxConfig = new System.Windows.Forms.TextBox();
            this.idConfig = new System.Windows.Forms.TextBox();
            this.validerConfig = new System.Windows.Forms.Button();
            this.groupBox_config.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_config
            // 
            this.groupBox_config.Controls.Add(this.addConfig);
            this.groupBox_config.Controls.Add(this.labelConfig1);
            this.groupBox_config.Controls.Add(this.labelConfig4);
            this.groupBox_config.Controls.Add(this.labelConfig3);
            this.groupBox_config.Controls.Add(this.labelConfig2);
            this.groupBox_config.Controls.Add(this.intervMinConfig);
            this.groupBox_config.Controls.Add(this.intervMaxConfig);
            this.groupBox_config.Controls.Add(this.idConfig);
            this.groupBox_config.Controls.Add(this.validerConfig);
            this.groupBox_config.Location = new System.Drawing.Point(3, 3);
            this.groupBox_config.Name = "groupBox_config";
            this.groupBox_config.Size = new System.Drawing.Size(285, 343);
            this.groupBox_config.TabIndex = 1;
            this.groupBox_config.TabStop = false;
            this.groupBox_config.Text = "Configuration";
            // 
            // addConfig
            // 
            this.addConfig.Location = new System.Drawing.Point(71, 187);
            this.addConfig.Name = "addConfig";
            this.addConfig.Size = new System.Drawing.Size(114, 23);
            this.addConfig.TabIndex = 19;
            this.addConfig.Text = "Ajouter Configuration";
            this.addConfig.UseVisualStyleBackColor = true;
            // 
            // labelConfig1
            // 
            this.labelConfig1.AutoSize = true;
            this.labelConfig1.Location = new System.Drawing.Point(84, 57);
            this.labelConfig1.Name = "labelConfig1";
            this.labelConfig1.Size = new System.Drawing.Size(101, 13);
            this.labelConfig1.TabIndex = 18;
            this.labelConfig1.Text = "Configurer Intervalle";
            // 
            // labelConfig4
            // 
            this.labelConfig4.AutoSize = true;
            this.labelConfig4.Location = new System.Drawing.Point(38, 148);
            this.labelConfig4.Name = "labelConfig4";
            this.labelConfig4.Size = new System.Drawing.Size(73, 13);
            this.labelConfig4.TabIndex = 17;
            this.labelConfig4.Text = "Intervalle Max";
            // 
            // labelConfig3
            // 
            this.labelConfig3.AutoSize = true;
            this.labelConfig3.Location = new System.Drawing.Point(38, 117);
            this.labelConfig3.Name = "labelConfig3";
            this.labelConfig3.Size = new System.Drawing.Size(70, 13);
            this.labelConfig3.TabIndex = 16;
            this.labelConfig3.Text = "Intervalle Min";
            // 
            // labelConfig2
            // 
            this.labelConfig2.AutoSize = true;
            this.labelConfig2.Location = new System.Drawing.Point(38, 87);
            this.labelConfig2.Name = "labelConfig2";
            this.labelConfig2.Size = new System.Drawing.Size(18, 13);
            this.labelConfig2.TabIndex = 15;
            this.labelConfig2.Text = "ID";
            // 
            // intervMinConfig
            // 
            this.intervMinConfig.Location = new System.Drawing.Point(130, 114);
            this.intervMinConfig.Name = "intervMinConfig";
            this.intervMinConfig.Size = new System.Drawing.Size(100, 20);
            this.intervMinConfig.TabIndex = 13;
            // 
            // intervMaxConfig
            // 
            this.intervMaxConfig.Location = new System.Drawing.Point(130, 145);
            this.intervMaxConfig.Name = "intervMaxConfig";
            this.intervMaxConfig.Size = new System.Drawing.Size(100, 20);
            this.intervMaxConfig.TabIndex = 14;
            // 
            // idConfig
            // 
            this.idConfig.Location = new System.Drawing.Point(130, 84);
            this.idConfig.Name = "idConfig";
            this.idConfig.Size = new System.Drawing.Size(100, 20);
            this.idConfig.TabIndex = 12;
            this.idConfig.TextChanged += new System.EventHandler(this.idConfig_TextChanged);
            // 
            // validerConfig
            // 
            this.validerConfig.Location = new System.Drawing.Point(41, 273);
            this.validerConfig.Name = "validerConfig";
            this.validerConfig.Size = new System.Drawing.Size(189, 23);
            this.validerConfig.TabIndex = 11;
            this.validerConfig.Text = "Sauvegarder Configuration";
            this.validerConfig.UseVisualStyleBackColor = true;
            // 
            // UserControl_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_config);
            this.Name = "UserControl_config";
            this.Size = new System.Drawing.Size(300, 359);
            this.groupBox_config.ResumeLayout(false);
            this.groupBox_config.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_config;
        private System.Windows.Forms.Label labelConfig1;
        private System.Windows.Forms.Label labelConfig4;
        private System.Windows.Forms.Label labelConfig3;
        private System.Windows.Forms.Label labelConfig2;
        private System.Windows.Forms.TextBox intervMinConfig;
        private System.Windows.Forms.TextBox intervMaxConfig;
        private System.Windows.Forms.TextBox idConfig;
        public System.Windows.Forms.Button validerConfig;
        public System.Windows.Forms.Button addConfig;
    }
}
