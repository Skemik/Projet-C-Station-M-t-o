namespace StationMeteo.Utilisateur
{
    partial class UserControl_NouveauUtilisateur
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
            this.groupBox_newuser = new System.Windows.Forms.GroupBox();
            this.submit_newuser = new System.Windows.Forms.Button();
            this.input_rightsNewuser = new System.Windows.Forms.ComboBox();
            this.input_pwNewuser = new System.Windows.Forms.TextBox();
            this.input_usernameNewuser = new System.Windows.Forms.TextBox();
            this.rights_label = new System.Windows.Forms.Label();
            this.pw_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.groupBox_newuser.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_newuser
            // 
            this.groupBox_newuser.Controls.Add(this.submit_newuser);
            this.groupBox_newuser.Controls.Add(this.input_rightsNewuser);
            this.groupBox_newuser.Controls.Add(this.input_pwNewuser);
            this.groupBox_newuser.Controls.Add(this.input_usernameNewuser);
            this.groupBox_newuser.Controls.Add(this.rights_label);
            this.groupBox_newuser.Controls.Add(this.pw_label);
            this.groupBox_newuser.Controls.Add(this.username_label);
            this.groupBox_newuser.Location = new System.Drawing.Point(3, 0);
            this.groupBox_newuser.Name = "groupBox_newuser";
            this.groupBox_newuser.Size = new System.Drawing.Size(293, 314);
            this.groupBox_newuser.TabIndex = 0;
            this.groupBox_newuser.TabStop = false;
            this.groupBox_newuser.Text = "Insérer un nouvel Utilisateur";
            this.groupBox_newuser.Enter += new System.EventHandler(this.groupBox_newuser_Enter);
            // 
            // submit_newuser
            // 
            this.submit_newuser.Location = new System.Drawing.Point(94, 175);
            this.submit_newuser.Name = "submit_newuser";
            this.submit_newuser.Size = new System.Drawing.Size(75, 23);
            this.submit_newuser.TabIndex = 6;
            this.submit_newuser.Text = "Insérer";
            this.submit_newuser.UseVisualStyleBackColor = true;
            // 
            // input_rightsNewuser
            // 
            this.input_rightsNewuser.FormattingEnabled = true;
            this.input_rightsNewuser.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.input_rightsNewuser.Location = new System.Drawing.Point(147, 115);
            this.input_rightsNewuser.Name = "input_rightsNewuser";
            this.input_rightsNewuser.Size = new System.Drawing.Size(100, 21);
            this.input_rightsNewuser.TabIndex = 5;
            // 
            // input_pwNewuser
            // 
            this.input_pwNewuser.Location = new System.Drawing.Point(147, 84);
            this.input_pwNewuser.Name = "input_pwNewuser";
            this.input_pwNewuser.Size = new System.Drawing.Size(100, 20);
            this.input_pwNewuser.TabIndex = 4;
            this.input_pwNewuser.UseSystemPasswordChar = true;
            // 
            // input_usernameNewuser
            // 
            this.input_usernameNewuser.Location = new System.Drawing.Point(147, 51);
            this.input_usernameNewuser.Name = "input_usernameNewuser";
            this.input_usernameNewuser.Size = new System.Drawing.Size(100, 20);
            this.input_usernameNewuser.TabIndex = 3;
            // 
            // rights_label
            // 
            this.rights_label.AutoSize = true;
            this.rights_label.Location = new System.Drawing.Point(58, 118);
            this.rights_label.Name = "rights_label";
            this.rights_label.Size = new System.Drawing.Size(40, 13);
            this.rights_label.TabIndex = 2;
            this.rights_label.Text = "Droits :";
            // 
            // pw_label
            // 
            this.pw_label.AutoSize = true;
            this.pw_label.Location = new System.Drawing.Point(21, 87);
            this.pw_label.Name = "pw_label";
            this.pw_label.Size = new System.Drawing.Size(77, 13);
            this.pw_label.TabIndex = 1;
            this.pw_label.Text = "Mot de passe :";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(49, 54);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(49, 13);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "Pseudo :";
            // 
            // UserControl_NouveauUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_newuser);
            this.Name = "UserControl_NouveauUtilisateur";
            this.Size = new System.Drawing.Size(293, 299);
            this.Load += new System.EventHandler(this.UserControl_NouveauUtilisateur_Load);
            this.groupBox_newuser.ResumeLayout(false);
            this.groupBox_newuser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_newuser;
        private System.Windows.Forms.Label rights_label;
        private System.Windows.Forms.Label pw_label;
        private System.Windows.Forms.Label username_label;
        public System.Windows.Forms.ComboBox input_rightsNewuser;
        public System.Windows.Forms.Button submit_newuser;
        public System.Windows.Forms.TextBox input_usernameNewuser;
        public System.Windows.Forms.TextBox input_pwNewuser;
    }
}
