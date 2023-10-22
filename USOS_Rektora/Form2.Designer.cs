namespace USOS_Rektora
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelNawigacja = new Panel();
            buttonKadra = new Button();
            buttonWydzialy = new Button();
            panelLogo = new Panel();
            panelPodFormularzy = new Panel();
            panelBanera = new Panel();
            labelTytulu = new Label();
            panelNawigacja.SuspendLayout();
            panelBanera.SuspendLayout();
            SuspendLayout();
            // 
            // panelNawigacja
            // 
            panelNawigacja.BackColor = SystemColors.Highlight;
            panelNawigacja.Controls.Add(buttonKadra);
            panelNawigacja.Controls.Add(buttonWydzialy);
            panelNawigacja.Controls.Add(panelLogo);
            panelNawigacja.Dock = DockStyle.Left;
            panelNawigacja.Location = new Point(0, 0);
            panelNawigacja.Name = "panelNawigacja";
            panelNawigacja.Size = new Size(250, 471);
            panelNawigacja.TabIndex = 0;
            // 
            // buttonKadra
            // 
            buttonKadra.Anchor = AnchorStyles.None;
            buttonKadra.Location = new Point(0, 184);
            buttonKadra.Name = "buttonKadra";
            buttonKadra.Size = new Size(250, 50);
            buttonKadra.TabIndex = 3;
            buttonKadra.Text = "button2";
            buttonKadra.UseVisualStyleBackColor = true;
            // 
            // buttonWydzialy
            // 
            buttonWydzialy.Anchor = AnchorStyles.None;
            buttonWydzialy.Location = new Point(0, 128);
            buttonWydzialy.Name = "buttonWydzialy";
            buttonWydzialy.Size = new Size(250, 50);
            buttonWydzialy.TabIndex = 2;
            buttonWydzialy.Text = "Wydziały";
            buttonWydzialy.UseVisualStyleBackColor = true;
            buttonWydzialy.Click += buttonWydzialy_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = SystemColors.HotTrack;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 122);
            panelLogo.TabIndex = 1;
            // 
            // panelPodFormularzy
            // 
            panelPodFormularzy.Dock = DockStyle.Fill;
            panelPodFormularzy.Location = new Point(250, 0);
            panelPodFormularzy.Name = "panelPodFormularzy";
            panelPodFormularzy.Size = new Size(914, 471);
            panelPodFormularzy.TabIndex = 1;
            // 
            // panelBanera
            // 
            panelBanera.BackColor = SystemColors.HotTrack;
            panelBanera.Controls.Add(labelTytulu);
            panelBanera.Dock = DockStyle.Top;
            panelBanera.Location = new Point(250, 0);
            panelBanera.Name = "panelBanera";
            panelBanera.Size = new Size(914, 122);
            panelBanera.TabIndex = 2;
            // 
            // labelTytulu
            // 
            labelTytulu.Anchor = AnchorStyles.None;
            labelTytulu.AutoSize = true;
            labelTytulu.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelTytulu.ForeColor = SystemColors.Control;
            labelTytulu.Location = new Point(404, 34);
            labelTytulu.Name = "labelTytulu";
            labelTytulu.Size = new Size(160, 62);
            labelTytulu.TabIndex = 0;
            labelTytulu.Text = "Home";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 471);
            Controls.Add(panelBanera);
            Controls.Add(panelPodFormularzy);
            Controls.Add(panelNawigacja);
            Name = "Form2";
            Text = "Form2";
            panelNawigacja.ResumeLayout(false);
            panelBanera.ResumeLayout(false);
            panelBanera.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNawigacja;
        private Panel panelLogo;
        private Button buttonKadra;
        private Button buttonWydzialy;
        private Panel panelPodFormularzy;
        private Panel panelBanera;
        private Label labelTytulu;
    }
}