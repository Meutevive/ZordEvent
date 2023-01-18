namespace InterfacePPE
{
    partial class FormUser1C
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
            this.GridView = new System.Windows.Forms.DataGridView();
            this.btnTouslesParticipants = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(68, 56);
            this.GridView.Margin = new System.Windows.Forms.Padding(4);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersWidth = 51;
            this.GridView.Size = new System.Drawing.Size(752, 411);
            this.GridView.TabIndex = 19;
            this.GridView.Visible = false;
            // 
            // btnTouslesParticipants
            // 
            this.btnTouslesParticipants.Location = new System.Drawing.Point(349, 484);
            this.btnTouslesParticipants.Margin = new System.Windows.Forms.Padding(4);
            this.btnTouslesParticipants.Name = "btnTouslesParticipants";
            this.btnTouslesParticipants.Size = new System.Drawing.Size(176, 54);
            this.btnTouslesParticipants.TabIndex = 20;
            this.btnTouslesParticipants.Text = "Tous les Participants";
            this.btnTouslesParticipants.UseVisualStyleBackColor = true;
            this.btnTouslesParticipants.Click += new System.EventHandler(this.btnTouslesParticipants_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Bienvenue";
            // 
            // FormUser1C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 551);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTouslesParticipants);
            this.Controls.Add(this.GridView);
            this.Name = "FormUser1C";
            this.Text = "FormUser";
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Button btnTouslesParticipants;
        private System.Windows.Forms.Label label1;
    }
}