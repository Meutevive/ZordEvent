namespace InterfacePPE
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRechercheNom = new System.Windows.Forms.TextBox();
            this.btnTouslesParticipants = new System.Windows.Forms.Button();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnRechercherParticipant = new System.Windows.Forms.Button();
            this.btnAjouterParticipant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(538, 340);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(132, 49);
            this.btnSupprimer.TabIndex = 22;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Prenom";
            // 
            // tbRechercheNom
            // 
            this.tbRechercheNom.Location = new System.Drawing.Point(231, 32);
            this.tbRechercheNom.Margin = new System.Windows.Forms.Padding(2);
            this.tbRechercheNom.Name = "tbRechercheNom";
            this.tbRechercheNom.Size = new System.Drawing.Size(241, 20);
            this.tbRechercheNom.TabIndex = 20;
            // 
            // btnTouslesParticipants
            // 
            this.btnTouslesParticipants.Location = new System.Drawing.Point(538, 103);
            this.btnTouslesParticipants.Name = "btnTouslesParticipants";
            this.btnTouslesParticipants.Size = new System.Drawing.Size(132, 44);
            this.btnTouslesParticipants.TabIndex = 19;
            this.btnTouslesParticipants.Text = "Tous les Participants";
            this.btnTouslesParticipants.UseVisualStyleBackColor = true;
            this.btnTouslesParticipants.Click += new System.EventHandler(this.btnTouslesParticipants_Click_1);
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(20, 75);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersWidth = 51;
            this.GridView.Size = new System.Drawing.Size(513, 314);
            this.GridView.TabIndex = 18;
            this.GridView.Visible = false;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(538, 258);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(132, 44);
            this.btnModifier.TabIndex = 17;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click_1);
            // 
            // btnRechercherParticipant
            // 
            this.btnRechercherParticipant.Location = new System.Drawing.Point(538, 32);
            this.btnRechercherParticipant.Margin = new System.Windows.Forms.Padding(2);
            this.btnRechercherParticipant.Name = "btnRechercherParticipant";
            this.btnRechercherParticipant.Size = new System.Drawing.Size(132, 45);
            this.btnRechercherParticipant.TabIndex = 16;
            this.btnRechercherParticipant.Text = "Rechercher";
            this.btnRechercherParticipant.UseVisualStyleBackColor = true;
            this.btnRechercherParticipant.Click += new System.EventHandler(this.btnRechercherParticipant_Click_1);
            // 
            // btnAjouterParticipant
            // 
            this.btnAjouterParticipant.Location = new System.Drawing.Point(538, 181);
            this.btnAjouterParticipant.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouterParticipant.Name = "btnAjouterParticipant";
            this.btnAjouterParticipant.Size = new System.Drawing.Size(132, 46);
            this.btnAjouterParticipant.TabIndex = 15;
            this.btnAjouterParticipant.Text = "Ajouter un Participant";
            this.btnAjouterParticipant.UseVisualStyleBackColor = true;
            this.btnAjouterParticipant.Click += new System.EventHandler(this.btnAjouterParticipant_Click_1);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 401);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRechercheNom);
            this.Controls.Add(this.btnTouslesParticipants);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnRechercherParticipant);
            this.Controls.Add(this.btnAjouterParticipant);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRechercheNom;
        private System.Windows.Forms.Button btnTouslesParticipants;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnRechercherParticipant;
        private System.Windows.Forms.Button btnAjouterParticipant;
    }
}