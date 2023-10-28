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
            textBoxLogin = new TextBox();
            buttonprzypomnij = new Button();
            textBoxHaslo = new TextBox();
            buttonLogin = new Button();
            tabPage2 = new TabPage();
            buttonWroc = new Button();
            buttonDalej = new Button();
            labelmail = new Label();
            textBoxMail = new TextBox();
            textBoxWeryfikacja = new TextBox();
            pictureBoxWeryfikacja = new PictureBox();
            labelWeryfikacja = new Label();
            labelHaslo = new Label();
            labelLogin = new Label();
            panelNaglowka.SuspendLayout();
            panelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelLogowania.SuspendLayout();
            tabControlKontener.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
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
            tabPage1.Controls.Add(labelLogin);
            tabPage1.Controls.Add(textBoxLogin);
            tabPage1.Controls.Add(labelHaslo);
            tabPage1.Controls.Add(buttonprzypomnij);
            tabPage1.Controls.Add(textBoxHaslo);
            tabPage1.Controls.Add(buttonLogin);
            tabPage1.Location = new Point(4, 14);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 3, 3, 3);
            tabPage1.Size = new Size(1026, 345);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.None;
            textBoxLogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(371, 106);
            textBoxLogin.Margin = new Padding(3, 2, 3, 2);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(274, 36);
            textBoxLogin.TabIndex = 12;
            // 
            // buttonprzypomnij
            // 
            buttonprzypomnij.Anchor = AnchorStyles.None;
            buttonprzypomnij.Location = new Point(497, 246);
            buttonprzypomnij.Name = "buttonprzypomnij";
            buttonprzypomnij.Size = new Size(190, 23);
            buttonprzypomnij.TabIndex = 17;
            buttonprzypomnij.Text = "ZMIEŃ/PRZYPOMNIJ HASŁO";
            buttonprzypomnij.UseVisualStyleBackColor = true;
            buttonprzypomnij.Click += buttonprzypomnij_Click;
            // 
            // textBoxHaslo
            // 
            textBoxHaslo.Anchor = AnchorStyles.None;
            textBoxHaslo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxHaslo.Location = new Point(371, 190);
            textBoxHaslo.Name = "textBoxHaslo";
            textBoxHaslo.Size = new Size(274, 35);
            textBoxHaslo.TabIndex = 14;
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.None;
            buttonLogin.Location = new Point(339, 246);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(121, 23);
            buttonLogin.TabIndex = 16;
            buttonLogin.Text = "ZALOGUJ SIĘ";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(buttonWroc);
            tabPage2.Controls.Add(buttonDalej);
            tabPage2.Controls.Add(labelmail);
            tabPage2.Controls.Add(textBoxMail);
            tabPage2.Controls.Add(textBoxWeryfikacja);
            tabPage2.Controls.Add(pictureBoxWeryfikacja);
            tabPage2.Controls.Add(labelWeryfikacja);
            tabPage2.Location = new Point(4, 14);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 3, 3, 3);
            tabPage2.Size = new Size(1026, 345);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // buttonWroc
            // 
            buttonWroc.Anchor = AnchorStyles.None;
            buttonWroc.Location = new Point(587, 252);
            buttonWroc.Margin = new Padding(3, 2, 3, 2);
            buttonWroc.Name = "buttonWroc";
            buttonWroc.Size = new Size(84, 27);
            buttonWroc.TabIndex = 17;
            buttonWroc.Text = "Wróć";
            buttonWroc.UseVisualStyleBackColor = true;
            buttonWroc.Click += buttonWroc_Click;
            // 
            // buttonDalej
            // 
            buttonDalej.Anchor = AnchorStyles.None;
            buttonDalej.Location = new Point(397, 252);
            buttonDalej.Margin = new Padding(3, 2, 3, 2);
            buttonDalej.Name = "buttonDalej";
            buttonDalej.Size = new Size(97, 27);
            buttonDalej.TabIndex = 16;
            buttonDalej.Text = "Dalej";
            buttonDalej.UseVisualStyleBackColor = true;
            // 
            // labelmail
            // 
            labelmail.Anchor = AnchorStyles.None;
            labelmail.AutoSize = true;
            labelmail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelmail.Location = new Point(458, 70);
            labelmail.Name = "labelmail";
            labelmail.Size = new Size(135, 30);
            labelmail.TabIndex = 12;
            labelmail.Text = "Adres e-mail:";
            // 
            // textBoxMail
            // 
            textBoxMail.Anchor = AnchorStyles.None;
            textBoxMail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMail.Location = new Point(397, 101);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(274, 35);
            textBoxMail.TabIndex = 11;
            // 
            // textBoxWeryfikacja
            // 
            textBoxWeryfikacja.Anchor = AnchorStyles.None;
            textBoxWeryfikacja.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxWeryfikacja.Location = new Point(397, 206);
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
            pictureBoxWeryfikacja.Size = new Size(122, 32);
            pictureBoxWeryfikacja.TabIndex = 14;
            pictureBoxWeryfikacja.TabStop = false;
            // 
            // labelWeryfikacja
            // 
            labelWeryfikacja.Anchor = AnchorStyles.None;
            labelWeryfikacja.AutoSize = true;
            labelWeryfikacja.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelWeryfikacja.Location = new Point(295, 156);
            labelWeryfikacja.Name = "labelWeryfikacja";
            labelWeryfikacja.Size = new Size(420, 30);
            labelWeryfikacja.TabIndex = 13;
            labelWeryfikacja.Text = "Wpisz znaki , które widzisz na obrazku obok";
            // 
            // labelHaslo
            // 
            labelHaslo.Anchor = AnchorStyles.None;
            labelHaslo.AutoSize = true;
            labelHaslo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelHaslo.Location = new Point(475, 157);
            labelHaslo.Name = "labelHaslo";
            labelHaslo.Size = new Size(66, 30);
            labelHaslo.TabIndex = 15;
            labelHaslo.Text = "Hasło";
            // 
            // labelLogin
            // 
            labelLogin.Anchor = AnchorStyles.None;
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogin.Location = new Point(477, 74);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(64, 30);
            labelLogin.TabIndex = 13;
            labelLogin.Text = "Login";
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
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
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
        private Label labelmail;
        private TextBox textBoxMail;
        private TextBox textBoxWeryfikacja;
        private PictureBox pictureBoxWeryfikacja;
        private Label labelWeryfikacja;
        private Panel panelBar;
        private FontAwesome.Sharp.IconButton iconButtonZamknij;
        private FontAwesome.Sharp.IconButton iconButtonMin;
        private FontAwesome.Sharp.IconButton iconButtonMaks;
        private Label labelLogin;
        private Label labelHaslo;
    }
}