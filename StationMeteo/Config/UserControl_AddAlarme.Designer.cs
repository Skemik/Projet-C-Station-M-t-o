
namespace StationMeteo.Config
{
    partial class UserControl_AddAlarme
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
            this.groupbox_Alarme = new System.Windows.Forms.GroupBox();
            this.labelConfigAlarme2 = new System.Windows.Forms.Label();
            this.labelConfigAlarme = new System.Windows.Forms.Label();
            this.labelConfigAlarme1 = new System.Windows.Forms.Label();
            this.alarmeMinConfigAlarme = new System.Windows.Forms.TextBox();
            this.alarmeMaxConfigAlarme = new System.Windows.Forms.TextBox();
            this.idConfigAlarme = new System.Windows.Forms.TextBox();
            this.submit_alarme = new System.Windows.Forms.Button();
            this.groupbox_Alarme.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox_Alarme
            // 
            this.groupbox_Alarme.Controls.Add(this.labelConfigAlarme2);
            this.groupbox_Alarme.Controls.Add(this.labelConfigAlarme);
            this.groupbox_Alarme.Controls.Add(this.labelConfigAlarme1);
            this.groupbox_Alarme.Controls.Add(this.alarmeMinConfigAlarme);
            this.groupbox_Alarme.Controls.Add(this.alarmeMaxConfigAlarme);
            this.groupbox_Alarme.Controls.Add(this.idConfigAlarme);
            this.groupbox_Alarme.Controls.Add(this.submit_alarme);
            this.groupbox_Alarme.Location = new System.Drawing.Point(3, 3);
            this.groupbox_Alarme.Name = "groupbox_Alarme";
            this.groupbox_Alarme.Size = new System.Drawing.Size(263, 207);
            this.groupbox_Alarme.TabIndex = 0;
            this.groupbox_Alarme.TabStop = false;
            this.groupbox_Alarme.Text = "Définir Alarme";
            // 
            // labelConfigAlarme2
            // 
            this.labelConfigAlarme2.AutoSize = true;
            this.labelConfigAlarme2.Location = new System.Drawing.Point(19, 117);
            this.labelConfigAlarme2.Name = "labelConfigAlarme2";
            this.labelConfigAlarme2.Size = new System.Drawing.Size(73, 13);
            this.labelConfigAlarme2.TabIndex = 23;
            this.labelConfigAlarme2.Text = "Intervalle Max";
            // 
            // labelConfigAlarme
            // 
            this.labelConfigAlarme.AutoSize = true;
            this.labelConfigAlarme.Location = new System.Drawing.Point(19, 86);
            this.labelConfigAlarme.Name = "labelConfigAlarme";
            this.labelConfigAlarme.Size = new System.Drawing.Size(59, 13);
            this.labelConfigAlarme.TabIndex = 22;
            this.labelConfigAlarme.Text = "Alarme Min";
            // 
            // labelConfigAlarme1
            // 
            this.labelConfigAlarme1.AutoSize = true;
            this.labelConfigAlarme1.Location = new System.Drawing.Point(19, 56);
            this.labelConfigAlarme1.Name = "labelConfigAlarme1";
            this.labelConfigAlarme1.Size = new System.Drawing.Size(18, 13);
            this.labelConfigAlarme1.TabIndex = 21;
            this.labelConfigAlarme1.Text = "ID";
            // 
            // alarmeMinConfigAlarme
            // 
            this.alarmeMinConfigAlarme.Location = new System.Drawing.Point(111, 83);
            this.alarmeMinConfigAlarme.Name = "alarmeMinConfigAlarme";
            this.alarmeMinConfigAlarme.Size = new System.Drawing.Size(100, 20);
            this.alarmeMinConfigAlarme.TabIndex = 19;
            // 
            // alarmeMaxConfigAlarme
            // 
            this.alarmeMaxConfigAlarme.Location = new System.Drawing.Point(111, 114);
            this.alarmeMaxConfigAlarme.Name = "alarmeMaxConfigAlarme";
            this.alarmeMaxConfigAlarme.Size = new System.Drawing.Size(100, 20);
            this.alarmeMaxConfigAlarme.TabIndex = 20;
            // 
            // idConfigAlarme
            // 
            this.idConfigAlarme.Location = new System.Drawing.Point(111, 53);
            this.idConfigAlarme.Name = "idConfigAlarme";
            this.idConfigAlarme.Size = new System.Drawing.Size(100, 20);
            this.idConfigAlarme.TabIndex = 18;
            // 
            // submit_alarme
            // 
            this.submit_alarme.Location = new System.Drawing.Point(46, 163);
            this.submit_alarme.Name = "submit_alarme";
            this.submit_alarme.Size = new System.Drawing.Size(127, 23);
            this.submit_alarme.TabIndex = 0;
            this.submit_alarme.Text = "Insérer Alarme";
            this.submit_alarme.UseVisualStyleBackColor = true;
            // 
            // UserControl_AddAlarme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupbox_Alarme);
            this.Name = "UserControl_AddAlarme";
            this.Size = new System.Drawing.Size(270, 217);
            this.groupbox_Alarme.ResumeLayout(false);
            this.groupbox_Alarme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox_Alarme;
        private System.Windows.Forms.Label labelConfigAlarme2;
        private System.Windows.Forms.Label labelConfigAlarme;
        private System.Windows.Forms.Label labelConfigAlarme1;
        public System.Windows.Forms.TextBox alarmeMinConfigAlarme;
        public System.Windows.Forms.TextBox alarmeMaxConfigAlarme;
        public System.Windows.Forms.TextBox idConfigAlarme;
        public System.Windows.Forms.Button submit_alarme;
    }
}
