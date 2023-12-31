﻿namespace USOS_Rektora.userControls
{
    partial class dodWydarz
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
            panel1 = new Panel();
            iconButtonZamknij = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            panel3 = new Panel();
            Zatw = new Button();
            textBoxWyd = new TextBox();
            data = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(iconButtonZamknij);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 36);
            panel1.TabIndex = 0;
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
            iconButtonZamknij.Location = new Point(313, 0);
            iconButtonZamknij.Margin = new Padding(0);
            iconButtonZamknij.Name = "iconButtonZamknij";
            iconButtonZamknij.Size = new Size(52, 36);
            iconButtonZamknij.TabIndex = 1;
            iconButtonZamknij.UseVisualStyleBackColor = false;
            iconButtonZamknij.Click += iconButtonZamknij_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(Zatw);
            panel2.Controls.Add(textBoxWyd);
            panel2.Controls.Add(data);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 36);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(365, 168);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 132);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(365, 36);
            panel3.TabIndex = 3;
            // 
            // Zatw
            // 
            Zatw.Anchor = AnchorStyles.None;
            Zatw.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Zatw.Location = new Point(135, 84);
            Zatw.Margin = new Padding(135, 3, 135, 3);
            Zatw.Name = "Zatw";
            Zatw.Size = new Size(95, 29);
            Zatw.TabIndex = 2;
            Zatw.Text = "Zatwierdź";
            Zatw.UseVisualStyleBackColor = true;
            Zatw.Click += Zatw_Click;
            // 
            // textBoxWyd
            // 
            textBoxWyd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxWyd.Location = new Point(49, 45);
            textBoxWyd.Margin = new Padding(40, 3, 40, 3);
            textBoxWyd.Name = "textBoxWyd";
            textBoxWyd.Size = new Size(267, 33);
            textBoxWyd.TabIndex = 1;
            // 
            // data
            // 
            data.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            data.Location = new Point(9, 14);
            data.Margin = new Padding(0);
            data.Name = "data";
            data.Size = new Size(347, 28);
            data.TabIndex = 0;
            data.Text = "dd/mm/yyyy";
            data.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dodWydarz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 204);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "dodWydarz";
            StartPosition = FormStartPosition.CenterScreen;
            Load += dodWydarz_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonZamknij;
        private Panel panel2;
        private Button Zatw;
        private TextBox textBoxWyd;
        private Label data;
        private Panel panel3;
    }
}