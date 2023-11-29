namespace USOS_Rektora.userControls
{
    partial class WyswDanychKadra
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
            panelDane = new Panel();
            tableDane = new TableLayoutPanel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            panelFiltrowanie = new Panel();
            tabControlZarzadz = new TabControl();
            tabPage1 = new TabPage();
            panelChowaj = new Panel();
            buttonSzukaj = new Button();
            filtr2 = new ComboBox();
            baner = new Label();
            textBoxFiltr = new TextBox();
            filtr1 = new ComboBox();
            tabPage2 = new TabPage();
            buttonDodaj = new Button();
            textBoxMail = new TextBox();
            textBoxNr = new TextBox();
            textBoxMiasto = new TextBox();
            textBoxAdres = new TextBox();
            textBoxStan = new TextBox();
            textBoxNazwisko = new TextBox();
            textBoxImie = new TextBox();
            tabPage3 = new TabPage();
            panel2 = new Panel();
            panel3 = new Panel();
            buttonUsun = new Button();
            textBoxUsun = new TextBox();
            filtr2Usun = new ComboBox();
            filtr1Usun = new ComboBox();
            label9 = new Label();
            tabPage4 = new TabPage();
            iconButtonRozwijanie = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            panelDane.SuspendLayout();
            tableDane.SuspendLayout();
            panelFiltrowanie.SuspendLayout();
            tabControlZarzadz.SuspendLayout();
            tabPage1.SuspendLayout();
            panelChowaj.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelDane
            // 
            panelDane.AutoSize = true;
            panelDane.BackColor = Color.FromArgb(224, 224, 224);
            panelDane.Controls.Add(tableDane);
            panelDane.Dock = DockStyle.Fill;
            panelDane.Location = new Point(0, 0);
            panelDane.Name = "panelDane";
            panelDane.Size = new Size(681, 482);
            panelDane.TabIndex = 1;
            // 
            // tableDane
            // 
            tableDane.AutoScroll = true;
            tableDane.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableDane.ColumnCount = 8;
            tableDane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableDane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableDane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableDane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableDane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableDane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableDane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableDane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableDane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableDane.Controls.Add(label7, 0, 0);
            tableDane.Controls.Add(label6, 6, 0);
            tableDane.Controls.Add(label5, 5, 0);
            tableDane.Controls.Add(label4, 4, 0);
            tableDane.Controls.Add(label3, 3, 0);
            tableDane.Controls.Add(label2, 2, 0);
            tableDane.Controls.Add(label1, 1, 0);
            tableDane.Controls.Add(label8, 7, 0);
            tableDane.Dock = DockStyle.Fill;
            tableDane.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            tableDane.Location = new Point(0, 0);
            tableDane.Name = "tableDane";
            tableDane.RowCount = 1;
            tableDane.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableDane.Size = new Size(681, 482);
            tableDane.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Silver;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1, 1);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(40, 466);
            label7.TabIndex = 7;
            label7.Text = "ID";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Silver;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(797, 1);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(150, 466);
            label6.TabIndex = 5;
            label6.Text = "Nr. telefonu";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Silver;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(646, 1);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(150, 466);
            label5.TabIndex = 4;
            label5.Text = "Miasto";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Silver;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(495, 1);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(150, 466);
            label4.TabIndex = 3;
            label4.Text = "Adres";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(344, 1);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(150, 466);
            label3.TabIndex = 2;
            label3.Text = "Stanowisko";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(193, 1);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(150, 466);
            label2.TabIndex = 1;
            label2.Text = "Nazwisko";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(42, 1);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(150, 466);
            label1.TabIndex = 6;
            label1.Text = "Imię";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Silver;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(951, 1);
            label8.Name = "label8";
            label8.Size = new Size(144, 466);
            label8.TabIndex = 8;
            label8.Text = "Adres e-mail";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelFiltrowanie
            // 
            panelFiltrowanie.BackColor = Color.Silver;
            panelFiltrowanie.Controls.Add(tabControlZarzadz);
            panelFiltrowanie.Controls.Add(iconButtonRozwijanie);
            panelFiltrowanie.Dock = DockStyle.Left;
            panelFiltrowanie.Location = new Point(0, 0);
            panelFiltrowanie.Name = "panelFiltrowanie";
            panelFiltrowanie.Size = new Size(215, 482);
            panelFiltrowanie.TabIndex = 2;
            // 
            // tabControlZarzadz
            // 
            tabControlZarzadz.Controls.Add(tabPage1);
            tabControlZarzadz.Controls.Add(tabPage2);
            tabControlZarzadz.Controls.Add(tabPage3);
            tabControlZarzadz.Controls.Add(tabPage4);
            tabControlZarzadz.Dock = DockStyle.Fill;
            tabControlZarzadz.Location = new Point(0, 51);
            tabControlZarzadz.Margin = new Padding(0);
            tabControlZarzadz.Name = "tabControlZarzadz";
            tabControlZarzadz.SelectedIndex = 0;
            tabControlZarzadz.Size = new Size(215, 431);
            tabControlZarzadz.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panelChowaj);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(207, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Filtrowanie";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelChowaj
            // 
            panelChowaj.BackColor = Color.Silver;
            panelChowaj.Controls.Add(buttonSzukaj);
            panelChowaj.Controls.Add(filtr2);
            panelChowaj.Controls.Add(baner);
            panelChowaj.Controls.Add(textBoxFiltr);
            panelChowaj.Controls.Add(filtr1);
            panelChowaj.Dock = DockStyle.Fill;
            panelChowaj.Location = new Point(3, 3);
            panelChowaj.Margin = new Padding(0);
            panelChowaj.Name = "panelChowaj";
            panelChowaj.Size = new Size(201, 392);
            panelChowaj.TabIndex = 9;
            // 
            // buttonSzukaj
            // 
            buttonSzukaj.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSzukaj.Location = new Point(0, 208);
            buttonSzukaj.Name = "buttonSzukaj";
            buttonSzukaj.Size = new Size(201, 41);
            buttonSzukaj.TabIndex = 7;
            buttonSzukaj.Text = "Szukaj";
            buttonSzukaj.TextAlign = ContentAlignment.TopCenter;
            buttonSzukaj.UseVisualStyleBackColor = true;
            // 
            // filtr2
            // 
            filtr2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            filtr2.FormattingEnabled = true;
            filtr2.Items.AddRange(new object[] { "równego", "zaczynającego się na" });
            filtr2.Location = new Point(0, 91);
            filtr2.Name = "filtr2";
            filtr2.Size = new Size(202, 36);
            filtr2.TabIndex = 5;
            // 
            // baner
            // 
            baner.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            baner.ForeColor = Color.White;
            baner.Location = new Point(0, 0);
            baner.Name = "baner";
            baner.Size = new Size(191, 30);
            baner.TabIndex = 3;
            baner.Text = "Dla";
            baner.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxFiltr
            // 
            textBoxFiltr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFiltr.Location = new Point(-3, 151);
            textBoxFiltr.Name = "textBoxFiltr";
            textBoxFiltr.Size = new Size(204, 34);
            textBoxFiltr.TabIndex = 6;
            // 
            // filtr1
            // 
            filtr1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            filtr1.FormattingEnabled = true;
            filtr1.Items.AddRange(new object[] { "imiona", "nazwiska", "stanowiska", "adresu" });
            filtr1.Location = new Point(0, 33);
            filtr1.Name = "filtr1";
            filtr1.Size = new Size(202, 36);
            filtr1.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Silver;
            tabPage2.Controls.Add(buttonDodaj);
            tabPage2.Controls.Add(textBoxMail);
            tabPage2.Controls.Add(textBoxNr);
            tabPage2.Controls.Add(textBoxMiasto);
            tabPage2.Controls.Add(textBoxAdres);
            tabPage2.Controls.Add(textBoxStan);
            tabPage2.Controls.Add(textBoxNazwisko);
            tabPage2.Controls.Add(textBoxImie);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(0);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(207, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dodaj";
            // 
            // buttonDodaj
            // 
            buttonDodaj.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDodaj.Location = new Point(-1, 356);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(210, 39);
            buttonDodaj.TabIndex = 7;
            buttonDodaj.Text = "Dodaj";
            buttonDodaj.UseVisualStyleBackColor = true;
            // 
            // textBoxMail
            // 
            textBoxMail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMail.Location = new Point(0, 309);
            textBoxMail.Margin = new Padding(0, 20, 0, 0);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(208, 31);
            textBoxMail.TabIndex = 6;
            textBoxMail.Text = "Adres e-mail";
            textBoxMail.Enter += textBoxMail_Enter;
            textBoxMail.Leave += textBoxMail_Leave;
            // 
            // textBoxNr
            // 
            textBoxNr.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNr.Location = new Point(-4, 258);
            textBoxNr.Margin = new Padding(0, 20, 0, 0);
            textBoxNr.Name = "textBoxNr";
            textBoxNr.Size = new Size(211, 31);
            textBoxNr.TabIndex = 5;
            textBoxNr.Text = "Nr. telefonu";
            textBoxNr.Enter += textBoxNr_Enter;
            textBoxNr.Leave += textBoxNr_Leave;
            // 
            // textBoxMiasto
            // 
            textBoxMiasto.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMiasto.Location = new Point(-4, 207);
            textBoxMiasto.Margin = new Padding(0, 20, 0, 0);
            textBoxMiasto.Name = "textBoxMiasto";
            textBoxMiasto.Size = new Size(212, 31);
            textBoxMiasto.TabIndex = 4;
            textBoxMiasto.Text = "Miasto";
            textBoxMiasto.Enter += textBoxMiasto_Enter;
            textBoxMiasto.Leave += textBoxMiasto_Leave;
            // 
            // textBoxAdres
            // 
            textBoxAdres.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAdres.Location = new Point(0, 156);
            textBoxAdres.Margin = new Padding(0, 20, 0, 0);
            textBoxAdres.Name = "textBoxAdres";
            textBoxAdres.Size = new Size(207, 31);
            textBoxAdres.TabIndex = 3;
            textBoxAdres.Text = "Adres";
            textBoxAdres.Enter += textBoxAdres_Enter;
            textBoxAdres.Leave += textBoxAdres_Leave;
            // 
            // textBoxStan
            // 
            textBoxStan.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxStan.Location = new Point(0, 105);
            textBoxStan.Margin = new Padding(0, 20, 0, 0);
            textBoxStan.Name = "textBoxStan";
            textBoxStan.Size = new Size(207, 31);
            textBoxStan.TabIndex = 2;
            textBoxStan.Text = "Stanowisko";
            textBoxStan.Enter += textBoxStan_Enter;
            textBoxStan.Leave += textBoxStan_Leave;
            // 
            // textBoxNazwisko
            // 
            textBoxNazwisko.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNazwisko.Location = new Point(0, 54);
            textBoxNazwisko.Margin = new Padding(0, 20, 0, 0);
            textBoxNazwisko.Name = "textBoxNazwisko";
            textBoxNazwisko.Size = new Size(208, 31);
            textBoxNazwisko.TabIndex = 1;
            textBoxNazwisko.Text = "Nazwisko";
            textBoxNazwisko.Enter += textBoxNazwisko_Enter;
            textBoxNazwisko.Leave += textBoxNazwisko_Leave;
            // 
            // textBoxImie
            // 
            textBoxImie.Dock = DockStyle.Top;
            textBoxImie.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxImie.Location = new Point(0, 0);
            textBoxImie.Margin = new Padding(0);
            textBoxImie.Name = "textBoxImie";
            textBoxImie.Size = new Size(207, 31);
            textBoxImie.TabIndex = 0;
            textBoxImie.Text = "Imię";
            textBoxImie.Enter += textBoxImie_Enter;
            textBoxImie.Leave += textBoxImie_Leave;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(panel2);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(207, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Usuń";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(207, 398);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(buttonUsun);
            panel3.Controls.Add(textBoxUsun);
            panel3.Controls.Add(filtr2Usun);
            panel3.Controls.Add(filtr1Usun);
            panel3.Controls.Add(label9);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(207, 398);
            panel3.TabIndex = 0;
            // 
            // buttonUsun
            // 
            buttonUsun.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUsun.Location = new Point(4, 191);
            buttonUsun.Name = "buttonUsun";
            buttonUsun.Size = new Size(200, 36);
            buttonUsun.TabIndex = 8;
            buttonUsun.Text = "Usuń";
            buttonUsun.UseVisualStyleBackColor = true;
            // 
            // textBoxUsun
            // 
            textBoxUsun.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsun.Location = new Point(4, 140);
            textBoxUsun.Name = "textBoxUsun";
            textBoxUsun.Size = new Size(201, 31);
            textBoxUsun.TabIndex = 7;
            // 
            // filtr2Usun
            // 
            filtr2Usun.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            filtr2Usun.FormattingEnabled = true;
            filtr2Usun.Items.AddRange(new object[] { "równym", "zaczynającym się na" });
            filtr2Usun.Location = new Point(3, 85);
            filtr2Usun.Name = "filtr2Usun";
            filtr2Usun.Size = new Size(201, 33);
            filtr2Usun.TabIndex = 6;
            // 
            // filtr1Usun
            // 
            filtr1Usun.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            filtr1Usun.FormattingEnabled = true;
            filtr1Usun.Items.AddRange(new object[] { "ID", "Imieniu", "Nazwisku", "Stanowisku" });
            filtr1Usun.Location = new Point(3, 33);
            filtr1Usun.Name = "filtr1Usun";
            filtr1Usun.Size = new Size(201, 33);
            filtr1Usun.TabIndex = 5;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(202, 30);
            label9.TabIndex = 4;
            label9.Text = "Usuń członka kadry o";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            label9.Click += label9_Click;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(207, 398);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Modyfikuj";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // iconButtonRozwijanie
            // 
            iconButtonRozwijanie.BackColor = Color.Silver;
            iconButtonRozwijanie.Dock = DockStyle.Top;
            iconButtonRozwijanie.FlatStyle = FlatStyle.Flat;
            iconButtonRozwijanie.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonRozwijanie.ForeColor = Color.White;
            iconButtonRozwijanie.IconChar = FontAwesome.Sharp.IconChar.CircleArrowRight;
            iconButtonRozwijanie.IconColor = Color.White;
            iconButtonRozwijanie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonRozwijanie.IconSize = 40;
            iconButtonRozwijanie.ImageAlign = ContentAlignment.MiddleRight;
            iconButtonRozwijanie.Location = new Point(0, 0);
            iconButtonRozwijanie.Name = "iconButtonRozwijanie";
            iconButtonRozwijanie.Rotation = 180D;
            iconButtonRozwijanie.Size = new Size(215, 51);
            iconButtonRozwijanie.TabIndex = 4;
            iconButtonRozwijanie.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonRozwijanie.UseVisualStyleBackColor = false;
            iconButtonRozwijanie.Click += iconButtonRozwijanie_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panelDane);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(215, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(681, 482);
            panel1.TabIndex = 3;
            // 
            // WyswDanychKadra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panelFiltrowanie);
            Name = "WyswDanychKadra";
            Size = new Size(896, 482);
            Load += WyswDanych_Load;
            panelDane.ResumeLayout(false);
            tableDane.ResumeLayout(false);
            tableDane.PerformLayout();
            panelFiltrowanie.ResumeLayout(false);
            tabControlZarzadz.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panelChowaj.ResumeLayout(false);
            panelChowaj.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelDane;
        private TableLayoutPanel tableDane;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label1;
        private Label label8;
        private Panel panelFiltrowanie;
        private TabControl tabControlZarzadz;
        private TabPage tabPage1;
        private Panel panelChowaj;
        private Button buttonSzukaj;
        private ComboBox filtr2;
        private Label baner;
        private TextBox textBoxFiltr;
        private ComboBox filtr1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private FontAwesome.Sharp.IconButton iconButtonRozwijanie;
        private TextBox textBoxImie;
        private TextBox textBoxNazwisko;
        private TextBox textBoxMiasto;
        private TextBox textBoxAdres;
        private TextBox textBoxStan;
        private TextBox textBoxMail;
        private TextBox textBoxNr;
        private Button buttonDodaj;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label9;
        private ComboBox filtr1Usun;
        private ComboBox filtr2Usun;
        private Button buttonUsun;
        private TextBox textBoxUsun;
        private TabPage tabPage4;
    }
}
