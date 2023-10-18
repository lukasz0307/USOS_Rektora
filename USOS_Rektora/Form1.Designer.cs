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
            Naglowek = new Label();
            panelLogowania = new Panel();
            buttonWroc = new Button();
            buttonDalej = new Button();
            buttonprzypomnij = new Button();
            textBoxMail = new TextBox();
            labelmail = new Label();
            buttonLogin = new Button();
            labelHaslo = new Label();
            textBoxHaslo = new TextBox();
            labelLogin = new Label();
            textBoxLogin = new TextBox();
            labelWeryfikacja = new Label();
            textBoxWeryfikacja = new TextBox();
            panelNaglowka.SuspendLayout();
            panelLogowania.SuspendLayout();
            SuspendLayout();
            // 
            // panelNaglowka
            // 
            panelNaglowka.BackColor = SystemColors.ActiveCaption;
            panelNaglowka.Controls.Add(Naglowek);
            panelNaglowka.Dock = DockStyle.Top;
            panelNaglowka.Location = new Point(0, 0);
            panelNaglowka.Margin = new Padding(3, 2, 3, 2);
            panelNaglowka.Name = "panelNaglowka";
            panelNaglowka.Size = new Size(1034, 112);
            panelNaglowka.TabIndex = 0;
            // 
            // Naglowek
            // 
            Naglowek.Anchor = AnchorStyles.None;
            Naglowek.AutoSize = true;
            Naglowek.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            Naglowek.Location = new Point(465, 33);
            Naglowek.Name = "Naglowek";
            Naglowek.Size = new Size(119, 50);
            Naglowek.TabIndex = 0;
            Naglowek.Text = "USOS";
            // 
            // panelLogowania
            // 
            panelLogowania.Controls.Add(textBoxWeryfikacja);
            panelLogowania.Controls.Add(labelWeryfikacja);
            panelLogowania.Controls.Add(buttonWroc);
            panelLogowania.Controls.Add(buttonDalej);
            panelLogowania.Controls.Add(buttonprzypomnij);
            panelLogowania.Controls.Add(textBoxMail);
            panelLogowania.Controls.Add(labelmail);
            panelLogowania.Controls.Add(buttonLogin);
            panelLogowania.Controls.Add(labelHaslo);
            panelLogowania.Controls.Add(textBoxHaslo);
            panelLogowania.Controls.Add(labelLogin);
            panelLogowania.Controls.Add(textBoxLogin);
            panelLogowania.Dock = DockStyle.Fill;
            panelLogowania.Location = new Point(0, 112);
            panelLogowania.Margin = new Padding(3, 2, 3, 2);
            panelLogowania.Name = "panelLogowania";
            panelLogowania.Size = new Size(1034, 378);
            panelLogowania.TabIndex = 1;
            // 
            // buttonWroc
            // 
            buttonWroc.Anchor = AnchorStyles.None;
            buttonWroc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWroc.Location = new Point(585, 335);
            buttonWroc.Name = "buttonWroc";
            buttonWroc.Size = new Size(85, 31);
            buttonWroc.TabIndex = 7;
            buttonWroc.Text = "Wróć";
            buttonWroc.UseVisualStyleBackColor = true;
            buttonWroc.Visible = false;
            buttonWroc.Click += buttonWroc_Click;
            // 
            // buttonDalej
            // 
            buttonDalej.Anchor = AnchorStyles.None;
            buttonDalej.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDalej.Location = new Point(396, 335);
            buttonDalej.Name = "buttonDalej";
            buttonDalej.Size = new Size(85, 31);
            buttonDalej.TabIndex = 7;
            buttonDalej.Text = "Dalej";
            buttonDalej.UseVisualStyleBackColor = true;
            buttonDalej.Visible = false;
            // 
            // buttonprzypomnij
            // 
            buttonprzypomnij.Location = new Point(523, 314);
            buttonprzypomnij.Name = "buttonprzypomnij";
            buttonprzypomnij.Size = new Size(147, 23);
            buttonprzypomnij.TabIndex = 5;
            buttonprzypomnij.Text = "ZMIEŃ HASŁO";
            buttonprzypomnij.UseVisualStyleBackColor = true;
            buttonprzypomnij.Click += buttonprzypomnij_Click;
            // 
            // textBoxMail
            // 
            textBoxMail.Anchor = AnchorStyles.None;
            textBoxMail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMail.Location = new Point(396, 121);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(274, 35);
            textBoxMail.TabIndex = 0;
            textBoxMail.Visible = false;
            // 
            // labelmail
            // 
            labelmail.Anchor = AnchorStyles.None;
            labelmail.AutoSize = true;
            labelmail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelmail.Location = new Point(465, 88);
            labelmail.Name = "labelmail";
            labelmail.Size = new Size(135, 30);
            labelmail.TabIndex = 1;
            labelmail.Text = "Adres e-mail:";
            labelmail.Visible = false;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(396, 314);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(121, 23);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "ZALOGUJ SIĘ";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelHaslo
            // 
            labelHaslo.Anchor = AnchorStyles.None;
            labelHaslo.AutoSize = true;
            labelHaslo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelHaslo.Location = new Point(501, 212);
            labelHaslo.Name = "labelHaslo";
            labelHaslo.Size = new Size(66, 30);
            labelHaslo.TabIndex = 3;
            labelHaslo.Text = "Hasło";
            // 
            // textBoxHaslo
            // 
            textBoxHaslo.Anchor = AnchorStyles.None;
            textBoxHaslo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxHaslo.Location = new Point(396, 245);
            textBoxHaslo.Name = "textBoxHaslo";
            textBoxHaslo.Size = new Size(274, 35);
            textBoxHaslo.TabIndex = 2;
            // 
            // labelLogin
            // 
            labelLogin.Anchor = AnchorStyles.None;
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogin.Location = new Point(501, 88);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(64, 30);
            labelLogin.TabIndex = 1;
            labelLogin.Text = "Login";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.None;
            textBoxLogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(396, 120);
            textBoxLogin.Margin = new Padding(3, 2, 3, 2);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(274, 36);
            textBoxLogin.TabIndex = 0;
            // 
            // labelWeryfikacja
            // 
            labelWeryfikacja.AutoSize = true;
            labelWeryfikacja.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelWeryfikacja.Location = new Point(315, 212);
            labelWeryfikacja.Name = "labelWeryfikacja";
            labelWeryfikacja.Size = new Size(467, 30);
            labelWeryfikacja.TabIndex = 1;
            labelWeryfikacja.Text = "Wpisz znaki , które widzisz na ponższym obrazku";
            labelWeryfikacja.Visible = false;
            // 
            // textBoxWeryfikacja
            // 
            textBoxWeryfikacja.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxWeryfikacja.Location = new Point(396, 245);
            textBoxWeryfikacja.Name = "textBoxWeryfikacja";
            textBoxWeryfikacja.Size = new Size(274, 35);
            textBoxWeryfikacja.TabIndex = 8;
            textBoxWeryfikacja.Visible = false;
            // 
            // Logowanie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1034, 490);
            Controls.Add(panelLogowania);
            Controls.Add(panelNaglowka);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Logowanie";
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            Load += Form1_Load;
            panelNaglowka.ResumeLayout(false);
            panelNaglowka.PerformLayout();
            panelLogowania.ResumeLayout(false);
            panelLogowania.PerformLayout();
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
    }
}