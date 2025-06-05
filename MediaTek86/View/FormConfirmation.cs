using System;
using System.Windows.Forms;

namespace MediaTek86.Views
{
    public partial class FormConfirmation : Form
    {
        private Label lblMessage = null!;
        private Button btnOui = null!;
        private Button btnNon = null!;

        public bool ConfirmationResult { get; private set; } = false;

        public FormConfirmation(string message)
        {
            InitializeComponent();
            lblMessage.Text = message;
        }

        private void btnOui_Click(object sender, EventArgs e)
        {
            ConfirmationResult = true;
            this.Close();
        }

        private void btnNon_Click(object sender, EventArgs e)
        {
            ConfirmationResult = false;
            this.Close();
        }

        private void InitializeComponent()
        {
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnOui = new System.Windows.Forms.Button();
            this.btnNon = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblMessage
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(20, 20);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(300, 20);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Message de confirmation";

            // btnOui
            this.btnOui.Location = new System.Drawing.Point(40, 60);
            this.btnOui.Name = "btnOui";
            this.btnOui.Size = new System.Drawing.Size(75, 30);
            this.btnOui.TabIndex = 1;
            this.btnOui.Text = "Oui";
            this.btnOui.UseVisualStyleBackColor = true;
            this.btnOui.Click += new System.EventHandler(this.btnOui_Click);

            // btnNon
            this.btnNon.Location = new System.Drawing.Point(140, 60);
            this.btnNon.Name = "btnNon";
            this.btnNon.Size = new System.Drawing.Size(75, 30);
            this.btnNon.TabIndex = 2;
            this.btnNon.Text = "Non";
            this.btnNon.UseVisualStyleBackColor = true;
            this.btnNon.Click += new System.EventHandler(this.btnNon_Click);

            // FormConfirmation
            this.ClientSize = new System.Drawing.Size(260, 110);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnOui);
            this.Controls.Add(this.btnNon);
            this.Name = "FormConfirmation";
            this.Text = "Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
