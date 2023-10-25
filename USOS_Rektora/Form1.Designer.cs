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
            panelNaglowka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
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
            panelLogowania.Dock = DockStyle.Fill;
            panelLogowania.Location = new Point(0, 135);
            panelLogowania.Name = "panelLogowania";
            panelLogowania.Size = new Size(1182, 518);
            panelLogowania.TabIndex = 1;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNaglowka;
        private Label Naglowek;
        private Panel panelLogowania;
        private PictureBox pictureBoxLogo;
    }
}