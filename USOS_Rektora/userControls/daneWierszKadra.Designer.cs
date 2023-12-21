namespace USOS_Rektora.userControls
{
    partial class daneWierszKadra
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            panelNaglowki = new Panel();
            panel1 = new Panel();
            checkBoxId = new CheckBox();
            mail = new Label();
            nrTel = new Label();
            stanowisko = new Label();
            nazw = new Label();
            imie = new Label();
            panelNaglowki.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelNaglowki
            // 
            panelNaglowki.Controls.Add(panel1);
            panelNaglowki.Controls.Add(mail);
            panelNaglowki.Controls.Add(nrTel);
            panelNaglowki.Controls.Add(stanowisko);
            panelNaglowki.Controls.Add(nazw);
            panelNaglowki.Controls.Add(imie);
            panelNaglowki.Dock = DockStyle.Fill;
            panelNaglowki.Location = new Point(0, 0);
            panelNaglowki.Margin = new Padding(0);
            panelNaglowki.Name = "panelNaglowki";
            panelNaglowki.Size = new Size(784, 38);
            panelNaglowki.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(checkBoxId);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(50, 38);
            panel1.TabIndex = 8;
            // 
            // checkBoxId
            // 
            checkBoxId.BackColor = Color.Silver;
            checkBoxId.CheckAlign = ContentAlignment.MiddleCenter;
            checkBoxId.Dock = DockStyle.Fill;
            checkBoxId.ForeColor = Color.Silver;
            checkBoxId.Location = new Point(0, 0);
            checkBoxId.Margin = new Padding(0);
            checkBoxId.Name = "checkBoxId";
            checkBoxId.Size = new Size(48, 36);
            checkBoxId.TabIndex = 7;
            checkBoxId.Text = "ID";
            checkBoxId.UseVisualStyleBackColor = false;
            checkBoxId.CheckedChanged += checkBoxId_CheckedChanged;
            // 
            // mail
            // 
            mail.BackColor = Color.Silver;
            mail.BorderStyle = BorderStyle.FixedSingle;
            mail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            mail.Location = new Point(622, 0);
            mail.Margin = new Padding(0);
            mail.Name = "mail";
            mail.Size = new Size(162, 39);
            mail.TabIndex = 5;
            mail.Text = "Adres e-mail";
            mail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nrTel
            // 
            nrTel.BackColor = Color.Silver;
            nrTel.BorderStyle = BorderStyle.FixedSingle;
            nrTel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nrTel.Location = new Point(463, 0);
            nrTel.Margin = new Padding(0);
            nrTel.Name = "nrTel";
            nrTel.Size = new Size(160, 39);
            nrTel.TabIndex = 4;
            nrTel.Text = "Numer telefonu";
            nrTel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // stanowisko
            // 
            stanowisko.BackColor = Color.Silver;
            stanowisko.BorderStyle = BorderStyle.FixedSingle;
            stanowisko.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            stanowisko.Location = new Point(312, 0);
            stanowisko.Margin = new Padding(0);
            stanowisko.Name = "stanowisko";
            stanowisko.Size = new Size(151, 39);
            stanowisko.TabIndex = 3;
            stanowisko.Text = "Stanowisko";
            stanowisko.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nazw
            // 
            nazw.BackColor = Color.Silver;
            nazw.BorderStyle = BorderStyle.FixedSingle;
            nazw.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nazw.Location = new Point(178, 0);
            nazw.Margin = new Padding(0);
            nazw.Name = "nazw";
            nazw.Size = new Size(134, 39);
            nazw.TabIndex = 2;
            nazw.Text = "Nazwisko";
            nazw.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imie
            // 
            imie.BackColor = Color.Silver;
            imie.BorderStyle = BorderStyle.FixedSingle;
            imie.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            imie.Location = new Point(50, 0);
            imie.Margin = new Padding(0);
            imie.Name = "imie";
            imie.Size = new Size(129, 39);
            imie.TabIndex = 1;
            imie.Text = "Imię";
            imie.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // daneWierszKadra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelNaglowki);
            Margin = new Padding(3, 2, 3, 2);
            Name = "daneWierszKadra";
            Size = new Size(784, 38);
            Load += daneWierszKadra_Load;
            panelNaglowki.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNaglowki;
        private Panel panel1;
        private CheckBox checkBoxId;
        private Label mail;
        private Label nrTel;
        private Label stanowisko;
        private Label nazw;
        private Label imie;
    }
}
