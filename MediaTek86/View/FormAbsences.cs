using System;
using System.Windows.Forms;

namespace MediaTek86.View
{
    public partial class FormAbsences : Form
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvAbsences;
        private Button btnAjouter;
        private Button btnModifier;
        private Button btnSupprimer;
        private Button btnQuitter;

        public FormAbsences()
        {
            InitializeComponent();
        }

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
            dgvAbsences = new DataGridView();
            btnAjouter = new Button();
            btnModifier = new Button();
            btnSupprimer = new Button();
            btnQuitter = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAbsences).BeginInit();
            SuspendLayout();
            // 
            // dgvAbsences
            // 
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAbsences.ColumnHeadersHeight = 29;
            dgvAbsences.Location = new Point(20, 20);
            dgvAbsences.MultiSelect = false;
            dgvAbsences.Name = "dgvAbsences";
            dgvAbsences.RowHeadersWidth = 51;
            dgvAbsences.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAbsences.Size = new Size(600, 300);
            dgvAbsences.TabIndex = 0;
            dgvAbsences.CellContentClick += dgvAbsences_CellContentClick;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(650, 50);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(100, 30);
            btnAjouter.TabIndex = 1;
            btnAjouter.Text = "Ajouter";
            btnAjouter.Click += BtnAjouter_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(650, 100);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(100, 30);
            btnModifier.TabIndex = 2;
            btnModifier.Text = "Modifier";
            btnModifier.Click += BtnModifier_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(650, 150);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(100, 30);
            btnSupprimer.TabIndex = 3;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.Click += BtnSupprimer_Click;
            // 
            // btnQuitter
            // 
            btnQuitter.Location = new Point(650, 200);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(100, 30);
            btnQuitter.TabIndex = 4;
            btnQuitter.Text = "Quitter";
            btnQuitter.Click += BtnQuitter_Click;
            // 
            // FormAbsences
            // 
            ClientSize = new Size(800, 350);
            Controls.Add(dgvAbsences);
            Controls.Add(btnAjouter);
            Controls.Add(btnModifier);
            Controls.Add(btnSupprimer);
            Controls.Add(btnQuitter);
            Name = "FormAbsences";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion des Absences";
            ((System.ComponentModel.ISupportInitialize)dgvAbsences).EndInit();
            ResumeLayout(false);
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ajouter absence");
            // TODO: Ajouter la logique d'ajout
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                MessageBox.Show("Modifier absence sélectionnée");
                // TODO: Ajouter la logique de modification
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une absence à modifier.");
            }
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Confirmez la suppression ?", "Suppression", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Absence supprimée");
                    // TODO: Ajouter la logique de suppression
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une absence à supprimer.");
            }
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAbsences_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

