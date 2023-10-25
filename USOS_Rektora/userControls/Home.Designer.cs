namespace USOS_Rektora.userControls
{
    partial class Home
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
            panelPodFormularzy = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panelBanera = new Panel();
            labelHome = new Label();
            panelNawigacja = new Panel();
            pictureBox1 = new PictureBox();
            buttonKadra = new Button();
            buttonWydzialy = new Button();
            panelPodFormularzy.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panelBanera.SuspendLayout();
            panelNawigacja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelPodFormularzy
            // 
            panelPodFormularzy.Controls.Add(panel1);
            panelPodFormularzy.Dock = DockStyle.Fill;
            panelPodFormularzy.Location = new Point(0, 0);
            panelPodFormularzy.Name = "panelPodFormularzy";
            panelPodFormularzy.Size = new Size(1200, 700);
            panelPodFormularzy.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 700);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1200, 700);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1200, 700);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(panelNawigacja);
            panel4.Controls.Add(panelBanera);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1200, 700);
            panel4.TabIndex = 2;
            // 
            // panelBanera
            // 
            panelBanera.BackColor = SystemColors.HotTrack;
            panelBanera.Controls.Add(pictureBox1);
            panelBanera.Controls.Add(labelHome);
            panelBanera.Dock = DockStyle.Top;
            panelBanera.Location = new Point(0, 0);
            panelBanera.Name = "panelBanera";
            panelBanera.Size = new Size(1200, 130);
            panelBanera.TabIndex = 0;
            panelBanera.Paint += panel5_Paint;
            // 
            // labelHome
            // 
            labelHome.Anchor = AnchorStyles.None;
            labelHome.AutoSize = true;
            labelHome.BackColor = SystemColors.HotTrack;
            labelHome.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            labelHome.ForeColor = SystemColors.ButtonFace;
            labelHome.Location = new Point(659, 23);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(160, 62);
            labelHome.TabIndex = 0;
            labelHome.Text = "Home";
            // 
            // panelNawigacja
            // 
            panelNawigacja.BackColor = SystemColors.HotTrack;
            panelNawigacja.Controls.Add(buttonKadra);
            panelNawigacja.Controls.Add(buttonWydzialy);
            panelNawigacja.Dock = DockStyle.Left;
            panelNawigacja.Location = new Point(0, 130);
            panelNawigacja.Name = "panelNawigacja";
            panelNawigacja.Size = new Size(250, 570);
            panelNawigacja.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 130);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // buttonKadra
            // 
            buttonKadra.Anchor = AnchorStyles.None;
            buttonKadra.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonKadra.Location = new Point(0, 80);
            buttonKadra.Name = "buttonKadra";
            buttonKadra.Size = new Size(250, 50);
            buttonKadra.TabIndex = 3;
            buttonKadra.Text = "Kadra";
            buttonKadra.UseVisualStyleBackColor = true;
            // 
            // buttonWydzialy
            // 
            buttonWydzialy.Anchor = AnchorStyles.None;
            buttonWydzialy.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWydzialy.Location = new Point(0, 15);
            buttonWydzialy.Name = "buttonWydzialy";
            buttonWydzialy.Size = new Size(250, 50);
            buttonWydzialy.TabIndex = 2;
            buttonWydzialy.Text = "Wydziały";
            buttonWydzialy.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelPodFormularzy);
            Name = "Home";
            Size = new Size(1200, 700);
            panelPodFormularzy.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panelBanera.ResumeLayout(false);
            panelBanera.PerformLayout();
            panelNawigacja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPodFormularzy;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panelBanera;
        private Label labelHome;
        private Panel panelNawigacja;
        private PictureBox pictureBox1;
        private Button buttonKadra;
        private Button buttonWydzialy;
    }
}
