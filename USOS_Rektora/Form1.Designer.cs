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
            textBoxLogin = new TextBox();
            buttonprzypomnij = new Button();
            textBoxHaslo = new TextBox();
            buttonLogin = new Button();
            tabPage2 = new TabPage();
            panel4 = new Panel();
            labelweryfikacja = new Label();
            panel3 = new Panel();
            labelMail = new Label();
            buttonWroc = new Button();
            buttonDalej = new Button();
            textBoxMail = new TextBox();
            textBoxWeryfikacja = new TextBox();
            pictureBoxWeryfikacja = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxWeryfikacja).BeginInit();
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
            panelNaglowka.Margin = new Padding(3, 2, 3, 2);
            panelNaglowka.Name = "panelNaglowka";
            panelNaglowka.Size = new Size(1034, 127);
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
            panelBar.Size = new Size(1034, 36);
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
            iconButtonMin.Location = new Point(878, 0);
            iconButtonMin.Margin = new Padding(3, 2, 3, 2);
            iconButtonMin.Name = "iconButtonMin";
            iconButtonMin.Size = new Size(52, 36);
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
            iconButtonMaks.Location = new Point(930, 0);
            iconButtonMaks.Margin = new Padding(3, 2, 3, 2);
            iconButtonMaks.Name = "iconButtonMaks";
            iconButtonMaks.Size = new Size(52, 36);
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
            iconButtonZamknij.Location = new Point(982, 0);
            iconButtonZamknij.Margin = new Padding(3, 2, 3, 2);
            iconButtonZamknij.Name = "iconButtonZamknij";
            iconButtonZamknij.Size = new Size(52, 36);
            iconButtonZamknij.TabIndex = 0;
            iconButtonZamknij.UseVisualStyleBackColor = false;
            iconButtonZamknij.Click += iconButtonZamknij_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Location = new Point(0, 26);
            pictureBoxLogo.Margin = new Padding(0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(201, 100);
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // Naglowek
            // 
            Naglowek.Anchor = AnchorStyles.None;
            Naglowek.AutoSize = true;
            Naglowek.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            Naglowek.ForeColor = SystemColors.ControlLightLight;
            Naglowek.Location = new Point(457, 49);
            Naglowek.Name = "Naglowek";
            Naglowek.Size = new Size(119, 50);
            Naglowek.TabIndex = 0;
            Naglowek.Text = "USOS";
            // 
            // panelLogowania
            // 
            panelLogowania.Controls.Add(tabControlKontener);
            panelLogowania.Controls.Add(panelNaglowka);
            panelLogowania.Dock = DockStyle.Fill;
            panelLogowania.Location = new Point(0, 0);
            panelLogowania.Margin = new Padding(3, 2, 3, 2);
            panelLogowania.Name = "panelLogowania";
            panelLogowania.Size = new Size(1034, 490);
            panelLogowania.TabIndex = 1;
            // 
            // tabControlKontener
            // 
            tabControlKontener.Controls.Add(tabPage1);
            tabControlKontener.Controls.Add(tabPage2);
            tabControlKontener.Dock = DockStyle.Fill;
            tabControlKontener.ItemSize = new Size(20, 10);
            tabControlKontener.Location = new Point(0, 127);
            tabControlKontener.Margin = new Padding(0);
            tabControlKontener.Name = "tabControlKontener";
            tabControlKontener.SelectedIndex = 0;
            tabControlKontener.Size = new Size(1034, 363);
            tabControlKontener.SizeMode = TabSizeMode.Fixed;
            tabControlKontener.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Silver;
            tabPage1.Controls.Add(checkBoxHaslo);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(textBoxLogin);
            tabPage1.Controls.Add(buttonprzypomnij);
            tabPage1.Controls.Add(textBoxHaslo);
            tabPage1.Controls.Add(buttonLogin);
            tabPage1.Location = new Point(4, 14);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1026, 345);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // checkBoxHaslo
            // 
            checkBoxHaslo.Anchor = AnchorStyles.None;
            checkBoxHaslo.AutoSize = true;
            checkBoxHaslo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxHaslo.ForeColor = Color.White;
            checkBoxHaslo.Location = new Point(669, 190);
            checkBoxHaslo.Name = "checkBoxHaslo";
            checkBoxHaslo.Size = new Size(141, 34);
            checkBoxHaslo.TabIndex = 20;
            checkBoxHaslo.Text = "Pokaż haslo";
            checkBoxHaslo.UseVisualStyleBackColor = true;
            checkBoxHaslo.CheckedChanged += checkBoxHaslo_CheckedChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(labelHaslo);
            panel2.Location = new Point(0, 155);
            panel2.Name = "panel2";
            panel2.Size = new Size(1026, 35);
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
            labelHaslo.Size = new Size(1026, 35);
            labelHaslo.TabIndex = 13;
            labelHaslo.Text = "Hasło";
            labelHaslo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(labelLogin);
            panel1.Location = new Point(0, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(1026, 35);
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
            labelLogin.Size = new Size(1026, 35);
            labelLogin.TabIndex = 13;
            labelLogin.Text = "Login";
            labelLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.None;
            textBoxLogin.BackColor = Color.Silver;
            textBoxLogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(376, 109);
            textBoxLogin.Margin = new Padding(3, 2, 3, 2);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(274, 36);
            textBoxLogin.TabIndex = 12;
            textBoxLogin.TextChanged += textBoxLogin_TextChanged;
            // 
            // buttonprzypomnij
            // 
            buttonprzypomnij.Anchor = AnchorStyles.None;
            buttonprzypomnij.Location = new Point(502, 235);
            buttonprzypomnij.Name = "buttonprzypomnij";
            buttonprzypomnij.Size = new Size(190, 40);
            buttonprzypomnij.TabIndex = 17;
            buttonprzypomnij.Text = "ZMIEŃ/PRZYPOMNIJ HASŁO";
            buttonprzypomnij.UseVisualStyleBackColor = true;
            buttonprzypomnij.Click += buttonprzypomnij_Click;
            // 
            // textBoxHaslo
            // 
            textBoxHaslo.Anchor = AnchorStyles.None;
            textBoxHaslo.BackColor = Color.Silver;
            textBoxHaslo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxHaslo.Location = new Point(376, 190);
            textBoxHaslo.Name = "textBoxHaslo";
            textBoxHaslo.Size = new Size(274, 35);
            textBoxHaslo.TabIndex = 14;
            textBoxHaslo.UseSystemPasswordChar = true;
            textBoxHaslo.TextChanged += textBoxHaslo_TextChanged;
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.None;
            buttonLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogin.Location = new Point(337, 235);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(121, 40);
            buttonLogin.TabIndex = 16;
            buttonLogin.Text = "ZALOGUJ SIĘ";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Silver;
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(buttonWroc);
            tabPage2.Controls.Add(buttonDalej);
            tabPage2.Controls.Add(textBoxMail);
            tabPage2.Controls.Add(textBoxWeryfikacja);
            tabPage2.Controls.Add(pictureBoxWeryfikacja);
            tabPage2.Location = new Point(4, 14);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1026, 345);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.Controls.Add(labelweryfikacja);
            panel4.Location = new Point(0, 155);
            panel4.Name = "panel4";
            panel4.Size = new Size(1026, 35);
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
            labelweryfikacja.Size = new Size(1026, 35);
            labelweryfikacja.TabIndex = 13;
            labelweryfikacja.Text = "Przepisz tekst, który widzisz na obrazku obok";
            labelweryfikacja.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.Controls.Add(labelMail);
            panel3.Location = new Point(0, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(1026, 35);
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
            labelMail.Size = new Size(1026, 35);
            labelMail.TabIndex = 13;
            labelMail.Text = "Podaj adres e-mail";
            labelMail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonWroc
            // 
            buttonWroc.Anchor = AnchorStyles.None;
            buttonWroc.Location = new Point(566, 252);
            buttonWroc.Margin = new Padding(3, 2, 3, 2);
            buttonWroc.Name = "buttonWroc";
            buttonWroc.Size = new Size(84, 40);
            buttonWroc.TabIndex = 17;
            buttonWroc.Text = "WRÓĆ";
            buttonWroc.UseVisualStyleBackColor = true;
            buttonWroc.Click += buttonWroc_Click;
            // 
            // buttonDalej
            // 
            buttonDalej.Anchor = AnchorStyles.None;
            buttonDalej.Location = new Point(376, 252);
            buttonDalej.Margin = new Padding(3, 2, 3, 2);
            buttonDalej.Name = "buttonDalej";
            buttonDalej.Size = new Size(97, 40);
            buttonDalej.TabIndex = 16;
            buttonDalej.Text = "DALEJ";
            buttonDalej.UseVisualStyleBackColor = true;
            // 
            // textBoxMail
            // 
            textBoxMail.Anchor = AnchorStyles.None;
            textBoxMail.BackColor = Color.Silver;
            textBoxMail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMail.Location = new Point(376, 101);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(274, 35);
            textBoxMail.TabIndex = 11;
            // 
            // textBoxWeryfikacja
            // 
            textBoxWeryfikacja.Anchor = AnchorStyles.None;
            textBoxWeryfikacja.BackColor = Color.Silver;
            textBoxWeryfikacja.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxWeryfikacja.Location = new Point(376, 203);
            textBoxWeryfikacja.Name = "textBoxWeryfikacja";
            textBoxWeryfikacja.Size = new Size(274, 35);
            textBoxWeryfikacja.TabIndex = 15;
            // 
            // pictureBoxWeryfikacja
            // 
            pictureBoxWeryfikacja.Anchor = AnchorStyles.None;
            pictureBoxWeryfikacja.Location = new Point(235, 206);
            pictureBoxWeryfikacja.Margin = new Padding(3, 2, 3, 2);
            pictureBoxWeryfikacja.Name = "pictureBoxWeryfikacja";
            pictureBoxWeryfikacja.Size = new Size(122, 35);
            pictureBoxWeryfikacja.TabIndex = 14;
            pictureBoxWeryfikacja.TabStop = false;
            // 
            // Logowanie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1034, 490);
            ControlBox = false;
            Controls.Add(panelLogowania);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Logowanie";
            StartPosition = FormStartPosition.Manual;
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxWeryfikacja).EndInit();
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
        private TextBox textBoxLogin;
        private Button buttonprzypomnij;
        private TextBox textBoxHaslo;
        private Button buttonLogin;
        private Button buttonWroc;
        private Button buttonDalej;
        private TextBox textBoxMail;
        private TextBox textBoxWeryfikacja;
        private PictureBox pictureBoxWeryfikacja;
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
    }
}