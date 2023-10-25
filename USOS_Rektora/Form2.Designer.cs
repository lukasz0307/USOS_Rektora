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
            iconButtonWydzialy = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            panelPodFormularzy = new Panel();
            panelBanera = new Panel();
            labelTytulu = new Label();
            iconButtonKadra = new FontAwesome.Sharp.IconButton();
            panelNawigacja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBanera.SuspendLayout();
            SuspendLayout();
            // 
            // panelNawigacja
            // 
            panelNawigacja.BackColor = SystemColors.Highlight;
            panelNawigacja.Controls.Add(iconButtonKadra);
            panelNawigacja.Controls.Add(iconButtonWydzialy);
            panelNawigacja.Controls.Add(pictureBox1);
            panelNawigacja.Dock = DockStyle.Left;
            panelNawigacja.Location = new Point(0, 0);
            panelNawigacja.Margin = new Padding(3, 2, 3, 2);
            panelNawigacja.Name = "panelNawigacja";
            panelNawigacja.Size = new Size(219, 490);
            panelNawigacja.TabIndex = 0;
            // 
            // iconButtonWydzialy
            // 
            iconButtonWydzialy.Anchor = AnchorStyles.None;
            iconButtonWydzialy.FlatAppearance.BorderSize = 0;
            iconButtonWydzialy.FlatStyle = FlatStyle.Flat;
            iconButtonWydzialy.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonWydzialy.ForeColor = SystemColors.ControlLightLight;
            iconButtonWydzialy.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            iconButtonWydzialy.IconColor = Color.White;
            iconButtonWydzialy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonWydzialy.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonWydzialy.Location = new Point(0, 97);
            iconButtonWydzialy.Name = "iconButtonWydzialy";
            iconButtonWydzialy.Size = new Size(219, 38);
            iconButtonWydzialy.TabIndex = 0;
            iconButtonWydzialy.Text = "Wydziały";
            iconButtonWydzialy.UseVisualStyleBackColor = true;
            iconButtonWydzialy.Click += iconButtonWydzialy_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 92);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelPodFormularzy
            // 
            panelPodFormularzy.Dock = DockStyle.Fill;
            panelPodFormularzy.Location = new Point(219, 0);
            panelPodFormularzy.Margin = new Padding(3, 2, 3, 2);
            panelPodFormularzy.Name = "panelPodFormularzy";
            panelPodFormularzy.Size = new Size(815, 490);
            panelPodFormularzy.TabIndex = 1;
            // 
            // panelBanera
            // 
            panelBanera.BackColor = SystemColors.Highlight;
            panelBanera.Controls.Add(labelTytulu);
            panelBanera.Dock = DockStyle.Top;
            panelBanera.Location = new Point(219, 0);
            panelBanera.Margin = new Padding(3, 2, 3, 2);
            panelBanera.Name = "panelBanera";
            panelBanera.Size = new Size(815, 92);
            panelBanera.TabIndex = 2;
            // 
            // labelTytulu
            // 
            labelTytulu.Anchor = AnchorStyles.None;
            labelTytulu.AutoSize = true;
            labelTytulu.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelTytulu.ForeColor = SystemColors.Control;
            labelTytulu.Location = new Point(360, 26);
            labelTytulu.Name = "labelTytulu";
            labelTytulu.Size = new Size(130, 51);
            labelTytulu.TabIndex = 0;
            labelTytulu.Text = "Home";
            // 
            // iconButtonKadra
            // 
            iconButtonKadra.Anchor = AnchorStyles.None;
            iconButtonKadra.FlatAppearance.BorderSize = 0;
            iconButtonKadra.FlatStyle = FlatStyle.Flat;
            iconButtonKadra.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonKadra.ForeColor = SystemColors.ControlLightLight;
            iconButtonKadra.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            iconButtonKadra.IconColor = Color.White;
            iconButtonKadra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonKadra.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonKadra.Location = new Point(0, 152);
            iconButtonKadra.Name = "iconButtonKadra";
            iconButtonKadra.Size = new Size(219, 38);
            iconButtonKadra.TabIndex = 1;
            iconButtonKadra.Text = "Kadra";
            iconButtonKadra.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 490);
            Controls.Add(panelBanera);
            Controls.Add(panelPodFormularzy);
            Controls.Add(panelNawigacja);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Form2";
            panelNawigacja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBanera.ResumeLayout(false);
            panelBanera.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNawigacja;
        private Panel panelPodFormularzy;
        private Panel panelBanera;
        private Label labelTytulu;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButtonWydzialy;
        private FontAwesome.Sharp.IconButton iconButtonKadra;
    }
}