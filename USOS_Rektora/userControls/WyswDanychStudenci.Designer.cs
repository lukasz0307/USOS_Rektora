namespace USOS_Rektora.userControls
{
    partial class WyswDanychStudenci
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
            flowLayoutPanelDane = new FlowLayoutPanel();
            panelNaglowki = new Panel();
            labelWydz = new Label();
            labelKierunek = new Label();
            labelTel = new Label();
            labelStan = new Label();
            labelNazw = new Label();
            labelImie = new Label();
            labelId = new Label();
            panelObsluga = new Panel();
            panel1 = new Panel();
            tabControlZarz = new TabControl();
            tabPage4 = new TabPage();
            tabPage1 = new TabPage();
            comboBoxKier = new ComboBox();
            comboBoxWydz = new ComboBox();
            comboBoxSem = new ComboBox();
            Dodaj = new FontAwesome.Sharp.IconButton();
            textBoxIndeks = new TextBox();
            textBoxNazw = new TextBox();
            textBoxImie = new TextBox();
            tabPage2 = new TabPage();
            usun = new FontAwesome.Sharp.IconButton();
            tabPage3 = new TabPage();
            Modyfikuj = new FontAwesome.Sharp.IconButton();
            textBoxNowaWart = new TextBox();
            label1 = new Label();
            comboBoxMod = new ComboBox();
            panel2 = new Panel();
            iconButtonMod = new FontAwesome.Sharp.IconButton();
            iconButtonUsun = new FontAwesome.Sharp.IconButton();
            iconButtonDodaj = new FontAwesome.Sharp.IconButton();
            iconButtonZwin = new FontAwesome.Sharp.IconButton();
            panelNaglowki.SuspendLayout();
            panelObsluga.SuspendLayout();
            panel1.SuspendLayout();
            tabControlZarz.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelDane
            // 
            flowLayoutPanelDane.AutoScroll = true;
            flowLayoutPanelDane.Location = new Point(0, 51);
            flowLayoutPanelDane.Margin = new Padding(0);
            flowLayoutPanelDane.Name = "flowLayoutPanelDane";
            flowLayoutPanelDane.Size = new Size(924, 278);
            flowLayoutPanelDane.TabIndex = 0;
            // 
            // panelNaglowki
            // 
            panelNaglowki.BackColor = Color.Gray;
            panelNaglowki.Controls.Add(labelWydz);
            panelNaglowki.Controls.Add(labelKierunek);
            panelNaglowki.Controls.Add(labelTel);
            panelNaglowki.Controls.Add(labelStan);
            panelNaglowki.Controls.Add(labelNazw);
            panelNaglowki.Controls.Add(labelImie);
            panelNaglowki.Controls.Add(labelId);
            panelNaglowki.Dock = DockStyle.Top;
            panelNaglowki.Location = new Point(0, 0);
            panelNaglowki.Margin = new Padding(0);
            panelNaglowki.Name = "panelNaglowki";
            panelNaglowki.Size = new Size(896, 51);
            panelNaglowki.TabIndex = 2;
            // 
            // labelWydz
            // 
            labelWydz.BackColor = Color.Gray;
            labelWydz.BorderStyle = BorderStyle.FixedSingle;
            labelWydz.Dock = DockStyle.Left;
            labelWydz.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelWydz.Location = new Point(707, 0);
            labelWydz.Margin = new Padding(0);
            labelWydz.Name = "labelWydz";
            labelWydz.Size = new Size(189, 51);
            labelWydz.TabIndex = 6;
            labelWydz.Text = "Wydział";
            labelWydz.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelKierunek
            // 
            labelKierunek.BackColor = Color.Gray;
            labelKierunek.BorderStyle = BorderStyle.FixedSingle;
            labelKierunek.Dock = DockStyle.Left;
            labelKierunek.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelKierunek.Location = new Point(552, 0);
            labelKierunek.Margin = new Padding(0);
            labelKierunek.Name = "labelKierunek";
            labelKierunek.Size = new Size(155, 51);
            labelKierunek.TabIndex = 5;
            labelKierunek.Text = "Kierunek";
            labelKierunek.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTel
            // 
            labelTel.BackColor = Color.Gray;
            labelTel.BorderStyle = BorderStyle.FixedSingle;
            labelTel.Dock = DockStyle.Left;
            labelTel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTel.Location = new Point(459, 0);
            labelTel.Margin = new Padding(0);
            labelTel.Name = "labelTel";
            labelTel.Size = new Size(93, 51);
            labelTel.TabIndex = 4;
            labelTel.Text = "Semestr";
            labelTel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelStan
            // 
            labelStan.BackColor = Color.Gray;
            labelStan.BorderStyle = BorderStyle.FixedSingle;
            labelStan.Dock = DockStyle.Left;
            labelStan.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelStan.Location = new Point(316, 0);
            labelStan.Margin = new Padding(0);
            labelStan.Name = "labelStan";
            labelStan.Size = new Size(143, 51);
            labelStan.TabIndex = 3;
            labelStan.Text = "Nr. indeksu";
            labelStan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNazw
            // 
            labelNazw.BackColor = Color.Gray;
            labelNazw.BorderStyle = BorderStyle.FixedSingle;
            labelNazw.Dock = DockStyle.Left;
            labelNazw.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelNazw.Location = new Point(178, 0);
            labelNazw.Margin = new Padding(0);
            labelNazw.Name = "labelNazw";
            labelNazw.Size = new Size(138, 51);
            labelNazw.TabIndex = 2;
            labelNazw.Text = "Nazwisko";
            labelNazw.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelImie
            // 
            labelImie.BackColor = Color.Gray;
            labelImie.BorderStyle = BorderStyle.FixedSingle;
            labelImie.Dock = DockStyle.Left;
            labelImie.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelImie.Location = new Point(57, 0);
            labelImie.Margin = new Padding(0);
            labelImie.Name = "labelImie";
            labelImie.Size = new Size(121, 51);
            labelImie.TabIndex = 1;
            labelImie.Text = "Imię";
            labelImie.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelId
            // 
            labelId.BackColor = Color.Gray;
            labelId.BorderStyle = BorderStyle.FixedSingle;
            labelId.Dock = DockStyle.Left;
            labelId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelId.Location = new Point(0, 0);
            labelId.Margin = new Padding(0);
            labelId.Name = "labelId";
            labelId.Size = new Size(57, 51);
            labelId.TabIndex = 0;
            labelId.Text = "ID";
            labelId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelObsluga
            // 
            panelObsluga.Controls.Add(panel1);
            panelObsluga.Controls.Add(iconButtonZwin);
            panelObsluga.Dock = DockStyle.Bottom;
            panelObsluga.Location = new Point(0, 329);
            panelObsluga.Margin = new Padding(0);
            panelObsluga.Name = "panelObsluga";
            panelObsluga.Size = new Size(896, 153);
            panelObsluga.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControlZarz);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 109);
            panel1.TabIndex = 3;
            // 
            // tabControlZarz
            // 
            tabControlZarz.Controls.Add(tabPage4);
            tabControlZarz.Controls.Add(tabPage1);
            tabControlZarz.Controls.Add(tabPage2);
            tabControlZarz.Controls.Add(tabPage3);
            tabControlZarz.Dock = DockStyle.Fill;
            tabControlZarz.ItemSize = new Size(0, 1);
            tabControlZarz.Location = new Point(99, 0);
            tabControlZarz.Margin = new Padding(0);
            tabControlZarz.Name = "tabControlZarz";
            tabControlZarz.Padding = new Point(0, 0);
            tabControlZarz.SelectedIndex = 0;
            tabControlZarz.Size = new Size(797, 109);
            tabControlZarz.SizeMode = TabSizeMode.Fixed;
            tabControlZarz.TabIndex = 3;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.Silver;
            tabPage4.Location = new Point(4, 5);
            tabPage4.Margin = new Padding(0);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(789, 100);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Silver;
            tabPage1.Controls.Add(comboBoxKier);
            tabPage1.Controls.Add(comboBoxWydz);
            tabPage1.Controls.Add(comboBoxSem);
            tabPage1.Controls.Add(Dodaj);
            tabPage1.Controls.Add(textBoxIndeks);
            tabPage1.Controls.Add(textBoxNazw);
            tabPage1.Controls.Add(textBoxImie);
            tabPage1.Location = new Point(4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(789, 100);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // comboBoxKier
            // 
            comboBoxKier.Anchor = AnchorStyles.None;
            comboBoxKier.Enabled = false;
            comboBoxKier.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxKier.FormattingEnabled = true;
            comboBoxKier.Location = new Point(660, 11);
            comboBoxKier.Margin = new Padding(5, 3, 3, 3);
            comboBoxKier.Name = "comboBoxKier";
            comboBoxKier.Size = new Size(123, 33);
            comboBoxKier.TabIndex = 9;
            comboBoxKier.Text = "Kierunek";
            // 
            // comboBoxWydz
            // 
            comboBoxWydz.Anchor = AnchorStyles.None;
            comboBoxWydz.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxWydz.FormattingEnabled = true;
            comboBoxWydz.Items.AddRange(new object[] { "Elektryczny", "Nawigacyjny", "Mechaniczny", "Zarządzania i nauk o jakości" });
            comboBoxWydz.Location = new Point(529, 11);
            comboBoxWydz.Margin = new Padding(5, 3, 3, 3);
            comboBoxWydz.Name = "comboBoxWydz";
            comboBoxWydz.Size = new Size(123, 33);
            comboBoxWydz.TabIndex = 8;
            comboBoxWydz.Text = "Wydział";
            comboBoxWydz.SelectedIndexChanged += comboBoxWydz_SelectedIndexChanged;
            // 
            // comboBoxSem
            // 
            comboBoxSem.Anchor = AnchorStyles.None;
            comboBoxSem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSem.FormattingEnabled = true;
            comboBoxSem.Items.AddRange(new object[] { "I", "II", "III", "IV", "V", "VI", "VII" });
            comboBoxSem.Location = new Point(398, 11);
            comboBoxSem.Margin = new Padding(5, 3, 3, 3);
            comboBoxSem.Name = "comboBoxSem";
            comboBoxSem.Size = new Size(123, 33);
            comboBoxSem.TabIndex = 7;
            comboBoxSem.Text = "Semestr";
            // 
            // Dodaj
            // 
            Dodaj.Anchor = AnchorStyles.None;
            Dodaj.BackColor = Color.FromArgb(192, 255, 192);
            Dodaj.FlatStyle = FlatStyle.Flat;
            Dodaj.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Dodaj.ForeColor = Color.FromArgb(0, 192, 0);
            Dodaj.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            Dodaj.IconColor = Color.FromArgb(0, 192, 0);
            Dodaj.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Dodaj.IconSize = 30;
            Dodaj.ImageAlign = ContentAlignment.MiddleRight;
            Dodaj.Location = new Point(300, 57);
            Dodaj.Margin = new Padding(0);
            Dodaj.Name = "Dodaj";
            Dodaj.Size = new Size(99, 36);
            Dodaj.TabIndex = 6;
            Dodaj.Text = "Dodaj";
            Dodaj.TextAlign = ContentAlignment.MiddleLeft;
            Dodaj.UseVisualStyleBackColor = false;
            Dodaj.Click += Dodaj_Click;
            // 
            // textBoxIndeks
            // 
            textBoxIndeks.Anchor = AnchorStyles.None;
            textBoxIndeks.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIndeks.Location = new Point(267, 11);
            textBoxIndeks.Margin = new Padding(5, 3, 3, 3);
            textBoxIndeks.Name = "textBoxIndeks";
            textBoxIndeks.PlaceholderText = "Nr. indeksu";
            textBoxIndeks.Size = new Size(123, 31);
            textBoxIndeks.TabIndex = 2;
            // 
            // textBoxNazw
            // 
            textBoxNazw.Anchor = AnchorStyles.None;
            textBoxNazw.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNazw.Location = new Point(136, 11);
            textBoxNazw.Margin = new Padding(5, 3, 3, 3);
            textBoxNazw.Name = "textBoxNazw";
            textBoxNazw.PlaceholderText = "Nazwisko";
            textBoxNazw.Size = new Size(123, 31);
            textBoxNazw.TabIndex = 1;
            // 
            // textBoxImie
            // 
            textBoxImie.Anchor = AnchorStyles.None;
            textBoxImie.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxImie.Location = new Point(5, 11);
            textBoxImie.Margin = new Padding(5, 3, 3, 3);
            textBoxImie.Name = "textBoxImie";
            textBoxImie.PlaceholderText = "Imię";
            textBoxImie.Size = new Size(123, 31);
            textBoxImie.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Silver;
            tabPage2.Controls.Add(usun);
            tabPage2.Location = new Point(4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(789, 100);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // usun
            // 
            usun.Anchor = AnchorStyles.None;
            usun.BackColor = Color.FromArgb(255, 128, 128);
            usun.FlatStyle = FlatStyle.Flat;
            usun.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            usun.ForeColor = Color.Red;
            usun.IconChar = FontAwesome.Sharp.IconChar.Trash;
            usun.IconColor = Color.Red;
            usun.IconFont = FontAwesome.Sharp.IconFont.Auto;
            usun.IconSize = 30;
            usun.ImageAlign = ContentAlignment.MiddleRight;
            usun.Location = new Point(298, 36);
            usun.Margin = new Padding(0);
            usun.Name = "usun";
            usun.Size = new Size(99, 36);
            usun.TabIndex = 2;
            usun.Text = "Usuń";
            usun.TextAlign = ContentAlignment.MiddleLeft;
            usun.UseVisualStyleBackColor = false;
            usun.Click += usun_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Silver;
            tabPage3.Controls.Add(Modyfikuj);
            tabPage3.Controls.Add(textBoxNowaWart);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(comboBoxMod);
            tabPage3.Location = new Point(4, 5);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(789, 100);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            // 
            // Modyfikuj
            // 
            Modyfikuj.Anchor = AnchorStyles.None;
            Modyfikuj.BackColor = Color.LightSkyBlue;
            Modyfikuj.FlatStyle = FlatStyle.Flat;
            Modyfikuj.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Modyfikuj.ForeColor = Color.MidnightBlue;
            Modyfikuj.IconChar = FontAwesome.Sharp.IconChar.Pen;
            Modyfikuj.IconColor = Color.MidnightBlue;
            Modyfikuj.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Modyfikuj.IconSize = 30;
            Modyfikuj.ImageAlign = ContentAlignment.MiddleRight;
            Modyfikuj.Location = new Point(600, 27);
            Modyfikuj.Margin = new Padding(0);
            Modyfikuj.Name = "Modyfikuj";
            Modyfikuj.Size = new Size(130, 34);
            Modyfikuj.TabIndex = 3;
            Modyfikuj.Text = "Modyfikuj";
            Modyfikuj.TextAlign = ContentAlignment.MiddleLeft;
            Modyfikuj.UseVisualStyleBackColor = false;
            Modyfikuj.Click += Modyfikuj_Click;
            // 
            // textBoxNowaWart
            // 
            textBoxNowaWart.Anchor = AnchorStyles.None;
            textBoxNowaWart.Enabled = false;
            textBoxNowaWart.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNowaWart.Location = new Point(432, 30);
            textBoxNowaWart.Margin = new Padding(20, 3, 3, 3);
            textBoxNowaWart.Name = "textBoxNowaWart";
            textBoxNowaWart.PlaceholderText = "Nowa wartość";
            textBoxNowaWart.Size = new Size(151, 31);
            textBoxNowaWart.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 33);
            label1.Margin = new Padding(20, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(212, 25);
            label1.TabIndex = 1;
            label1.Text = "Wybierz co modyfikować";
            // 
            // comboBoxMod
            // 
            comboBoxMod.Anchor = AnchorStyles.None;
            comboBoxMod.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxMod.FormattingEnabled = true;
            comboBoxMod.Items.AddRange(new object[] { "Imię", "Nazwisko", "Nr. Indeksu", "Semestr", "Kierunek", "Adres e-mail" });
            comboBoxMod.Location = new Point(258, 30);
            comboBoxMod.Margin = new Padding(20, 3, 3, 3);
            comboBoxMod.Name = "comboBoxMod";
            comboBoxMod.Size = new Size(151, 33);
            comboBoxMod.TabIndex = 0;
            comboBoxMod.SelectedIndexChanged += comboBoxMod_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconButtonMod);
            panel2.Controls.Add(iconButtonUsun);
            panel2.Controls.Add(iconButtonDodaj);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(99, 109);
            panel2.TabIndex = 1;
            // 
            // iconButtonMod
            // 
            iconButtonMod.BackColor = Color.LightSkyBlue;
            iconButtonMod.Dock = DockStyle.Top;
            iconButtonMod.FlatStyle = FlatStyle.Flat;
            iconButtonMod.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonMod.ForeColor = Color.MidnightBlue;
            iconButtonMod.IconChar = FontAwesome.Sharp.IconChar.Pen;
            iconButtonMod.IconColor = Color.MidnightBlue;
            iconButtonMod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonMod.IconSize = 30;
            iconButtonMod.ImageAlign = ContentAlignment.MiddleRight;
            iconButtonMod.Location = new Point(0, 72);
            iconButtonMod.Margin = new Padding(0);
            iconButtonMod.Name = "iconButtonMod";
            iconButtonMod.Size = new Size(99, 37);
            iconButtonMod.TabIndex = 2;
            iconButtonMod.Text = "Mod.";
            iconButtonMod.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonMod.UseVisualStyleBackColor = false;
            iconButtonMod.Click += iconButtonMod_Click;
            // 
            // iconButtonUsun
            // 
            iconButtonUsun.BackColor = Color.FromArgb(255, 128, 128);
            iconButtonUsun.Dock = DockStyle.Top;
            iconButtonUsun.FlatStyle = FlatStyle.Flat;
            iconButtonUsun.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonUsun.ForeColor = Color.Red;
            iconButtonUsun.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconButtonUsun.IconColor = Color.Red;
            iconButtonUsun.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonUsun.IconSize = 30;
            iconButtonUsun.ImageAlign = ContentAlignment.MiddleRight;
            iconButtonUsun.Location = new Point(0, 36);
            iconButtonUsun.Margin = new Padding(0);
            iconButtonUsun.Name = "iconButtonUsun";
            iconButtonUsun.Size = new Size(99, 36);
            iconButtonUsun.TabIndex = 1;
            iconButtonUsun.Text = "Usuń";
            iconButtonUsun.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonUsun.UseVisualStyleBackColor = false;
            iconButtonUsun.Click += iconButtonUsun_Click;
            // 
            // iconButtonDodaj
            // 
            iconButtonDodaj.BackColor = Color.FromArgb(192, 255, 192);
            iconButtonDodaj.Dock = DockStyle.Top;
            iconButtonDodaj.FlatStyle = FlatStyle.Flat;
            iconButtonDodaj.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonDodaj.ForeColor = Color.FromArgb(0, 192, 0);
            iconButtonDodaj.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            iconButtonDodaj.IconColor = Color.FromArgb(0, 192, 0);
            iconButtonDodaj.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonDodaj.IconSize = 30;
            iconButtonDodaj.ImageAlign = ContentAlignment.MiddleRight;
            iconButtonDodaj.Location = new Point(0, 0);
            iconButtonDodaj.Margin = new Padding(0);
            iconButtonDodaj.Name = "iconButtonDodaj";
            iconButtonDodaj.Size = new Size(99, 36);
            iconButtonDodaj.TabIndex = 0;
            iconButtonDodaj.Text = "Dodaj";
            iconButtonDodaj.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonDodaj.UseVisualStyleBackColor = false;
            iconButtonDodaj.Click += iconButtonDodaj_Click;
            // 
            // iconButtonZwin
            // 
            iconButtonZwin.BackColor = Color.Gray;
            iconButtonZwin.Dock = DockStyle.Top;
            iconButtonZwin.FlatStyle = FlatStyle.Flat;
            iconButtonZwin.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleUp;
            iconButtonZwin.IconColor = Color.White;
            iconButtonZwin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonZwin.IconSize = 40;
            iconButtonZwin.Location = new Point(0, 0);
            iconButtonZwin.Margin = new Padding(0);
            iconButtonZwin.Name = "iconButtonZwin";
            iconButtonZwin.Size = new Size(896, 44);
            iconButtonZwin.TabIndex = 2;
            iconButtonZwin.UseVisualStyleBackColor = false;
            iconButtonZwin.Click += iconButtonZwin_Click;
            // 
            // WyswDanychStudenci
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelObsluga);
            Controls.Add(panelNaglowki);
            Controls.Add(flowLayoutPanelDane);
            Name = "WyswDanychStudenci";
            Size = new Size(896, 482);
            Load += WyswDanychStudenci_Load;
            panelNaglowki.ResumeLayout(false);
            panelObsluga.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabControlZarz.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelDane;
        private Panel panelNaglowki;
        private Label labelKierunek;
        private Label labelTel;
        private Label labelStan;
        private Label labelNazw;
        private Label labelImie;
        private Label labelId;
        private Panel panelObsluga;
        private Label labelWydz;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButtonDodaj;
        private FontAwesome.Sharp.IconButton iconButtonZwin;
        private FontAwesome.Sharp.IconButton iconButtonMod;
        private FontAwesome.Sharp.IconButton iconButtonUsun;
        private TabControl tabControlZarz;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox textBoxImie;
        private TextBox textBoxIndeks;
        private TextBox textBoxNazw;
        private FontAwesome.Sharp.IconButton Dodaj;
        private FontAwesome.Sharp.IconButton usun;
        private ComboBox comboBoxMod;
        private FontAwesome.Sharp.IconButton Modyfikuj;
        private TextBox textBoxNowaWart;
        private Label label1;
        private Panel panel1;
        private TabPage tabPage4;
        private ComboBox comboBoxSem;
        private ComboBox comboBoxWydz;
        private ComboBox comboBoxKier;
    }
}
