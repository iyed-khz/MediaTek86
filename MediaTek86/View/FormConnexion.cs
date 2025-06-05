using System;
using System.Windows.Forms;

namespace MediaTek86.View
{
    public class FormConnexion : Form
    {
        private Label labelLogin;
        private Label labelPassword;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Button buttonConnexion;
        private Button buttonQuitter;

        public FormConnexion()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            labelLogin = new Label();
            labelPassword = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            buttonConnexion = new Button();
            buttonQuitter = new Button();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(40, 30);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(53, 20);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Login :";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(40, 75);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(105, 20);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "Mot de passe :";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(130, 27);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(180, 27);
            textBoxLogin.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(130, 72);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(180, 27);
            textBoxPassword.TabIndex = 3;
            // 
            // buttonConnexion
            // 
            buttonConnexion.Location = new Point(110, 120);
            buttonConnexion.Name = "buttonConnexion";
            buttonConnexion.Size = new Size(95, 23);
            buttonConnexion.TabIndex = 4;
            buttonConnexion.Text = "Se connecter";
            buttonConnexion.Click += ButtonConnexion_Click;
            // 
            // buttonQuitter
            // 
            buttonQuitter.Location = new Point(230, 120);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new Size(75, 23);
            buttonQuitter.TabIndex = 5;
            buttonQuitter.Text = "Quitter";
            buttonQuitter.Click += ButtonQuitter_Click;
            // 
            // FormConnexion
            // 
            AcceptButton = buttonConnexion;
            ClientSize = new Size(370, 180);
            Controls.Add(labelLogin);
            Controls.Add(labelPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonConnexion);
            Controls.Add(buttonQuitter);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormConnexion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Connexion";
            Load += FormConnexion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void ButtonConnexion_Click(object? sender, EventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text;

            if (login == "admin" && password == "1234")
            {
                MessageBox.Show("Connexion réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Exemple : ouverture du formulaire accueil
                this.Hide();
                var formAccueil = new FormAccueil();
                formAccueil.Show();
            }
            else
            {
                MessageBox.Show("Login ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Clear();
                textBoxPassword.Focus();
            }
        }

        private void ButtonQuitter_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormConnexion_Load(object sender, EventArgs e)
        {

        }
    }

    // Un formulaire d'accueil minimal pour test
    public class FormAccueil : Form
    {
        public FormAccueil()
        {
            this.Text = "Accueil";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(400, 200);
        }
    }
}

