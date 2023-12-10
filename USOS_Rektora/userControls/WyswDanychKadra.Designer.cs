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
            components = new System.ComponentModel.Container();
            panelDane = new Panel();
            panel4 = new Panel();
            labelMail = new Label();
            labelTel = new Label();
            labelStan = new Label();
            labelNazw = new Label();
            labelImie = new Label();
            labelId = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
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
            timerMenu = new System.Windows.Forms.Timer(components);
            panelDane.SuspendLayout();
            panel4.SuspendLayout();
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
            panelDane.Controls.Add(panel4);
            panelDane.Controls.Add(flowLayoutPanel1);
            panelDane.Dock = DockStyle.Fill;
            panelDane.Location = new Point(0, 0);
            panelDane.Margin = new Padding(3, 2, 3, 2);
            panelDane.Name = "panelDane";
            panelDane.Size = new Size(596, 362);
            panelDane.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(labelMail);
            panel4.Controls.Add(labelTel);
            panel4.Controls.Add(labelStan);
            panel4.Controls.Add(labelNazw);
            panel4.Controls.Add(labelImie);
            panel4.Controls.Add(labelId);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(596, 38);
            panel4.TabIndex = 1;
            // 
            // labelMail
            // 
            labelMail.BackColor = Color.Gray;
            labelMail.BorderStyle = BorderStyle.FixedSingle;
            labelMail.Dock = DockStyle.Left;
            labelMail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelMail.Location = new Point(453, 0);
            labelMail.Margin = new Padding(0);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(143, 38);
            labelMail.TabIndex = 5;
            labelMail.Text = "Adres e-mail";
            labelMail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTel
            // 
            labelTel.BackColor = Color.Gray;
            labelTel.BorderStyle = BorderStyle.FixedSingle;
            labelTel.Dock = DockStyle.Left;
            labelTel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTel.Location = new Point(328, 0);
            labelTel.Margin = new Padding(0);
            labelTel.Name = "labelTel";
            labelTel.Size = new Size(125, 38);
            labelTel.TabIndex = 4;
            labelTel.Text = "Nr. tel.";
            labelTel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelStan
            // 
            labelStan.BackColor = Color.Gray;
            labelStan.BorderStyle = BorderStyle.FixedSingle;
            labelStan.Dock = DockStyle.Left;
            labelStan.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelStan.Location = new Point(234, 0);
            labelStan.Margin = new Padding(0);
            labelStan.Name = "labelStan";
            labelStan.Size = new Size(94, 38);
            labelStan.TabIndex = 3;
            labelStan.Text = "Stanowisko";
            labelStan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNazw
            // 
            labelNazw.BackColor = Color.Gray;
            labelNazw.BorderStyle = BorderStyle.FixedSingle;
            labelNazw.Dock = DockStyle.Left;
            labelNazw.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelNazw.Location = new Point(130, 0);
            labelNazw.Margin = new Padding(0);
            labelNazw.Name = "labelNazw";
            labelNazw.Size = new Size(104, 38);
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
            labelImie.Location = new Point(44, 0);
            labelImie.Margin = new Padding(0);
            labelImie.Name = "labelImie";
            labelImie.Size = new Size(86, 38);
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
            labelId.Size = new Size(44, 38);
            labelId.TabIndex = 0;
            labelId.Text = "ID";
            labelId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Location = new Point(0, 38);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(596, 324);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panelFiltrowanie
            // 
            panelFiltrowanie.BackColor = Color.Gray;
            panelFiltrowanie.Controls.Add(tabControlZarzadz);
            panelFiltrowanie.Controls.Add(iconButtonRozwijanie);
            panelFiltrowanie.Dock = DockStyle.Left;
            panelFiltrowanie.Location = new Point(0, 0);
            panelFiltrowanie.Margin = new Padding(0);
            panelFiltrowanie.Name = "panelFiltrowanie";
            panelFiltrowanie.Size = new Size(188, 362);
            panelFiltrowanie.TabIndex = 2;
            // 
            // tabControlZarzadz
            // 
            tabControlZarzadz.Controls.Add(tabPage1);
            tabControlZarzadz.Controls.Add(tabPage2);
            tabControlZarzadz.Controls.Add(tabPage3);
            tabControlZarzadz.Controls.Add(tabPage4);
            tabControlZarzadz.Dock = DockStyle.Fill;
            tabControlZarzadz.Location = new Point(0, 38);
            tabControlZarzadz.Margin = new Padding(0);
            tabControlZarzadz.Name = "tabControlZarzadz";
            tabControlZarzadz.SelectedIndex = 0;
            tabControlZarzadz.Size = new Size(188, 324);
            tabControlZarzadz.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panelChowaj);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(180, 296);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Filtrowanie";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelChowaj
            // 
            panelChowaj.BackColor = Color.Gray;
            panelChowaj.Controls.Add(buttonSzukaj);
            panelChowaj.Controls.Add(filtr2);
            panelChowaj.Controls.Add(baner);
            panelChowaj.Controls.Add(textBoxFiltr);
            panelChowaj.Controls.Add(filtr1);
            panelChowaj.Dock = DockStyle.Fill;
            panelChowaj.Location = new Point(3, 2);
            panelChowaj.Margin = new Padding(0);
            panelChowaj.Name = "panelChowaj";
            panelChowaj.Size = new Size(174, 292);
            panelChowaj.TabIndex = 9;
            // 
            // buttonSzukaj
            // 
            buttonSzukaj.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSzukaj.Location = new Point(0, 156);
            buttonSzukaj.Margin = new Padding(3, 2, 3, 2);
            buttonSzukaj.Name = "buttonSzukaj";
            buttonSzukaj.Size = new Size(176, 31);
            buttonSzukaj.TabIndex = 7;
            buttonSzukaj.Text = "Sukaj";
            buttonSzukaj.TextAlign = ContentAlignment.TopCenter;
            buttonSzukaj.UseVisualStyleBackColor = true;
            // 
            // filtr2
            // 
            filtr2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            filtr2.FormattingEnabled = true;
            filtr2.Items.AddRange(new object[] { "równego", "zaczynającego się na" });
            filtr2.Location = new Point(0, 68);
            filtr2.Margin = new Padding(3, 2, 3, 2);
            filtr2.Name = "filtr2";
            filtr2.Size = new Size(177, 29);
            filtr2.TabIndex = 5;
            // 
            // baner
            // 
            baner.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            baner.ForeColor = Color.White;
            baner.Location = new Point(0, 0);
            baner.Name = "baner";
            baner.Size = new Size(167, 22);
            baner.TabIndex = 3;
            baner.Text = "Dla";
            baner.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxFiltr
            // 
            textBoxFiltr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFiltr.Location = new Point(-3, 113);
            textBoxFiltr.Margin = new Padding(3, 2, 3, 2);
            textBoxFiltr.Name = "textBoxFiltr";
            textBoxFiltr.Size = new Size(179, 29);
            textBoxFiltr.TabIndex = 6;
            // 
            // filtr1
            // 
            filtr1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            filtr1.FormattingEnabled = true;
            filtr1.Items.AddRange(new object[] { "imiona", "nazwiska", "stanowiska", "adresu" });
            filtr1.Location = new Point(0, 25);
            filtr1.Margin = new Padding(3, 2, 3, 2);
            filtr1.Name = "filtr1";
            filtr1.Size = new Size(177, 29);
            filtr1.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Gray;
            tabPage2.Controls.Add(buttonDodaj);
            tabPage2.Controls.Add(textBoxMail);
            tabPage2.Controls.Add(textBoxNr);
            tabPage2.Controls.Add(textBoxStan);
            tabPage2.Controls.Add(textBoxNazwisko);
            tabPage2.Controls.Add(textBoxImie);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(0);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(180, 296);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dodaj";
            // 
            // buttonDodaj
            // 
            buttonDodaj.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDodaj.Location = new Point(-1, 267);
            buttonDodaj.Margin = new Padding(3, 2, 3, 2);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(184, 29);
            buttonDodaj.TabIndex = 7;
            buttonDodaj.Text = "Dodaj";
            buttonDodaj.UseVisualStyleBackColor = true;
            buttonDodaj.Click += buttonDodaj_Click;
            // 
            // textBoxMail
            // 
            textBoxMail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMail.Location = new Point(0, 189);
            textBoxMail.Margin = new Padding(0, 15, 0, 0);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.PlaceholderText = "Adres e-mail";
            textBoxMail.Size = new Size(179, 27);
            textBoxMail.TabIndex = 6;
            // 
            // textBoxNr
            // 
            textBoxNr.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNr.Location = new Point(0, 147);
            textBoxNr.Margin = new Padding(0, 15, 0, 0);
            textBoxNr.Name = "textBoxNr";
            textBoxNr.PlaceholderText = "Nr. telefonu";
            textBoxNr.Size = new Size(180, 27);
            textBoxNr.TabIndex = 5;
            // 
            // textBoxStan
            // 
            textBoxStan.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxStan.Location = new Point(0, 105);
            textBoxStan.Margin = new Padding(0, 15, 0, 0);
            textBoxStan.Name = "textBoxStan";
            textBoxStan.PlaceholderText = "Stanowisko";
            textBoxStan.Size = new Size(179, 27);
            textBoxStan.TabIndex = 2;
            // 
            // textBoxNazwisko
            // 
            textBoxNazwisko.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNazwisko.Location = new Point(0, 63);
            textBoxNazwisko.Margin = new Padding(0, 15, 0, 0);
            textBoxNazwisko.Name = "textBoxNazwisko";
            textBoxNazwisko.PlaceholderText = "Nazwisko";
            textBoxNazwisko.Size = new Size(179, 27);
            textBoxNazwisko.TabIndex = 1;
            // 
            // textBoxImie
            // 
            textBoxImie.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxImie.Location = new Point(0, 21);
            textBoxImie.Margin = new Padding(0);
            textBoxImie.Name = "textBoxImie";
            textBoxImie.PlaceholderText = "Imię";
            textBoxImie.Size = new Size(179, 27);
            textBoxImie.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(panel2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(180, 296);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Usuń";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(180, 296);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Controls.Add(buttonUsun);
            panel3.Controls.Add(textBoxUsun);
            panel3.Controls.Add(filtr2Usun);
            panel3.Controls.Add(filtr1Usun);
            panel3.Controls.Add(label9);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(180, 296);
            panel3.TabIndex = 0;
            // 
            // buttonUsun
            // 
            buttonUsun.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUsun.Location = new Point(4, 143);
            buttonUsun.Margin = new Padding(3, 2, 3, 2);
            buttonUsun.Name = "buttonUsun";
            buttonUsun.Size = new Size(175, 27);
            buttonUsun.TabIndex = 8;
            buttonUsun.Text = "Usuń";
            buttonUsun.UseVisualStyleBackColor = true;
            buttonUsun.Click += buttonUsun_Click;
            // 
            // textBoxUsun
            // 
            textBoxUsun.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsun.Location = new Point(4, 105);
            textBoxUsun.Margin = new Padding(3, 2, 3, 2);
            textBoxUsun.Name = "textBoxUsun";
            textBoxUsun.Size = new Size(176, 27);
            textBoxUsun.TabIndex = 7;
            // 
            // filtr2Usun
            // 
            filtr2Usun.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            filtr2Usun.FormattingEnabled = true;
            filtr2Usun.Items.AddRange(new object[] { "równym", "zaczynającym się na" });
            filtr2Usun.Location = new Point(3, 64);
            filtr2Usun.Margin = new Padding(3, 2, 3, 2);
            filtr2Usun.Name = "filtr2Usun";
            filtr2Usun.Size = new Size(176, 27);
            filtr2Usun.TabIndex = 6;
            // 
            // filtr1Usun
            // 
            filtr1Usun.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            filtr1Usun.FormattingEnabled = true;
            filtr1Usun.Items.AddRange(new object[] { "ID", "Imieniu", "Nazwisku", "Stanowisku" });
            filtr1Usun.Location = new Point(3, 25);
            filtr1Usun.Margin = new Padding(3, 2, 3, 2);
            filtr1Usun.Name = "filtr1Usun";
            filtr1Usun.Size = new Size(176, 27);
            filtr1Usun.TabIndex = 5;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(177, 22);
            label9.TabIndex = 4;
            label9.Text = "Usuń członka kadry o";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.Gray;
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(3, 2, 3, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 2, 3, 2);
            tabPage4.Size = new Size(180, 296);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Modyfikuj";
            // 
            // iconButtonRozwijanie
            // 
            iconButtonRozwijanie.BackColor = Color.Gray;
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
            iconButtonRozwijanie.Margin = new Padding(3, 2, 3, 2);
            iconButtonRozwijanie.Name = "iconButtonRozwijanie";
            iconButtonRozwijanie.Rotation = 180D;
            iconButtonRozwijanie.Size = new Size(188, 38);
            iconButtonRozwijanie.TabIndex = 4;
            iconButtonRozwijanie.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonRozwijanie.UseVisualStyleBackColor = false;
            iconButtonRozwijanie.Click += iconButtonRozwijanie_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panelDane);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(188, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(596, 362);
            panel1.TabIndex = 3;
            // 
            // timerMenu
            // 
            timerMenu.Interval = 10;
            // 
            // WyswDanychKadra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panelFiltrowanie);
            Margin = new Padding(3, 2, 3, 2);
            Name = "WyswDanychKadra";
            Size = new Size(784, 362);
            Load += WyswDanych_Load;
            panelDane.ResumeLayout(false);
            panel4.ResumeLayout(false);
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
        private System.Windows.Forms.Timer timerMenu;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel4;
        private Label labelId;
        private Label labelImie;
        private Label labelStan;
        private Label labelNazw;
        private Label labelMail;
        private Label labelTel;
    }
}
