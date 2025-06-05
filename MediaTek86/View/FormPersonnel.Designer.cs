namespace MediaTek86.view
{
    partial class FormPersonnels
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvPersonnels;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvPersonnels = new DataGridView();
            btnAjouter = new Button();
            btnModifier = new Button();
            btnSupprimer = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPersonnels).BeginInit();
            SuspendLayout();
            // 
            // dgvPersonnels
            // 
            dgvPersonnels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonnels.Location = new Point(16, 18);
            dgvPersonnels.Margin = new Padding(4, 5, 4, 5);
            dgvPersonnels.Name = "dgvPersonnels";
            dgvPersonnels.RowHeadersWidth = 51;
            dgvPersonnels.Size = new Size(1013, 615);
            dgvPersonnels.TabIndex = 0;
            dgvPersonnels.CellContentClick += dgvPersonnels_CellContentClick;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(16, 646);
            btnAjouter.Margin = new Padding(4, 5, 4, 5);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(100, 46);
            btnAjouter.TabIndex = 1;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(133, 646);
            btnModifier.Margin = new Padding(4, 5, 4, 5);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(100, 46);
            btnModifier.TabIndex = 2;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(253, 646);
            btnSupprimer.Margin = new Padding(4, 5, 4, 5);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(100, 46);
            btnSupprimer.TabIndex = 3;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // FormPersonnels
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 709);
            Controls.Add(dgvPersonnels);
            Controls.Add(btnAjouter);
            Controls.Add(btnModifier);
            Controls.Add(btnSupprimer);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormPersonnels";
            Text = "Liste du personnel";
            ((System.ComponentModel.ISupportInitialize)dgvPersonnels).EndInit();
            ResumeLayout(false);
        }
    }
}
