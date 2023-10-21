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
            pictureBoxLogo = new PictureBox();
            Naglowek = new Label();
            panelLogowania = new Panel();
            tabControlLogowanie = new TabControl();
            tabPage1 = new TabPage();
            labelLogin = new Label();
            textBoxLogin = new TextBox();
            labelHaslo = new Label();
            buttonprzypomnij = new Button();
            textBoxHaslo = new TextBox();
            buttonLogin = new Button();
            tabPage2 = new TabPage();
            labelmail = new Label();
            buttonWroc = new Button();
            buttonlosuj = new Button();
            buttonDalej = new Button();
            textBoxMail = new TextBox();
            pictureBoxWeryfikacja = new PictureBox();
            labelWeryfikacja = new Label();
            textBoxWeryfikacja = new TextBox();
            panelNaglowka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelLogowania.SuspendLayout();
            tabControlLogowanie.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWeryfikacja).BeginInit();
            SuspendLayout();
            // 
            // panelNaglowka
            // 
            panelNaglowka.BackColor = SystemColors.ActiveCaption;
            panelNaglowka.Controls.Add(pictureBoxLogo);
            panelNaglowka.Controls.Add(Naglowek);
            panelNaglowka.Dock = DockStyle.Top;
            panelNaglowka.Location = new Point(0, 0);
            panelNaglowka.Name = "panelNaglowka";
            panelNaglowka.Size = new Size(1182, 135);
            panelNaglowka.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Anchor = AnchorStyles.None;
            pictureBoxLogo.Location = new Point(44, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(209, 135);
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // Naglowek
            // 
            Naglowek.Anchor = AnchorStyles.None;
            Naglowek.AutoSize = true;
            Naglowek.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            Naglowek.ForeColor = SystemColors.ControlLightLight;
            Naglowek.Location = new Point(531, 37);
            Naglowek.Name = "Naglowek";
            Naglowek.Size = new Size(149, 62);
            Naglowek.TabIndex = 0;
            Naglowek.Text = "USOS";
            // 
            // panelLogowania
            // 
            panelLogowania.Controls.Add(tabControlLogowanie);
            panelLogowania.Dock = DockStyle.Fill;
            panelLogowania.Location = new Point(0, 135);
            panelLogowania.Name = "panelLogowania";
            panelLogowania.Size = new Size(1182, 518);
            panelLogowania.TabIndex = 1;
            // 
            // tabControlLogowanie
            // 
            tabControlLogowanie.Anchor = AnchorStyles.None;
            tabControlLogowanie.Appearance = TabAppearance.FlatButtons;
            tabControlLogowanie.Controls.Add(tabPage1);
            tabControlLogowanie.Controls.Add(tabPage2);
            tabControlLogowanie.ItemSize = new Size(0, 10);
            tabControlLogowanie.Location = new Point(12, 6);
            tabControlLogowanie.Name = "tabControlLogowanie";
            tabControlLogowanie.SelectedIndex = 0;
            tabControlLogowanie.Size = new Size(1167, 509);
            tabControlLogowanie.TabIndex = 10;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(labelLogin);
            tabPage1.Controls.Add(textBoxLogin);
            tabPage1.Controls.Add(labelHaslo);
            tabPage1.Controls.Add(buttonprzypomnij);
            tabPage1.Controls.Add(textBoxHaslo);
            tabPage1.Controls.Add(buttonLogin);
            tabPage1.Location = new Point(4, 14);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1159, 491);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelLogin
            // 
            labelLogin.Anchor = AnchorStyles.None;
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogin.Location = new Point(530, 134);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(84, 37);
            labelLogin.TabIndex = 1;
            labelLogin.Text = "Login";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.None;
            textBoxLogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(422, 174);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(313, 43);
            textBoxLogin.TabIndex = 0;
            // 
            // labelHaslo
            // 
            labelHaslo.Anchor = AnchorStyles.None;
            labelHaslo.AutoSize = true;
            labelHaslo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelHaslo.Location = new Point(530, 246);
            labelHaslo.Name = "labelHaslo";
            labelHaslo.Size = new Size(84, 37);
            labelHaslo.TabIndex = 3;
            labelHaslo.Text = "Hasło";
            // 
            // buttonprzypomnij
            // 
            buttonprzypomnij.Anchor = AnchorStyles.None;
            buttonprzypomnij.Location = new Point(566, 362);
            buttonprzypomnij.Margin = new Padding(3, 4, 3, 4);
            buttonprzypomnij.Name = "buttonprzypomnij";
            buttonprzypomnij.Size = new Size(168, 31);
            buttonprzypomnij.TabIndex = 5;
            buttonprzypomnij.Text = "ZMIEŃ HASŁO";
            buttonprzypomnij.UseVisualStyleBackColor = true;
            buttonprzypomnij.Click += buttonprzypomnij_Click;
            // 
            // textBoxHaslo
            // 
            textBoxHaslo.Anchor = AnchorStyles.None;
            textBoxHaslo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxHaslo.Location = new Point(422, 287);
            textBoxHaslo.Margin = new Padding(3, 4, 3, 4);
            textBoxHaslo.Name = "textBoxHaslo";
            textBoxHaslo.Size = new Size(313, 42);
            textBoxHaslo.TabIndex = 2;
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.None;
            buttonLogin.Location = new Point(422, 362);
            buttonLogin.Margin = new Padding(3, 4, 3, 4);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(138, 31);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "ZALOGUJ SIĘ";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(labelmail);
            tabPage2.Controls.Add(buttonWroc);
            tabPage2.Controls.Add(buttonlosuj);
            tabPage2.Controls.Add(buttonDalej);
            tabPage2.Controls.Add(textBoxMail);
            tabPage2.Controls.Add(pictureBoxWeryfikacja);
            tabPage2.Controls.Add(labelWeryfikacja);
            tabPage2.Controls.Add(textBoxWeryfikacja);
            tabPage2.Location = new Point(4, 14);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1159, 491);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelmail
            // 
            labelmail.Anchor = AnchorStyles.None;
            labelmail.AutoSize = true;
            labelmail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelmail.Location = new Point(488, 144);
            labelmail.Name = "labelmail";
            labelmail.Size = new Size(173, 37);
            labelmail.TabIndex = 1;
            labelmail.Text = "Adres e-mail:";
            // 
            // buttonWroc
            // 
            buttonWroc.Anchor = AnchorStyles.None;
            buttonWroc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWroc.Location = new Point(639, 366);
            buttonWroc.Margin = new Padding(3, 4, 3, 4);
            buttonWroc.Name = "buttonWroc";
            buttonWroc.Size = new Size(97, 41);
            buttonWroc.TabIndex = 7;
            buttonWroc.Text = "Wróć";
            buttonWroc.UseVisualStyleBackColor = true;
            buttonWroc.Click += buttonWroc_Click;
            // 
            // buttonlosuj
            // 
            buttonlosuj.Anchor = AnchorStyles.None;
            buttonlosuj.Location = new Point(232, 347);
            buttonlosuj.Name = "buttonlosuj";
            buttonlosuj.Size = new Size(87, 29);
            buttonlosuj.TabIndex = 9;
            buttonlosuj.Text = "losuj nowy";
            buttonlosuj.UseVisualStyleBackColor = true;
            // 
            // buttonDalej
            // 
            buttonDalej.Anchor = AnchorStyles.None;
            buttonDalej.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDalej.Location = new Point(423, 366);
            buttonDalej.Margin = new Padding(3, 4, 3, 4);
            buttonDalej.Name = "buttonDalej";
            buttonDalej.Size = new Size(97, 41);
            buttonDalej.TabIndex = 7;
            buttonDalej.Text = "Dalej";
            buttonDalej.UseVisualStyleBackColor = true;
            // 
            // textBoxMail
            // 
            textBoxMail.Anchor = AnchorStyles.None;
            textBoxMail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMail.Location = new Point(423, 185);
            textBoxMail.Margin = new Padding(3, 4, 3, 4);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(313, 42);
            textBoxMail.TabIndex = 0;
            // 
            // pictureBoxWeryfikacja
            // 
            pictureBoxWeryfikacja.Anchor = AnchorStyles.None;
            pictureBoxWeryfikacja.Location = new Point(204, 299);
            pictureBoxWeryfikacja.Name = "pictureBoxWeryfikacja";
            pictureBoxWeryfikacja.Size = new Size(140, 42);
            pictureBoxWeryfikacja.TabIndex = 2;
            pictureBoxWeryfikacja.TabStop = false;
            // 
            // labelWeryfikacja
            // 
            labelWeryfikacja.Anchor = AnchorStyles.None;
            labelWeryfikacja.AutoSize = true;
            labelWeryfikacja.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelWeryfikacja.Location = new Point(327, 258);
            labelWeryfikacja.Name = "labelWeryfikacja";
            labelWeryfikacja.Size = new Size(535, 37);
            labelWeryfikacja.TabIndex = 1;
            labelWeryfikacja.Text = "Wpisz znaki , które widzisz na obrazku obok";
            // 
            // textBoxWeryfikacja
            // 
            textBoxWeryfikacja.Anchor = AnchorStyles.None;
            textBoxWeryfikacja.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxWeryfikacja.Location = new Point(423, 299);
            textBoxWeryfikacja.Margin = new Padding(3, 4, 3, 4);
            textBoxWeryfikacja.Name = "textBoxWeryfikacja";
            textBoxWeryfikacja.Size = new Size(313, 42);
            textBoxWeryfikacja.TabIndex = 8;
            // 
            // Logowanie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1182, 653);
            Controls.Add(panelLogowania);
            Controls.Add(panelNaglowka);
            Name = "Logowanie";
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            Load += Form1_Load;
            panelNaglowka.ResumeLayout(false);
            panelNaglowka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelLogowania.ResumeLayout(false);
            tabControlLogowanie.ResumeLayout(false);
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
        private TextBox textBoxLogin;
        private Label labelLogin;
        private Label labelHaslo;
        private TextBox textBoxHaslo;
        private Button buttonLogin;
        private Button buttonprzypomnij;
        private Label labelmail;
        private TextBox textBoxMail;
        private Button buttonWroc;
        private Button buttonDalej;
        private Label labelWeryfikacja;
        private TextBox textBoxWeryfikacja;
        private PictureBox pictureBoxLogo;
        private PictureBox pictureBoxWeryfikacja;
        private Button buttonlosuj;
        private TabControl tabControlLogowanie;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}