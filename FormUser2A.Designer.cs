namespace InterfacePPE
{
    partial class FormUser2A
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTouslesParticipants = new System.Windows.Forms.Button();
            this.GridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, -35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Bienvenue";
            // 
            // btnTouslesParticipants
            // 
            this.btnTouslesParticipants.Location = new System.Drawing.Point(308, 473);
            this.btnTouslesParticipants.Margin = new System.Windows.Forms.Padding(4);
            this.btnTouslesParticipants.Name = "btnTouslesParticipants";
            this.btnTouslesParticipants.Size = new System.Drawing.Size(176, 54);
            this.btnTouslesParticipants.TabIndex = 23;
            this.btnTouslesParticipants.Text = "Voir les participants";
            this.btnTouslesParticipants.UseVisualStyleBackColor = true;
            this.btnTouslesParticipants.Click += new System.EventHandler(this.btnTouslesParticipants_Click);
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(33, 26);
            this.GridView.Margin = new System.Windows.Forms.Padding(4);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersWidth = 51;
            this.GridView.Size = new System.Drawing.Size(752, 411);
            this.GridView.TabIndex = 22;
            this.GridView.Visible = false;
            // 
            // FormUser2A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTouslesParticipants);
            this.Controls.Add(this.GridView);
            this.Name = "FormUser2A";
            this.Text = "FormUser2A";
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTouslesParticipants;
        private System.Windows.Forms.DataGridView GridView;
    }
}