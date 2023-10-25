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
            panelMain = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            panelNaglowka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelMain.SuspendLayout();
            tabControl1.SuspendLayout();
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
            panelNaglowka.Size = new Size(1482, 131);
            panelNaglowka.TabIndex = 0;
            panelNaglowka.Paint += panelNaglowka_Paint;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Anchor = AnchorStyles.None;
            pictureBoxLogo.Location = new Point(194, -2);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(209, 135);
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // Naglowek
            // 
            Naglowek.Anchor = AnchorStyles.None;
            Naglowek.AutoSize = true;
            Naglowek.Font = new Font("Segoe UI", 23F, FontStyle.Bold, GraphicsUnit.Point);
            Naglowek.ForeColor = SystemColors.ControlLightLight;
            Naglowek.Location = new Point(698, 42);
            Naglowek.Name = "Naglowek";
            Naglowek.Size = new Size(124, 52);
            Naglowek.TabIndex = 0;
            Naglowek.Text = "USOS";
            // 
            // panelMain
            // 
            panelMain.Controls.Add(tabControl1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 131);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1482, 722);
            panelMain.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(653, 227);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(250, 125);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(242, 92);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(242, 92);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Logowanie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1482, 853);
            Controls.Add(panelMain);
            Controls.Add(panelNaglowka);
            Name = "Logowanie";
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            Load += Form1_Load;
            panelNaglowka.ResumeLayout(false);
            panelNaglowka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelMain.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNaglowka;
        private Label Naglowek;
        private Panel panelMain;
        private PictureBox pictureBoxLogo;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}