using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MediaTek86.bddmanager;

namespace MediaTek86.view
{
    public partial class FormPersonnels : Form
    {
        private BddManager bdd;

        public FormPersonnels()
        {
            InitializeComponent();
            bdd = new BddManager();
            ChargerPersonnels();
        }

        // Charge les personnels dans la DataGridView
        private void ChargerPersonnels()
        {
            string requete = "SELECT idpersonnel, nom, prenom, tel, mail FROM personnel";
            try
            {
                DataTable table = bdd.ExecuteReader(requete);
                dgvPersonnels.DataSource = table;

                dgvPersonnels.Columns["idpersonnel"].HeaderText = "ID";
                dgvPersonnels.Columns["nom"].HeaderText = "Nom";
                dgvPersonnels.Columns["prenom"].HeaderText = "Prénom";
                dgvPersonnels.Columns["tel"].HeaderText = "Téléphone";
                dgvPersonnels.Columns["mail"].HeaderText = "Email";

                dgvPersonnels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPersonnels.ReadOnly = true;
                dgvPersonnels.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de chargement des personnels : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clique sur Ajouter
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FormPersonnelDetails formDetails = new FormPersonnelDetails();
            if (formDetails.ShowDialog() == DialogResult.OK)
            {
                ChargerPersonnels();
            }
        }

        // Clique sur Modifier
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvPersonnels.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un personnel à modifier.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idPersonnel = Convert.ToInt32(dgvPersonnels.SelectedRows[0].Cells["idpersonnel"].Value);
            FormPersonnelDetails formDetails = new FormPersonnelDetails(idPersonnel);
            if (formDetails.ShowDialog() == DialogResult.OK)
            {
                ChargerPersonnels();
            }
        }

        // Clique sur Supprimer
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvPersonnels.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un personnel à supprimer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idPersonnel = Convert.ToInt32(dgvPersonnels.SelectedRows[0].Cells["idpersonnel"].Value);
            DialogResult dr = MessageBox.Show("Voulez-vous vraiment supprimer ce personnel ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    string requete = "DELETE FROM personnel WHERE idpersonnel = @id";
                    var parameters = new Dictionary<string, object> { { "@id", idPersonnel } };
                    bdd.ExecuteNonQuery(requete, parameters);
                    ChargerPersonnels();
                    MessageBox.Show("Personnel supprimé avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvPersonnels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
