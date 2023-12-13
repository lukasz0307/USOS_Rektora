namespace USOS_Rektora.userControls
{
    partial class daneWiersz
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
            wydz = new Label();
            kier = new Label();
            semestr = new Label();
            indeks = new Label();
            nazw = new Label();
            imie = new Label();
            panelNaglowki.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelNaglowki
            // 
            panelNaglowki.Controls.Add(panel1);
            panelNaglowki.Controls.Add(wydz);
            panelNaglowki.Controls.Add(kier);
            panelNaglowki.Controls.Add(semestr);
            panelNaglowki.Controls.Add(indeks);
            panelNaglowki.Controls.Add(nazw);
            panelNaglowki.Controls.Add(imie);
            panelNaglowki.Dock = DockStyle.Fill;
            panelNaglowki.Location = new Point(0, 0);
            panelNaglowki.Margin = new Padding(0);
            panelNaglowki.Name = "panelNaglowki";
            panelNaglowki.Size = new Size(896, 51);
            panelNaglowki.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(checkBoxId);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(57, 51);
            panel1.TabIndex = 8;
            // 
            // checkBoxId
            // 
            checkBoxId.BackColor = Color.Silver;
            checkBoxId.CheckAlign = ContentAlignment.MiddleRight;
            checkBoxId.Dock = DockStyle.Fill;
            checkBoxId.Location = new Point(0, 0);
            checkBoxId.Margin = new Padding(0);
            checkBoxId.Name = "checkBoxId";
            checkBoxId.Size = new Size(55, 49);
            checkBoxId.TabIndex = 7;
            checkBoxId.Text = "ID";
            checkBoxId.UseVisualStyleBackColor = false;
            checkBoxId.CheckedChanged += checkBoxId_CheckedChanged;
            // 
            // wydz
            // 
            wydz.BackColor = Color.Silver;
            wydz.BorderStyle = BorderStyle.FixedSingle;
            wydz.Dock = DockStyle.Right;
            wydz.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            wydz.Location = new Point(707, 0);
            wydz.Margin = new Padding(0);
            wydz.Name = "wydz";
            wydz.Size = new Size(189, 51);
            wydz.TabIndex = 6;
            wydz.Text = "Wydział";
            wydz.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kier
            // 
            kier.BackColor = Color.Silver;
            kier.BorderStyle = BorderStyle.FixedSingle;
            kier.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            kier.Location = new Point(552, 0);
            kier.Margin = new Padding(0);
            kier.Name = "kier";
            kier.Size = new Size(155, 51);
            kier.TabIndex = 5;
            kier.Text = "Kierunek";
            kier.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // semestr
            // 
            semestr.BackColor = Color.Silver;
            semestr.BorderStyle = BorderStyle.FixedSingle;
            semestr.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            semestr.Location = new Point(459, 0);
            semestr.Margin = new Padding(0);
            semestr.Name = "semestr";
            semestr.Size = new Size(93, 51);
            semestr.TabIndex = 4;
            semestr.Text = "Semestr";
            semestr.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // indeks
            // 
            indeks.BackColor = Color.Silver;
            indeks.BorderStyle = BorderStyle.FixedSingle;
            indeks.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            indeks.Location = new Point(316, 0);
            indeks.Margin = new Padding(0);
            indeks.Name = "indeks";
            indeks.Size = new Size(143, 51);
            indeks.TabIndex = 3;
            indeks.Text = "Nr. indeksu";
            indeks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nazw
            // 
            nazw.BackColor = Color.Silver;
            nazw.BorderStyle = BorderStyle.FixedSingle;
            nazw.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nazw.Location = new Point(178, 0);
            nazw.Margin = new Padding(0);
            nazw.Name = "nazw";
            nazw.Size = new Size(138, 51);
            nazw.TabIndex = 2;
            nazw.Text = "Nazwisko";
            nazw.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imie
            // 
            imie.BackColor = Color.Silver;
            imie.BorderStyle = BorderStyle.FixedSingle;
            imie.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            imie.Location = new Point(57, 0);
            imie.Margin = new Padding(0);
            imie.Name = "imie";
            imie.Size = new Size(121, 51);
            imie.TabIndex = 1;
            imie.Text = "Imię";
            imie.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // daneWiersz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelNaglowki);
            Margin = new Padding(0);
            Name = "daneWiersz";
            Size = new Size(896, 51);
            Load += daneWiersz_Load;
            panelNaglowki.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNaglowki;
        private CheckBox checkBoxId;
        private Label wydz;
        private Label kier;
        private Label semestr;
        private Label indeks;
        private Label nazw;
        private Label imie;
        private Panel panel1;
    }
}
