namespace USOS_Rektora
{
    partial class Logowanie
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelNaglowka = new Panel();
            panelBar = new Panel();
            iconButtonMin = new FontAwesome.Sharp.IconButton();
            iconButtonMaks = new FontAwesome.Sharp.IconButton();
            iconButtonZamknij = new FontAwesome.Sharp.IconButton();
            pictureBoxLogo = new PictureBox();
            Naglowek = new Label();
            panelLogowania = new Panel();
            tabControlKontener = new TabControl();
            tabPage1 = new TabPage();
            checkBoxHaslo = new CheckBox();
            panel2 = new Panel();
            labelHaslo = new Label();
            panel1 = new Panel();
            labelLogin = new Label();
            textLogin = new TextBox();
            buttonprzypomnij = new Button();
            textPass = new TextBox();
            buttonLogin = new Button();
            tabPage2 = new TabPage();
            buttonLosuj = new Button();
            captcha = new Label();
            panel4 = new Panel();
            labelweryfikacja = new Label();
            panel3 = new Panel();
            labelMail = new Label();
            buttonWroc = new Button();
            buttonDalej = new Button();
            textBoxLogin = new TextBox();
            textBoxWeryfikacja = new TextBox();
            tabPage3 = new TabPage();
            buttonWroc2 = new Button();
            textBoxKod = new TextBox();
            panel5 = new Panel();
            label1 = new Label();
            tabPage4 = new TabPage();
            buttonPotw = new Button();
            buttonWroc3 = new Button();
            textBoxNoweHaslo2 = new TextBox();
            textBoxNoweHaslo1 = new TextBox();
            panel7 = new Panel();
            label3 = new Label();
            panel6 = new Panel();
            label2 = new Label();
            panelNaglowka.SuspendLayout();
            panelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelLogowania.SuspendLayout();
            tabControlKontener.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            tabPage3.SuspendLayout();
            panel5.SuspendLayout();
            tabPage4.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panelNaglowka
            // 
            panelNaglowka.BackColor = Color.Navy;
            panelNaglowka.Controls.Add(panelBar);
            panelNaglowka.Controls.Add(pictureBoxLogo);
            panelNaglowka.Controls.Add(Naglowek);
            panelNaglowka.Dock = DockStyle.Top;
            panelNaglowka.Location = new Point(0, 0);
            panelNaglowka.Name = "panelNaglowka";
            panelNaglowka.Size = new Size(1182, 169);
            panelNaglowka.TabIndex = 0;
            // 
            // panelBar
            // 
            panelBar.BackColor = Color.FromArgb(64, 64, 64);
            panelBar.Controls.Add(iconButtonMin);
            panelBar.Controls.Add(iconButtonMaks);
            panelBar.Controls.Add(iconButtonZamknij);
            panelBar.Dock = DockStyle.Top;
            panelBar.Location = new Point(0, 0);
            panelBar.Margin = new Padding(0);
            panelBar.Name = "panelBar";
            panelBar.Size = new Size(1182, 48);
            panelBar.TabIndex = 3;
            panelBar.MouseDown += panelBar_MouseDown;
            // 
            // iconButtonMin
            // 
            iconButtonMin.BackColor = Color.FromArgb(64, 64, 64);
            iconButtonMin.Dock = DockStyle.Right;
            iconButtonMin.FlatAppearance.BorderSize = 0;
            iconButtonMin.FlatStyle = FlatStyle.Flat;
            iconButtonMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            iconButtonMin.IconColor = Color.FromArgb(224, 224, 224);
            iconButtonMin.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButtonMin.IconSize = 30;
            iconButtonMin.ImageAlign = ContentAlignment.BottomCenter;
            iconButtonMin.Location = new Point(1005, 0);
            iconButtonMin.Name = "iconButtonMin";
            iconButtonMin.Padding = new Padding(0, 0, 0, 8);
            iconButtonMin.Size = new Size(59, 48);
            iconButtonMin.TabIndex = 2;
            iconButtonMin.UseVisualStyleBackColor = false;
            iconButtonMin.Click += iconButtonMin_Click;
            // 
            // iconButtonMaks
            // 
            iconButtonMaks.BackColor = Color.FromArgb(64, 64, 64);
            iconButtonMaks.Dock = DockStyle.Right;
            iconButtonMaks.FlatAppearance.BorderSize = 0;
            iconButtonMaks.FlatStyle = FlatStyle.Flat;
            iconButtonMaks.IconChar = FontAwesome.Sharp.IconChar.Square;
            iconButtonMaks.IconColor = Color.FromArgb(224, 224, 224);
            iconButtonMaks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonMaks.IconSize = 30;
            iconButtonMaks.ImageAlign = ContentAlignment.TopCenter;
            iconButtonMaks.Location = new Point(1064, 0);
            iconButtonMaks.Name = "iconButtonMaks";
            iconButtonMaks.Size = new Size(59, 48);
            iconButtonMaks.TabIndex = 1;
            iconButtonMaks.UseVisualStyleBackColor = false;
            iconButtonMaks.Click += iconButtonMaks_Click;
            // 
            // iconButtonZamknij
            // 
            iconButtonZamknij.BackColor = Color.FromArgb(64, 64, 64);
            iconButtonZamknij.Dock = DockStyle.Right;
            iconButtonZamknij.FlatAppearance.BorderSize = 0;
            iconButtonZamknij.FlatStyle = FlatStyle.Flat;
            iconButtonZamknij.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            iconButtonZamknij.IconColor = Color.FromArgb(224, 224, 224);
            iconButtonZamknij.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButtonZamknij.IconSize = 30;
            iconButtonZamknij.ImageAlign = ContentAlignment.TopCenter;
            iconButtonZamknij.Location = new Point(1123, 0);
            iconButtonZamknij.Name = "iconButtonZamknij";
            iconButtonZamknij.Size = new Size(59, 48);
            iconButtonZamknij.TabIndex = 0;
            iconButtonZamknij.UseVisualStyleBackColor = false;
            iconButtonZamknij.Click += iconButtonZamknij_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Location = new Point(0, 35);
            pictureBoxLogo.Margin = new Padding(0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(230, 133);
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // Naglowek
            // 
            Naglowek.Anchor = AnchorStyles.None;
            Naglowek.AutoSize = true;
            Naglowek.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            Naglowek.ForeColor = SystemColors.ControlLightLight;
            Naglowek.Location = new Point(522, 65);
            Naglowek.Name = "Naglowek";
            Naglowek.Size = new Size(149, 62);
            Naglowek.TabIndex = 0;
            Naglowek.Text = "USOS";
            // 
            // panelLogowania
            // 
            panelLogowania.Controls.Add(tabControlKontener);
            panelLogowania.Controls.Add(panelNaglowka);
            panelLogowania.Dock = DockStyle.Fill;
            panelLogowania.Location = new Point(0, 0);
            panelLogowania.Name = "panelLogowania";
            panelLogowania.Size = new Size(1182, 653);
            panelLogowania.TabIndex = 1;
            // 
            // tabControlKontener
            // 
            tabControlKontener.Controls.Add(tabPage1);
            tabControlKontener.Controls.Add(tabPage2);
            tabControlKontener.Controls.Add(tabPage3);
            tabControlKontener.Controls.Add(tabPage4);
            tabControlKontener.Dock = DockStyle.Fill;
            tabControlKontener.ItemSize = new Size(20, 10);
            tabControlKontener.Location = new Point(0, 169);
            tabControlKontener.Margin = new Padding(0);
            tabControlKontener.Name = "tabControlKontener";
            tabControlKontener.SelectedIndex = 0;
            tabControlKontener.Size = new Size(1182, 484);
            tabControlKontener.SizeMode = TabSizeMode.Fixed;
            tabControlKontener.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Silver;
            tabPage1.Controls.Add(checkBoxHaslo);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(textLogin);
            tabPage1.Controls.Add(buttonprzypomnij);
            tabPage1.Controls.Add(textPass);
            tabPage1.Controls.Add(buttonLogin);
            tabPage1.Location = new Point(4, 14);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1174, 466);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPageLogowanie";
            // 
            // checkBoxHaslo
            // 
            checkBoxHaslo.Anchor = AnchorStyles.None;
            checkBoxHaslo.AutoSize = true;
            checkBoxHaslo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxHaslo.ForeColor = Color.White;
            checkBoxHaslo.Location = new Point(765, 253);
            checkBoxHaslo.Margin = new Padding(3, 4, 3, 4);
            checkBoxHaslo.Name = "checkBoxHaslo";
            checkBoxHaslo.Size = new Size(178, 41);
            checkBoxHaslo.TabIndex = 20;
            checkBoxHaslo.Text = "Pokaż haslo";
            checkBoxHaslo.UseVisualStyleBackColor = true;
            checkBoxHaslo.CheckedChanged += checkBoxHaslo_CheckedChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(labelHaslo);
            panel2.Location = new Point(0, 207);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1173, 47);
            panel2.TabIndex = 19;
            // 
            // labelHaslo
            // 
            labelHaslo.Dock = DockStyle.Fill;
            labelHaslo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelHaslo.ForeColor = Color.White;
            labelHaslo.Location = new Point(0, 0);
            labelHaslo.Margin = new Padding(0);
            labelHaslo.Name = "labelHaslo";
            labelHaslo.Size = new Size(1173, 47);
            labelHaslo.TabIndex = 13;
            labelHaslo.Text = "Hasło";
            labelHaslo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(labelLogin);
            panel1.Location = new Point(0, 92);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1173, 47);
            panel1.TabIndex = 18;
            // 
            // labelLogin
            // 
            labelLogin.Dock = DockStyle.Fill;
            labelLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogin.ForeColor = Color.White;
            labelLogin.Location = new Point(0, 0);
            labelLogin.Margin = new Padding(0);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(1173, 47);
            labelLogin.TabIndex = 13;
            labelLogin.Text = "Login";
            labelLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textLogin
            // 
            textLogin.Anchor = AnchorStyles.None;
            textLogin.BackColor = Color.Silver;
            textLogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textLogin.Location = new Point(430, 145);
            textLogin.Name = "textLogin";
            textLogin.Size = new Size(313, 43);
            textLogin.TabIndex = 12;
            // 
            // buttonprzypomnij
            // 
            buttonprzypomnij.Anchor = AnchorStyles.None;
            buttonprzypomnij.Location = new Point(574, 313);
            buttonprzypomnij.Margin = new Padding(3, 4, 3, 4);
            buttonprzypomnij.Name = "buttonprzypomnij";
            buttonprzypomnij.Size = new Size(217, 53);
            buttonprzypomnij.TabIndex = 17;
            buttonprzypomnij.Text = "ZMIEŃ/PRZYPOMNIJ HASŁO";
            buttonprzypomnij.UseVisualStyleBackColor = true;
            buttonprzypomnij.Click += buttonprzypomnij_Click;
            // 
            // textPass
            // 
            textPass.Anchor = AnchorStyles.None;
            textPass.BackColor = Color.Silver;
            textPass.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textPass.Location = new Point(430, 253);
            textPass.Margin = new Padding(3, 4, 3, 4);
            textPass.Name = "textPass";
            textPass.Size = new Size(313, 42);
            textPass.TabIndex = 14;
            textPass.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.None;
            buttonLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogin.Location = new Point(385, 313);
            buttonLogin.Margin = new Padding(3, 4, 3, 4);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(138, 53);
            buttonLogin.TabIndex = 16;
            buttonLogin.Text = "ZALOGUJ SIĘ";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Silver;
            tabPage2.Controls.Add(buttonLosuj);
            tabPage2.Controls.Add(captcha);
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(buttonWroc);
            tabPage2.Controls.Add(buttonDalej);
            tabPage2.Controls.Add(textBoxLogin);
            tabPage2.Controls.Add(textBoxWeryfikacja);
            tabPage2.Location = new Point(4, 14);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(1174, 466);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPageZmiana";
            // 
            // buttonLosuj
            // 
            buttonLosuj.Anchor = AnchorStyles.None;
            buttonLosuj.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLosuj.Location = new Point(197, 274);
            buttonLosuj.Name = "buttonLosuj";
            buttonLosuj.Size = new Size(101, 35);
            buttonLosuj.TabIndex = 22;
            buttonLosuj.Text = "losuj nowy";
            buttonLosuj.UseVisualStyleBackColor = true;
            buttonLosuj.Click += button1_Click;
            // 
            // captcha
            // 
            captcha.Anchor = AnchorStyles.None;
            captcha.AutoSize = true;
            captcha.Font = new Font("SimSun-ExtB", 13.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout, GraphicsUnit.Point);
            captcha.ForeColor = Color.White;
            captcha.Location = new Point(304, 278);
            captcha.Name = "captcha";
            captcha.Size = new Size(88, 23);
            captcha.TabIndex = 21;
            captcha.Text = "label1";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.Controls.Add(labelweryfikacja);
            panel4.Location = new Point(0, 207);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1173, 47);
            panel4.TabIndex = 20;
            // 
            // labelweryfikacja
            // 
            labelweryfikacja.Dock = DockStyle.Fill;
            labelweryfikacja.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelweryfikacja.ForeColor = Color.White;
            labelweryfikacja.Location = new Point(0, 0);
            labelweryfikacja.Margin = new Padding(0);
            labelweryfikacja.Name = "labelweryfikacja";
            labelweryfikacja.Size = new Size(1173, 47);
            labelweryfikacja.TabIndex = 13;
            labelweryfikacja.Text = "Przepisz tekst, który widzisz na obrazku obok";
            labelweryfikacja.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.Controls.Add(labelMail);
            panel3.Location = new Point(0, 80);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1173, 47);
            panel3.TabIndex = 19;
            // 
            // labelMail
            // 
            labelMail.Dock = DockStyle.Fill;
            labelMail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelMail.ForeColor = Color.White;
            labelMail.Location = new Point(0, 0);
            labelMail.Margin = new Padding(0);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(1173, 47);
            labelMail.TabIndex = 13;
            labelMail.Text = "Podaj login";
            labelMail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonWroc
            // 
            buttonWroc.Anchor = AnchorStyles.None;
            buttonWroc.Location = new Point(647, 336);
            buttonWroc.Name = "buttonWroc";
            buttonWroc.Size = new Size(96, 53);
            buttonWroc.TabIndex = 17;
            buttonWroc.Text = "WRÓĆ";
            buttonWroc.UseVisualStyleBackColor = true;
            buttonWroc.Click += buttonWroc_Click;
            // 
            // buttonDalej
            // 
            buttonDalej.Anchor = AnchorStyles.None;
            buttonDalej.Location = new Point(430, 336);
            buttonDalej.Name = "buttonDalej";
            buttonDalej.RightToLeft = RightToLeft.No;
            buttonDalej.Size = new Size(111, 53);
            buttonDalej.TabIndex = 16;
            buttonDalej.Text = "DALEJ";
            buttonDalej.UseVisualStyleBackColor = true;
            buttonDalej.Click += buttonDalej_Click;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.None;
            textBoxLogin.BackColor = Color.Silver;
            textBoxLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(430, 135);
            textBoxLogin.Margin = new Padding(3, 4, 3, 4);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(313, 42);
            textBoxLogin.TabIndex = 11;
            // 
            // textBoxWeryfikacja
            // 
            textBoxWeryfikacja.Anchor = AnchorStyles.None;
            textBoxWeryfikacja.BackColor = Color.Silver;
            textBoxWeryfikacja.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxWeryfikacja.Location = new Point(430, 271);
            textBoxWeryfikacja.Margin = new Padding(3, 4, 3, 4);
            textBoxWeryfikacja.Name = "textBoxWeryfikacja";
            textBoxWeryfikacja.Size = new Size(313, 42);
            textBoxWeryfikacja.TabIndex = 15;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Silver;
            tabPage3.Controls.Add(buttonWroc2);
            tabPage3.Controls.Add(textBoxKod);
            tabPage3.Controls.Add(panel5);
            tabPage3.Location = new Point(4, 14);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1174, 466);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPageKod";
            // 
            // buttonWroc2
            // 
            buttonWroc2.Anchor = AnchorStyles.None;
            buttonWroc2.Location = new Point(538, 297);
            buttonWroc2.Name = "buttonWroc2";
            buttonWroc2.Size = new Size(96, 53);
            buttonWroc2.TabIndex = 22;
            buttonWroc2.Text = "WRÓĆ";
            buttonWroc2.UseVisualStyleBackColor = true;
            buttonWroc2.Click += buttonWroc2_Click;
            // 
            // textBoxKod
            // 
            textBoxKod.Anchor = AnchorStyles.None;
            textBoxKod.BackColor = Color.Silver;
            textBoxKod.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxKod.Location = new Point(429, 230);
            textBoxKod.Margin = new Padding(3, 4, 3, 4);
            textBoxKod.Name = "textBoxKod";
            textBoxKod.Size = new Size(313, 42);
            textBoxKod.TabIndex = 21;
            textBoxKod.TextChanged += textBoxKod_TextChanged;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.Controls.Add(label1);
            panel5.Location = new Point(1, 175);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(1173, 47);
            panel5.TabIndex = 20;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(1173, 47);
            label1.TabIndex = 13;
            label1.Text = "Podaj kod przysłany na maila";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.Silver;
            tabPage4.Controls.Add(buttonPotw);
            tabPage4.Controls.Add(buttonWroc3);
            tabPage4.Controls.Add(textBoxNoweHaslo2);
            tabPage4.Controls.Add(textBoxNoweHaslo1);
            tabPage4.Controls.Add(panel7);
            tabPage4.Controls.Add(panel6);
            tabPage4.Location = new Point(4, 14);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1174, 466);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPageNoweHaslo";
            // 
            // buttonPotw
            // 
            buttonPotw.Anchor = AnchorStyles.None;
            buttonPotw.Location = new Point(435, 337);
            buttonPotw.Name = "buttonPotw";
            buttonPotw.Size = new Size(101, 53);
            buttonPotw.TabIndex = 26;
            buttonPotw.Text = "POTWIERDŹ";
            buttonPotw.UseVisualStyleBackColor = true;
            buttonPotw.Click += buttonPotw_Click;
            // 
            // buttonWroc3
            // 
            buttonWroc3.Anchor = AnchorStyles.None;
            buttonWroc3.Location = new Point(652, 337);
            buttonWroc3.Name = "buttonWroc3";
            buttonWroc3.Size = new Size(96, 53);
            buttonWroc3.TabIndex = 25;
            buttonWroc3.Text = "WRÓĆ";
            buttonWroc3.UseVisualStyleBackColor = true;
            buttonWroc3.Click += buttonWroc3_Click;
            // 
            // textBoxNoweHaslo2
            // 
            textBoxNoweHaslo2.Anchor = AnchorStyles.None;
            textBoxNoweHaslo2.BackColor = Color.Silver;
            textBoxNoweHaslo2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNoweHaslo2.Location = new Point(435, 288);
            textBoxNoweHaslo2.Margin = new Padding(3, 4, 3, 4);
            textBoxNoweHaslo2.Name = "textBoxNoweHaslo2";
            textBoxNoweHaslo2.Size = new Size(313, 42);
            textBoxNoweHaslo2.TabIndex = 24;
            // 
            // textBoxNoweHaslo1
            // 
            textBoxNoweHaslo1.Anchor = AnchorStyles.None;
            textBoxNoweHaslo1.BackColor = Color.Silver;
            textBoxNoweHaslo1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNoweHaslo1.Location = new Point(435, 153);
            textBoxNoweHaslo1.Margin = new Padding(3, 4, 3, 4);
            textBoxNoweHaslo1.Name = "textBoxNoweHaslo1";
            textBoxNoweHaslo1.Size = new Size(313, 42);
            textBoxNoweHaslo1.TabIndex = 23;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.None;
            panel7.Controls.Add(label3);
            panel7.Location = new Point(1, 237);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(1173, 47);
            panel7.TabIndex = 22;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(1173, 47);
            label3.TabIndex = 13;
            label3.Text = "Powtórz nowe hasło";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.Controls.Add(label2);
            panel6.Location = new Point(1, 98);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(1173, 47);
            panel6.TabIndex = 21;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(1173, 47);
            label2.TabIndex = 13;
            label2.Text = "Wpisz nowe hasło";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Logowanie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1182, 653);
            ControlBox = false;
            Controls.Add(panelLogowania);
            Name = "Logowanie";
            StartPosition = FormStartPosition.Manual;
            Load += Logowanie_Load;
            panelNaglowka.ResumeLayout(false);
            panelNaglowka.PerformLayout();
            panelBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelLogowania.ResumeLayout(false);
            tabControlKontener.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            panel5.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNaglowka;
        private Label Naglowek;
        private Panel panelLogowania;
        private PictureBox pictureBoxLogo;
        private TabControl tabControlKontener;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textLogin;
        private Button buttonprzypomnij;
        private TextBox textPass;
        private Button buttonLogin;
        private Button buttonWroc;
        private Button buttonDalej;
        private TextBox textBoxLogin;
        private TextBox textBoxWeryfikacja;
        private Panel panelBar;
        private FontAwesome.Sharp.IconButton iconButtonZamknij;
        private FontAwesome.Sharp.IconButton iconButtonMin;
        private FontAwesome.Sharp.IconButton iconButtonMaks;
        private Label labelLogin;
        private Panel panel1;
        private Panel panel2;
        private Label labelHaslo;
        private Panel panel3;
        private Label labelMail;
        private Panel panel4;
        private Label labelweryfikacja;
        private CheckBox checkBoxHaslo;
        private Label captcha;
        private Button buttonLosuj;
        private TabPage tabPage3;
        private TextBox textBoxKod;
        private Panel panel5;
        private Label label1;
        private TabPage tabPage4;
        private Button buttonWroc2;
        private Button buttonPotw;
        private Button buttonWroc3;
        private TextBox textBoxNoweHaslo2;
        private TextBox textBoxNoweHaslo1;
        private Panel panel7;
        private Label label3;
        private Panel panel6;
        private Label label2;
    }
}