
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MediaTek86.view
{
    public partial class FormMaquettes : Form
    {
        private ComboBox cmbMaquettes;
        private PictureBox pictureBox;

        public FormMaquettes()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Galerie des Maquettes";
            this.Size = new Size(1000, 700);
            this.StartPosition = FormStartPosition.CenterScreen;

            cmbMaquettes = new ComboBox();
            cmbMaquettes.Dock = DockStyle.Top;
            cmbMaquettes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaquettes.Items.AddRange(new object[]
            {
                "Connexion",
                "Accueil",
                "Personnel - Liste",
                "Personnel_1 - Fiche",
                "Absence - Liste",
                "Absence - Formulaire",
                "Confirmation - Personnel",
                "Confirmation - Absence"
            });
            cmbMaquettes.SelectedIndexChanged += CmbMaquettes_SelectedIndexChanged;

            pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            this.Controls.Add(pictureBox);
            this.Controls.Add(cmbMaquettes);
        }

        private void CmbMaquettes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbMaquettes.SelectedIndex)
            {
                case 0:
                    pictureBox.Image = Image.FromFile("connexion_.png");
                    break;
                case 1:
                    pictureBox.Image = Image.FromFile("accueil.png");
                    break;
                case 2:
                    pictureBox.Image = Image.FromFile("personnel_1.png");
                    break;
                case 3:
                    pictureBox.Image = Image.FromFile("personnel.png");
                    break;
                case 4:
                    pictureBox.Image = Image.FromFile("absence_.png");
                    break;
                case 5:
                    pictureBox.Image = Image.FromFile("ajouter_des_absences.png");
                    break;
                case 6:
                    pictureBox.Image = Image.FromFile("supprimer.png");
                    break;
                case 7:
                    pictureBox.Image = Image.FromFile("supprimer_1.png");
                    break;
            }
        }
    }
}
