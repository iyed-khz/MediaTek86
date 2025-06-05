using System;
using System.Windows.Forms;

namespace MediaTek86
{
    public partial class FormAccueil : Form
    {
        private Button btnGestionPersonnel;
        private Button btnGestionAbsences;
        private Button btnQuitter;
        private Label labelTitre;
        private Button btnMaquettes;

        // this.btnMaquettes = new Button();
        // this.btnMaquettes.Click += new EventHandler(this.btnMaquettes_Click);
        // this.Controls.Add(this.btnMaquettes);

        // private void btnMaquettes_Click(object sender, EventArgs e)
        // {
        //     var formMaquettes = new FormMaquettes();
        //     formMaquettes.ShowDialog();
        // }

        public FormAccueil()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            btnGestionPersonnel = new Button();
            btnGestionAbsences = new Button();
            btnQuitter = new Button();
            labelTitre = new Label();
            btnMaquettes = new Button();
            SuspendLayout();
            // 
            // btnGestionPersonnel
            // 
            btnGestionPersonnel.Location = new Point(50, 80);
            btnGestionPersonnel.Name = "btnGestionPersonnel";
            btnGestionPersonnel.Size = new Size(180, 40);
            btnGestionPersonnel.TabIndex = 3;
            btnGestionPersonnel.Text = "Gérer le personnel";
            btnGestionPersonnel.UseVisualStyleBackColor = true;
            btnGestionPersonnel.Click += btnGestionPersonnel_Click;
            // 
            // btnGestionAbsences
            // 
            btnGestionAbsences.Location = new Point(50, 130);
            btnGestionAbsences.Name = "btnGestionAbsences";
            btnGestionAbsences.Size = new Size(180, 40);
            btnGestionAbsences.TabIndex = 2;
            btnGestionAbsences.Text = "Gérer les absences";
            btnGestionAbsences.UseVisualStyleBackColor = true;
            btnGestionAbsences.Click += btnGestionAbsences_Click;
            // 
            // btnQuitter
            // 
            btnQuitter.Location = new Point(50, 180);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(180, 40);
            btnQuitter.TabIndex = 1;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = true;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // labelTitre
            // 
            labelTitre.AutoSize = true;
            labelTitre.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitre.Location = new Point(45, 20);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(273, 37);
            labelTitre.TabIndex = 0;
            labelTitre.Text = "Accueil MediaTek86";
            labelTitre.Click += labelTitre_Click;
            // 
            // btnMaquettes
            // 
            btnMaquettes.Location = new Point(50, 230);
            btnMaquettes.Name = "btnMaquettes";
            btnMaquettes.Size = new Size(180, 40);
            btnMaquettes.TabIndex = 4;
            btnMaquettes.Text = "Voir les maquettes";
            btnMaquettes.UseVisualStyleBackColor = true;
            btnMaquettes.Click += btnMaquettes_Click;
            // 
            // FormAccueil
            // 
            ClientSize = new Size(333, 304);
            Controls.Add(labelTitre);
            Controls.Add(btnQuitter);
            Controls.Add(btnGestionAbsences);
            Controls.Add(btnGestionPersonnel);
            Controls.Add(btnMaquettes);
            Name = "FormAccueil";
            Text = "Accueil";
            Load += FormAccueil_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnGestionPersonnel_Click(object sender, EventArgs e)
        {
            FormPersonnels formPersonnels = new FormPersonnels();
            formPersonnels.ShowDialog();
        }

        private void btnGestionAbsences_Click(object sender, EventArgs e)
        {
            FormAbsences formAbsences = new FormAbsences();
            formAbsences.ShowDialog();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelTitre_Click(object sender, EventArgs e)
        {

        }

        private void FormAccueil_Load(object sender, EventArgs e)
        {

        }
        private void btnMaquettes_Click(object sender, EventArgs e)
        {
            var formMaquettes = new MediaTek86.view.FormMaquettes();
            formMaquettes.ShowDialog();
        }

    }
}
