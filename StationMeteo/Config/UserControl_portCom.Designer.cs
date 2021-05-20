
namespace StationMeteo.Config
{
    partial class UserControl_portCom
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
            this.label1 = new System.Windows.Forms.Label();
            this.input_portCom = new System.Windows.Forms.ComboBox();
            this.submit_portCom = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.submit_portCom);
            this.groupBox1.Controls.Add(this.input_portCom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choisir Port COM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choisissez le port COM";
            // 
            // input_portCom
            // 
            this.input_portCom.FormattingEnabled = true;
            this.input_portCom.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.input_portCom.Location = new System.Drawing.Point(154, 77);
            this.input_portCom.Name = "input_portCom";
            this.input_portCom.Size = new System.Drawing.Size(100, 21);
            this.input_portCom.TabIndex = 6;
            // 
            // submit_portCom
            // 
            this.submit_portCom.Location = new System.Drawing.Point(92, 136);
            this.submit_portCom.Name = "submit_portCom";
            this.submit_portCom.Size = new System.Drawing.Size(75, 23);
            this.submit_portCom.TabIndex = 7;
            this.submit_portCom.Text = "Valider";
            this.submit_portCom.UseVisualStyleBackColor = true;
            // 
            // UserControl_portCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControl_portCom";
            this.Size = new System.Drawing.Size(303, 236);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox input_portCom;
        public System.Windows.Forms.Button submit_portCom;
    }
}
