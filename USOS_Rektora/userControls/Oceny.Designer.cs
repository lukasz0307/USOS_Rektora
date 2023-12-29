namespace USOS_Rektora.userControls
{
    partial class Oceny
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
            panelNagl = new Panel();
            labelsrednia = new Label();
            labelcyfrowa = new Label();
            labelElektronika = new Label();
            labelFizyka = new Label();
            labelMatematyka = new Label();
            labelIndeks = new Label();
            labelId = new Label();
            flowLayoutPanelDane = new FlowLayoutPanel();
            panelObsluga = new Panel();
            panel2 = new Panel();
            tabControlZarz = new TabControl();
            tabPage4 = new TabPage();
            tabPage1 = new TabPage();
            label6 = new Label();
            textBoxSred = new TextBox();
            label5 = new Label();
            numericUpDownCyfrowa = new NumericUpDown();
            label4 = new Label();
            numericUpDownElektr = new NumericUpDown();
            label3 = new Label();
            numericUpDownFizyka = new NumericUpDown();
            label2 = new Label();
            numericUpDownMatma = new NumericUpDown();
            comboBoxIndeks = new ComboBox();
            Dodaj = new FontAwesome.Sharp.IconButton();
            tabPage2 = new TabPage();
            usun = new FontAwesome.Sharp.IconButton();
            tabPage3 = new TabPage();
            Modyfikuj = new FontAwesome.Sharp.IconButton();
            textBoxNowaWart = new TextBox();
            label1 = new Label();
            comboBoxMod = new ComboBox();
            tabPage5 = new TabPage();
            Zapisz = new FontAwesome.Sharp.IconButton();
            comboBoxindexZap = new ComboBox();
            label7 = new Label();
            panel3 = new Panel();
            iconButtonZapisz = new FontAwesome.Sharp.IconButton();
            iconButtonMod = new FontAwesome.Sharp.IconButton();
            iconButtonUsun = new FontAwesome.Sharp.IconButton();
            iconButtonDodaj = new FontAwesome.Sharp.IconButton();
            iconButtonZwin = new FontAwesome.Sharp.IconButton();
            panelNagl.SuspendLayout();
            panelObsluga.SuspendLayout();
            panel2.SuspendLayout();
            tabControlZarz.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCyfrowa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownElektr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFizyka).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMatma).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage5.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelNagl
            // 
            panelNagl.Controls.Add(labelsrednia);
            panelNagl.Controls.Add(labelcyfrowa);
            panelNagl.Controls.Add(labelElektronika);
            panelNagl.Controls.Add(labelFizyka);
            panelNagl.Controls.Add(labelMatematyka);
            panelNagl.Controls.Add(labelIndeks);
            panelNagl.Controls.Add(labelId);
            panelNagl.Dock = DockStyle.Top;
            panelNagl.Location = new Point(0, 0);
            panelNagl.Margin = new Padding(0);
            panelNagl.Name = "panelNagl";
            panelNagl.Size = new Size(896, 51);
            panelNagl.TabIndex = 0;
            // 
            // labelsrednia
            // 
            labelsrednia.BackColor = Color.Gray;
            labelsrednia.BorderStyle = BorderStyle.FixedSingle;
            labelsrednia.Dock = DockStyle.Left;
            labelsrednia.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelsrednia.Location = new Point(742, 0);
            labelsrednia.Margin = new Padding(0);
            labelsrednia.Name = "labelsrednia";
            labelsrednia.Size = new Size(154, 51);
            labelsrednia.TabIndex = 7;
            labelsrednia.Text = "Średnia";
            labelsrednia.TextAlign = ContentAlignment.MiddleCenter;
            labelsrednia.Click += labelsrednia_Click;
            // 
            // labelcyfrowa
            // 
            labelcyfrowa.BackColor = Color.Gray;
            labelcyfrowa.BorderStyle = BorderStyle.FixedSingle;
            labelcyfrowa.Dock = DockStyle.Left;
            labelcyfrowa.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelcyfrowa.Location = new Point(573, 0);
            labelcyfrowa.Margin = new Padding(0);
            labelcyfrowa.Name = "labelcyfrowa";
            labelcyfrowa.Size = new Size(169, 51);
            labelcyfrowa.TabIndex = 6;
            labelcyfrowa.Text = "Technika cyfrowa";
            labelcyfrowa.TextAlign = ContentAlignment.MiddleCenter;
            labelcyfrowa.Click += labelcyfrowa_Click;
            // 
            // labelElektronika
            // 
            labelElektronika.BackColor = Color.Gray;
            labelElektronika.BorderStyle = BorderStyle.FixedSingle;
            labelElektronika.Dock = DockStyle.Left;
            labelElektronika.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelElektronika.Location = new Point(454, 0);
            labelElektronika.Margin = new Padding(0);
            labelElektronika.Name = "labelElektronika";
            labelElektronika.Size = new Size(119, 51);
            labelElektronika.TabIndex = 5;
            labelElektronika.Text = "Elektronika";
            labelElektronika.TextAlign = ContentAlignment.MiddleCenter;
            labelElektronika.Click += labelElektronika_Click;
            // 
            // labelFizyka
            // 
            labelFizyka.BackColor = Color.Gray;
            labelFizyka.BorderStyle = BorderStyle.FixedSingle;
            labelFizyka.Dock = DockStyle.Left;
            labelFizyka.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelFizyka.Location = new Point(351, 0);
            labelFizyka.Margin = new Padding(0);
            labelFizyka.Name = "labelFizyka";
            labelFizyka.Size = new Size(103, 51);
            labelFizyka.TabIndex = 4;
            labelFizyka.Text = "Fizyka";
            labelFizyka.TextAlign = ContentAlignment.MiddleCenter;
            labelFizyka.Click += labelFizyka_Click;
            // 
            // labelMatematyka
            // 
            labelMatematyka.BackColor = Color.Gray;
            labelMatematyka.BorderStyle = BorderStyle.FixedSingle;
            labelMatematyka.Dock = DockStyle.Left;
            labelMatematyka.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelMatematyka.Location = new Point(226, 0);
            labelMatematyka.Margin = new Padding(0);
            labelMatematyka.Name = "labelMatematyka";
            labelMatematyka.Size = new Size(125, 51);
            labelMatematyka.TabIndex = 3;
            labelMatematyka.Text = "Matematyka";
            labelMatematyka.TextAlign = ContentAlignment.MiddleCenter;
            labelMatematyka.Click += labelMatematyka_Click;
            // 
            // labelIndeks
            // 
            labelIndeks.BackColor = Color.Gray;
            labelIndeks.BorderStyle = BorderStyle.FixedSingle;
            labelIndeks.Dock = DockStyle.Left;
            labelIndeks.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelIndeks.Location = new Point(57, 0);
            labelIndeks.Margin = new Padding(0);
            labelIndeks.Name = "labelIndeks";
            labelIndeks.Size = new Size(169, 51);
            labelIndeks.TabIndex = 2;
            labelIndeks.Text = "Numer Indeksu";
            labelIndeks.TextAlign = ContentAlignment.MiddleCenter;
            labelIndeks.Click += labelIndeks_Click;
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
            labelId.TabIndex = 1;
            labelId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelDane
            // 
            flowLayoutPanelDane.AutoScroll = true;
            flowLayoutPanelDane.Location = new Point(0, 51);
            flowLayoutPanelDane.Margin = new Padding(0);
            flowLayoutPanelDane.Name = "flowLayoutPanelDane";
            flowLayoutPanelDane.Size = new Size(924, 240);
            flowLayoutPanelDane.TabIndex = 1;
            // 
            // panelObsluga
            // 
            panelObsluga.Controls.Add(panel2);
            panelObsluga.Controls.Add(iconButtonZwin);
            panelObsluga.Dock = DockStyle.Bottom;
            panelObsluga.Location = new Point(0, 291);
            panelObsluga.Margin = new Padding(0);
            panelObsluga.Name = "panelObsluga";
            panelObsluga.Size = new Size(896, 191);
            panelObsluga.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(tabControlZarz);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(896, 147);
            panel2.TabIndex = 3;
            // 
            // tabControlZarz
            // 
            tabControlZarz.Controls.Add(tabPage4);
            tabControlZarz.Controls.Add(tabPage1);
            tabControlZarz.Controls.Add(tabPage2);
            tabControlZarz.Controls.Add(tabPage3);
            tabControlZarz.Controls.Add(tabPage5);
            tabControlZarz.Dock = DockStyle.Fill;
            tabControlZarz.ItemSize = new Size(0, 1);
            tabControlZarz.Location = new Point(99, 0);
            tabControlZarz.Margin = new Padding(0);
            tabControlZarz.Name = "tabControlZarz";
            tabControlZarz.Padding = new Point(0, 0);
            tabControlZarz.SelectedIndex = 0;
            tabControlZarz.Size = new Size(797, 147);
            tabControlZarz.SizeMode = TabSizeMode.Fixed;
            tabControlZarz.TabIndex = 3;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.Silver;
            tabPage4.Location = new Point(4, 5);
            tabPage4.Margin = new Padding(0);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(789, 138);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Silver;
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(textBoxSred);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(numericUpDownCyfrowa);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(numericUpDownElektr);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(numericUpDownFizyka);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(numericUpDownMatma);
            tabPage1.Controls.Add(comboBoxIndeks);
            tabPage1.Controls.Add(Dodaj);
            tabPage1.Location = new Point(4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(789, 138);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(622, 8);
            label6.Name = "label6";
            label6.Size = new Size(71, 25);
            label6.TabIndex = 19;
            label6.Text = "Średnia";
            // 
            // textBoxSred
            // 
            textBoxSred.Anchor = AnchorStyles.None;
            textBoxSred.Enabled = false;
            textBoxSred.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSred.Location = new Point(562, 37);
            textBoxSred.Name = "textBoxSred";
            textBoxSred.Size = new Size(196, 31);
            textBoxSred.TabIndex = 18;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(475, 7);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 17;
            label5.Text = "Tech.cyfr.";
            // 
            // numericUpDownCyfrowa
            // 
            numericUpDownCyfrowa.Anchor = AnchorStyles.None;
            numericUpDownCyfrowa.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownCyfrowa.Location = new Point(475, 37);
            numericUpDownCyfrowa.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownCyfrowa.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownCyfrowa.Name = "numericUpDownCyfrowa";
            numericUpDownCyfrowa.Size = new Size(81, 31);
            numericUpDownCyfrowa.TabIndex = 16;
            numericUpDownCyfrowa.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownCyfrowa.ValueChanged += numericUpDownCyfrowa_ValueChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(400, 7);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 15;
            label4.Text = "Elektr.";
            // 
            // numericUpDownElektr
            // 
            numericUpDownElektr.Anchor = AnchorStyles.None;
            numericUpDownElektr.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownElektr.Location = new Point(389, 37);
            numericUpDownElektr.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownElektr.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownElektr.Name = "numericUpDownElektr";
            numericUpDownElektr.Size = new Size(81, 31);
            numericUpDownElektr.TabIndex = 14;
            numericUpDownElektr.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownElektr.ValueChanged += numericUpDownElektr_ValueChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(311, 8);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 13;
            label3.Text = "Fizyka";
            // 
            // numericUpDownFizyka
            // 
            numericUpDownFizyka.Anchor = AnchorStyles.None;
            numericUpDownFizyka.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownFizyka.Location = new Point(302, 36);
            numericUpDownFizyka.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownFizyka.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownFizyka.Name = "numericUpDownFizyka";
            numericUpDownFizyka.Size = new Size(81, 31);
            numericUpDownFizyka.TabIndex = 12;
            numericUpDownFizyka.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownFizyka.ValueChanged += numericUpDownFizyka_ValueChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(226, 7);
            label2.Name = "label2";
            label2.Size = new Size(47, 25);
            label2.TabIndex = 11;
            label2.Text = "Mat.";
            // 
            // numericUpDownMatma
            // 
            numericUpDownMatma.Anchor = AnchorStyles.None;
            numericUpDownMatma.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownMatma.Location = new Point(212, 35);
            numericUpDownMatma.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownMatma.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownMatma.Name = "numericUpDownMatma";
            numericUpDownMatma.Size = new Size(81, 31);
            numericUpDownMatma.TabIndex = 10;
            numericUpDownMatma.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownMatma.ValueChanged += numericUpDownMatma_ValueChanged;
            // 
            // comboBoxIndeks
            // 
            comboBoxIndeks.Anchor = AnchorStyles.None;
            comboBoxIndeks.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxIndeks.FormattingEnabled = true;
            comboBoxIndeks.Location = new Point(23, 35);
            comboBoxIndeks.Margin = new Padding(5, 3, 3, 3);
            comboBoxIndeks.Name = "comboBoxIndeks";
            comboBoxIndeks.Size = new Size(183, 33);
            comboBoxIndeks.TabIndex = 7;
            comboBoxIndeks.Text = "Nr.indeksu";
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
            Dodaj.Location = new Point(295, 80);
            Dodaj.Margin = new Padding(0);
            Dodaj.Name = "Dodaj";
            Dodaj.Size = new Size(99, 36);
            Dodaj.TabIndex = 6;
            Dodaj.Text = "Dodaj";
            Dodaj.TextAlign = ContentAlignment.MiddleLeft;
            Dodaj.UseVisualStyleBackColor = false;
            Dodaj.Click += Dodaj_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Silver;
            tabPage2.Controls.Add(usun);
            tabPage2.Location = new Point(4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(789, 138);
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
            usun.Location = new Point(296, 41);
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
            tabPage3.Size = new Size(789, 138);
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
            Modyfikuj.Location = new Point(590, 50);
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
            textBoxNowaWart.Location = new Point(422, 53);
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
            label1.Location = new Point(13, 56);
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
            comboBoxMod.Items.AddRange(new object[] { "Numer Indeksu", "Matematyka", "Fizyka", "Elektronika", "Technika cyfrowa", "Średnia" });
            comboBoxMod.Location = new Point(248, 53);
            comboBoxMod.Margin = new Padding(20, 3, 3, 3);
            comboBoxMod.Name = "comboBoxMod";
            comboBoxMod.Size = new Size(151, 33);
            comboBoxMod.TabIndex = 0;
            comboBoxMod.SelectedIndexChanged += comboBoxMod_SelectedIndexChanged;
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.Silver;
            tabPage5.Controls.Add(Zapisz);
            tabPage5.Controls.Add(comboBoxindexZap);
            tabPage5.Controls.Add(label7);
            tabPage5.Location = new Point(4, 5);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(789, 138);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            // 
            // Zapisz
            // 
            Zapisz.Anchor = AnchorStyles.None;
            Zapisz.BackColor = Color.FromArgb(255, 192, 255);
            Zapisz.FlatStyle = FlatStyle.Flat;
            Zapisz.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Zapisz.ForeColor = Color.Purple;
            Zapisz.IconChar = FontAwesome.Sharp.IconChar.Pen;
            Zapisz.IconColor = Color.Purple;
            Zapisz.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Zapisz.IconSize = 30;
            Zapisz.ImageAlign = ContentAlignment.MiddleRight;
            Zapisz.Location = new Point(519, 32);
            Zapisz.Margin = new Padding(0);
            Zapisz.Name = "Zapisz";
            Zapisz.Size = new Size(245, 37);
            Zapisz.TabIndex = 9;
            Zapisz.Text = "Zapisz Raport o ocenach";
            Zapisz.TextAlign = ContentAlignment.MiddleLeft;
            Zapisz.UseVisualStyleBackColor = false;
            Zapisz.Click += Zapisz_Click;
            // 
            // comboBoxindexZap
            // 
            comboBoxindexZap.Anchor = AnchorStyles.None;
            comboBoxindexZap.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxindexZap.FormattingEnabled = true;
            comboBoxindexZap.Location = new Point(307, 35);
            comboBoxindexZap.Margin = new Padding(5, 3, 3, 3);
            comboBoxindexZap.Name = "comboBoxindexZap";
            comboBoxindexZap.Size = new Size(183, 33);
            comboBoxindexZap.TabIndex = 8;
            comboBoxindexZap.Text = "Nr.indeksu";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(16, 26);
            label7.Margin = new Padding(20, 0, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(283, 72);
            label7.TabIndex = 2;
            label7.Text = "Wybierz dla studenta o jakim indeksie zapisać raport o ocenach";
            // 
            // panel3
            // 
            panel3.Controls.Add(iconButtonZapisz);
            panel3.Controls.Add(iconButtonMod);
            panel3.Controls.Add(iconButtonUsun);
            panel3.Controls.Add(iconButtonDodaj);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(99, 147);
            panel3.TabIndex = 1;
            // 
            // iconButtonZapisz
            // 
            iconButtonZapisz.BackColor = Color.FromArgb(255, 192, 255);
            iconButtonZapisz.Dock = DockStyle.Top;
            iconButtonZapisz.FlatStyle = FlatStyle.Flat;
            iconButtonZapisz.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonZapisz.ForeColor = Color.Purple;
            iconButtonZapisz.IconChar = FontAwesome.Sharp.IconChar.Pen;
            iconButtonZapisz.IconColor = Color.Purple;
            iconButtonZapisz.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonZapisz.IconSize = 30;
            iconButtonZapisz.ImageAlign = ContentAlignment.MiddleRight;
            iconButtonZapisz.Location = new Point(0, 109);
            iconButtonZapisz.Margin = new Padding(0);
            iconButtonZapisz.Name = "iconButtonZapisz";
            iconButtonZapisz.Size = new Size(99, 37);
            iconButtonZapisz.TabIndex = 3;
            iconButtonZapisz.Text = "Zapisz";
            iconButtonZapisz.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonZapisz.UseVisualStyleBackColor = false;
            iconButtonZapisz.Click += iconButtonZapisz_Click;
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
            // Oceny
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelObsluga);
            Controls.Add(flowLayoutPanelDane);
            Controls.Add(panelNagl);
            Margin = new Padding(0);
            Name = "Oceny";
            Size = new Size(896, 482);
            Load += Oceny_Load;
            panelNagl.ResumeLayout(false);
            panelObsluga.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tabControlZarz.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCyfrowa).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownElektr).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFizyka).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMatma).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNagl;
        private Label labelId;
        private Label labelsrednia;
        private Label labelcyfrowa;
        private Label labelElektronika;
        private Label labelFizyka;
        private Label labelMatematyka;
        private Label labelIndeks;
        private FlowLayoutPanel flowLayoutPanelDane;
        private Panel panelObsluga;
        private Panel panel2;
        private TabControl tabControlZarz;
        private TabPage tabPage4;
        private TabPage tabPage1;
        private ComboBox comboBoxIndeks;
        private FontAwesome.Sharp.IconButton Dodaj;
        private TabPage tabPage2;
        private FontAwesome.Sharp.IconButton usun;
        private TabPage tabPage3;
        private FontAwesome.Sharp.IconButton Modyfikuj;
        private TextBox textBoxNowaWart;
        private Label label1;
        private ComboBox comboBoxMod;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton iconButtonMod;
        private FontAwesome.Sharp.IconButton iconButtonUsun;
        private FontAwesome.Sharp.IconButton iconButtonDodaj;
        private FontAwesome.Sharp.IconButton iconButtonZwin;
        private TabPage tabPage5;
        private FontAwesome.Sharp.IconButton iconButtonZapisz;
        private Label label2;
        private NumericUpDown numericUpDownMatma;
        private Label label5;
        private NumericUpDown numericUpDownCyfrowa;
        private Label label4;
        private NumericUpDown numericUpDownElektr;
        private Label label3;
        private NumericUpDown numericUpDownFizyka;
        private Label label6;
        private TextBox textBoxSred;
        private Label label7;
        private FontAwesome.Sharp.IconButton Zapisz;
        private ComboBox comboBoxindexZap;
    }
}
