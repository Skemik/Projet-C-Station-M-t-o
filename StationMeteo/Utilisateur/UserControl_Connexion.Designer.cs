
namespace StationMeteo.Utilisateur
{
    partial class UserControl_Connexion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.connexion_submit = new System.Windows.Forms.Button();
            this.connexion_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_connexion = new System.Windows.Forms.Label();
            this.connexion_username = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.connexion_submit);
            this.groupBox1.Controls.Add(this.connexion_password);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label_connexion);
            this.groupBox1.Controls.Add(this.connexion_username);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 304);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Se connecter";
            // 
            // connexion_submit
            // 
            this.connexion_submit.Location = new System.Drawing.Point(96, 191);
            this.connexion_submit.Name = "connexion_submit";
            this.connexion_submit.Size = new System.Drawing.Size(129, 28);
            this.connexion_submit.TabIndex = 9;
            this.connexion_submit.Text = "Connexion";
            this.connexion_submit.UseVisualStyleBackColor = true;
            // 
            // connexion_password
            // 
            this.connexion_password.Location = new System.Drawing.Point(150, 117);
            this.connexion_password.Name = "connexion_password";
            this.connexion_password.Size = new System.Drawing.Size(143, 20);
            this.connexion_password.TabIndex = 8;
            this.connexion_password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mot de passe :";
            // 
            // label_connexion
            // 
            this.label_connexion.AutoSize = true;
            this.label_connexion.Location = new System.Drawing.Point(53, 66);
            this.label_connexion.Name = "label_connexion";
            this.label_connexion.Size = new System.Drawing.Size(61, 13);
            this.label_connexion.TabIndex = 6;
            this.label_connexion.Text = "Username :";
            // 
            // connexion_username
            // 
            this.connexion_username.Location = new System.Drawing.Point(150, 63);
            this.connexion_username.Name = "connexion_username";
            this.connexion_username.Size = new System.Drawing.Size(143, 20);
            this.connexion_username.TabIndex = 5;
            // 
            // UserControl_Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControl_Connexion";
            this.Size = new System.Drawing.Size(381, 435);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_connexion;
        public System.Windows.Forms.Button connexion_submit;
        public System.Windows.Forms.TextBox connexion_password;
        public System.Windows.Forms.TextBox connexion_username;
    }
}
