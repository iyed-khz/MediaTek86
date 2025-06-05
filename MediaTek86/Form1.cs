// MediaTek86 Application 

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MediaTek86
{
    public class Personnel
    {
        public int Id { get; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Mail { get; set; }
        public string Telephone { get; set; }
        public int IdService { get; }

        public Personnel(int id, string prenom, string nom, string mail, string telephone, int idService)
        {
            Id = id;
            Prenom = prenom;
            Nom = nom;
            Mail = mail;
            Telephone = telephone;
            IdService = idService;
        }

        public override string ToString()
        {
            return $"{Prenom} {Nom}";
        }
    }

    public class Absence
    {
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string Motif { get; set; }

        public Absence(DateTime dateDebut, DateTime dateFin, string motif)
        {
            DateDebut = dateDebut;
            DateFin = dateFin;
            Motif = motif;
        }

        public override string ToString()
        {
            return $"{DateDebut:dd/MM/yyyy} - {DateFin:dd/MM/yyyy} : {Motif}";
        }
    }

    public class FormConnexion : Form
    {
        private TextBox txtIdentifiant;
        private TextBox txtMotDePasse;
        private Label lblErreur;

        public FormConnexion()
        {
            Text = "Connexion";
            Size = new Size(350, 220);
            StartPosition = FormStartPosition.CenterScreen;

            Label lblIdentifiant = new Label() { Text = "Identifiant :", Location = new Point(20, 20), AutoSize = true };
            txtIdentifiant = new TextBox() { Location = new Point(120, 20), Width = 180 };

            Label lblMotDePasse = new Label() { Text = "Mot de passe :", Location = new Point(20, 60), AutoSize = true };
            txtMotDePasse = new TextBox() { Location = new Point(120, 60), Width = 180, PasswordChar = '●' };

            Button btnConnexion = new Button() { Text = "Se connecter", Location = new Point(120, 100), Width = 120 };
            btnConnexion.Click += BtnConnexion_Click;

            lblErreur = new Label()
            {
                Text = "Identifiant ou mot de passe incorrect",
                ForeColor = Color.Red,
                Location = new Point(20, 140),
                AutoSize = true,
                Visible = false
            };

            Controls.Add(lblIdentifiant);
            Controls.Add(txtIdentifiant);
            Controls.Add(lblMotDePasse);
            Controls.Add(txtMotDePasse);
            Controls.Add(btnConnexion);
            Controls.Add(lblErreur);
        }

        private void BtnConnexion_Click(object? sender, EventArgs e)
        {
            if (txtIdentifiant.Text == "admin" && txtMotDePasse.Text == "1234")
            {
                lblErreur.Visible = false;
                Hide();
                new FormAccueil().ShowDialog();
                Close();
            }
            else
            {
                lblErreur.Visible = true;
            }
        }
    }

    public class FormAccueil : Form
    {
        public FormAccueil()
        {
            Text = "Page d'accueil";
            Size = new Size(400, 140);
            StartPosition = FormStartPosition.CenterScreen;

            Button btnGestionPersonnel = new Button() { Text = "Gérer les personnels", Location = new Point(30, 30), Size = new Size(160, 40) };
            btnGestionPersonnel.Click += (s, e) => new FormPersonnels().ShowDialog();

            Button btnDeconnexion = new Button() { Text = "Déconnexion", Location = new Point(210, 30), Size = new Size(120, 40) };
            btnDeconnexion.Click += (s, e) => { Close(); new FormConnexion().Show(); };

            Controls.Add(btnGestionPersonnel);
            Controls.Add(btnDeconnexion);
        }
    }

    public class FormPersonnels : Form
    {
        private ListBox listBoxPersonnels = new ListBox();
        private List<Personnel> personnels = new List<Personnel>
        {
            new Personnel(1, "Mohamed", "Ali", "mohamed@example.com", "0102030405", 101),
            new Personnel(2, "Hayniss", "Zara", "hayniss@example.com", "0607080910", 102)
        };

        public FormPersonnels()
        {
            Text = "Liste des personnels";
            Size = new Size(400, 300);
            StartPosition = FormStartPosition.CenterScreen;

            listBoxPersonnels.Location = new Point(20, 20);
            listBoxPersonnels.Size = new Size(340, 150);
            Controls.Add(listBoxPersonnels);

            Button btnAfficherAbsences = new Button() { Text = "Afficher absences", Location = new Point(20, 180), Size = new Size(120, 30) };
            btnAfficherAbsences.Click += (s, e) =>
            {
                if (listBoxPersonnels.SelectedItem is Personnel p)
                    new FormAbsences(p).ShowDialog();
            };

            Button btnAjouter = new Button() { Text = "Ajouter", Location = new Point(150, 180), Size = new Size(80, 30) };
            btnAjouter.Click += (s, e) => { /* À implémenter */ };

            Button btnSupprimer = new Button() { Text = "Supprimer", Location = new Point(240, 180), Size = new Size(80, 30) };
            btnSupprimer.Click += (s, e) => { /* À implémenter */ };

            Controls.Add(btnAfficherAbsences);
            Controls.Add(btnAjouter);
            Controls.Add(btnSupprimer);

            ActualiserListe();
        }

        private void ActualiserListe()
        {
            listBoxPersonnels.Items.Clear();
            foreach (var p in personnels)
                listBoxPersonnels.Items.Add(p);
        }
    }

    public class FormAbsences : Form
    {
        private Personnel personnel;
        private List<Absence> absences = new List<Absence>();
        private ListBox listBoxAbsences = new ListBox();

        public FormAbsences(Personnel personnel)
        {
            this.personnel = personnel;
            Text = $"Absences de {personnel.Prenom} {personnel.Nom}";
            Size = new Size(400, 300);
            StartPosition = FormStartPosition.CenterScreen;

            listBoxAbsences.Location = new Point(20, 20);
            listBoxAbsences.Size = new Size(340, 150);
            Controls.Add(listBoxAbsences);

            Button btnAjouter = new Button() { Text = "Ajouter", Location = new Point(20, 180), Size = new Size(100, 30) };
            btnAjouter.Click += (s, e) => { /* Ajouter absence */ };

            Button btnModifier = new Button() { Text = "Modifier", Location = new Point(130, 180), Size = new Size(100, 30) };
            btnModifier.Click += (s, e) => { /* Modifier absence */ };

            Button btnSupprimer = new Button() { Text = "Supprimer", Location = new Point(240, 180), Size = new Size(100, 30) };
            btnSupprimer.Click += (s, e) => { /* Supprimer absence */ };

            Controls.Add(btnAjouter);
            Controls.Add(btnModifier);
            Controls.Add(btnSupprimer);

            ChargerAbsences();
        }

        private void ChargerAbsences()
        {
            listBoxAbsences.Items.Clear();
            foreach (var abs in absences)
                listBoxAbsences.Items.Add(abs);
        }
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormConnexion());
        }
    }
}
