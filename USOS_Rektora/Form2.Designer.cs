﻿namespace USOS_Rektora
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
            panelPodFormularzy = new Panel();
            panelBanera = new Panel();
            labelTytulu = new Label();
            pictureBox1 = new PictureBox();
            panelNawigacja.SuspendLayout();
            panelBanera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelNawigacja
            // 
            panelNawigacja.BackColor = SystemColors.Highlight;
            panelNawigacja.Controls.Add(pictureBox1);
            panelNawigacja.Controls.Add(buttonKadra);
            panelNawigacja.Controls.Add(buttonWydzialy);
            panelNawigacja.Dock = DockStyle.Left;
            panelNawigacja.Location = new Point(0, 0);
            panelNawigacja.Name = "panelNawigacja";
            panelNawigacja.Size = new Size(250, 653);
            panelNawigacja.TabIndex = 0;
            // 
            // buttonKadra
            // 
            buttonKadra.Anchor = AnchorStyles.None;
            buttonKadra.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonKadra.Location = new Point(0, 197);
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
            buttonWydzialy.Location = new Point(0, 141);
            buttonWydzialy.Name = "buttonWydzialy";
            buttonWydzialy.Size = new Size(250, 50);
            buttonWydzialy.TabIndex = 2;
            buttonWydzialy.Text = "Wydziały";
            buttonWydzialy.UseVisualStyleBackColor = true;
            buttonWydzialy.Click += buttonWydzialy_Click;
            // 
            // panelPodFormularzy
            // 
            panelPodFormularzy.Dock = DockStyle.Fill;
            panelPodFormularzy.Location = new Point(250, 0);
            panelPodFormularzy.Name = "panelPodFormularzy";
            panelPodFormularzy.Size = new Size(932, 653);
            panelPodFormularzy.TabIndex = 1;
            // 
            // panelBanera
            // 
            panelBanera.BackColor = SystemColors.HotTrack;
            panelBanera.Controls.Add(labelTytulu);
            panelBanera.Dock = DockStyle.Top;
            panelBanera.Location = new Point(250, 0);
            panelBanera.Name = "panelBanera";
            panelBanera.Size = new Size(932, 122);
            panelBanera.TabIndex = 2;
            // 
            // labelTytulu
            // 
            labelTytulu.Anchor = AnchorStyles.None;
            labelTytulu.AutoSize = true;
            labelTytulu.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelTytulu.ForeColor = SystemColors.Control;
            labelTytulu.Location = new Point(413, 34);
            labelTytulu.Name = "labelTytulu";
            labelTytulu.Size = new Size(160, 62);
            labelTytulu.TabIndex = 0;
            labelTytulu.Text = "Home";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 122);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(panelBanera);
            Controls.Add(panelPodFormularzy);
            Controls.Add(panelNawigacja);
            Name = "Form2";
            Text = "Form2";
            panelNawigacja.ResumeLayout(false);
            panelBanera.ResumeLayout(false);
            panelBanera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNawigacja;
        private Button buttonKadra;
        private Button buttonWydzialy;
        private Panel panelPodFormularzy;
        private Panel panelBanera;
        private Label labelTytulu;
        private PictureBox pictureBox1;
    }
}