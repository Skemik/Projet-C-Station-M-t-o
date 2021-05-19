
namespace StationMeteo.Utilisateur
{
    partial class UserControl_SupprimerUtilisateur
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
            this.delete_user = new System.Windows.Forms.GroupBox();
            this.deleteUser_submit = new System.Windows.Forms.Button();
            this.deleteUser_label = new System.Windows.Forms.Label();
            this.deleteUser_text = new System.Windows.Forms.TextBox();
            this.delete_user.SuspendLayout();
            this.SuspendLayout();
            // 
            // delete_user
            // 
            this.delete_user.Controls.Add(this.deleteUser_submit);
            this.delete_user.Controls.Add(this.deleteUser_label);
            this.delete_user.Controls.Add(this.deleteUser_text);
            this.delete_user.Location = new System.Drawing.Point(3, 3);
            this.delete_user.Name = "delete_user";
            this.delete_user.Size = new System.Drawing.Size(290, 259);
            this.delete_user.TabIndex = 0;
            this.delete_user.TabStop = false;
            this.delete_user.Text = "Supprimer Utilisateur";
            // 
            // deleteUser_submit
            // 
            this.deleteUser_submit.Location = new System.Drawing.Point(89, 139);
            this.deleteUser_submit.Name = "deleteUser_submit";
            this.deleteUser_submit.Size = new System.Drawing.Size(75, 23);
            this.deleteUser_submit.TabIndex = 2;
            this.deleteUser_submit.Text = "Supprimer";
            this.deleteUser_submit.UseVisualStyleBackColor = true;
            // 
            // deleteUser_label
            // 
            this.deleteUser_label.AutoSize = true;
            this.deleteUser_label.Location = new System.Drawing.Point(16, 71);
            this.deleteUser_label.Name = "deleteUser_label";
            this.deleteUser_label.Size = new System.Drawing.Size(104, 13);
            this.deleteUser_label.TabIndex = 1;
            this.deleteUser_label.Text = "Nom de l\'utilisateur : ";
            // 
            // deleteUser_text
            // 
            this.deleteUser_text.Location = new System.Drawing.Point(160, 68);
            this.deleteUser_text.Name = "deleteUser_text";
            this.deleteUser_text.Size = new System.Drawing.Size(100, 20);
            this.deleteUser_text.TabIndex = 0;
            // 
            // UserControl_SupprimerUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.delete_user);
            this.Name = "UserControl_SupprimerUtilisateur";
            this.Size = new System.Drawing.Size(295, 264);
            this.delete_user.ResumeLayout(false);
            this.delete_user.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox delete_user;
        private System.Windows.Forms.Label deleteUser_label;
        public System.Windows.Forms.Button deleteUser_submit;
        public System.Windows.Forms.TextBox deleteUser_text;
    }
}
