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
            buttonprzypomnij = new Button();
            buttonLogin = new Button();
            labelHaslo = new Label();
            textBoxHaslo = new TextBox();
            labelLogin = new Label();
            textBoxLogin = new TextBox();
            panel1 = new Panel();
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
            panelLogowania.Controls.Add(panel1);
            panelLogowania.Controls.Add(buttonprzypomnij);
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
            // buttonprzypomnij
            // 
            buttonprzypomnij.Location = new Point(523, 314);
            buttonprzypomnij.Name = "buttonprzypomnij";
            buttonprzypomnij.Size = new Size(147, 23);
            buttonprzypomnij.TabIndex = 5;
            buttonprzypomnij.Text = "PRZYPOMNIJ HASŁO";
            buttonprzypomnij.UseVisualStyleBackColor = true;
            buttonprzypomnij.Click += buttonprzypomnij_Click;
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
            // panel1
            // 
            panel1.Location = new Point(150, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 2;
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
        private Panel panel1;
    }
}