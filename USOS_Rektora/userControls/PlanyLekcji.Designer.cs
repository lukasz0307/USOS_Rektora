namespace USOS_Rektora.userControls
{
    partial class PlanyLekcji
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
            panel1 = new Panel();
            panel5 = new Panel();
            buttonPokaz = new Button();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            comboBoxKierunek = new ComboBox();
            comboBoxStopien = new ComboBox();
            comboBoxTryb = new ComboBox();
            comboBoxWydzial = new ComboBox();
            buttonPobierz = new Button();
            saveFileDialog = new SaveFileDialog();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(buttonPobierz);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 483);
            panel1.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(buttonPokaz);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(comboBoxKierunek);
            panel5.Controls.Add(comboBoxStopien);
            panel5.Controls.Add(comboBoxTryb);
            panel5.Controls.Add(comboBoxWydzial);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 483);
            panel5.TabIndex = 11;
            // 
            // buttonPokaz
            // 
            buttonPokaz.Anchor = AnchorStyles.None;
            buttonPokaz.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPokaz.Location = new Point(24, 392);
            buttonPokaz.Margin = new Padding(3, 4, 3, 4);
            buttonPokaz.Name = "buttonPokaz";
            buttonPokaz.Size = new Size(196, 43);
            buttonPokaz.TabIndex = 8;
            buttonPokaz.Text = "Pokaż Plan";
            buttonPokaz.UseVisualStyleBackColor = true;
            buttonPokaz.Click += buttonPokaz_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(7, 278);
            label4.Name = "label4";
            label4.Size = new Size(240, 51);
            label4.TabIndex = 5;
            label4.Text = "Kierunek:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 170);
            label3.Name = "label3";
            label3.Size = new Size(244, 48);
            label3.TabIndex = 5;
            label3.Text = "Wydział:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 18);
            label1.Name = "label1";
            label1.Size = new Size(244, 44);
            label1.TabIndex = 5;
            label1.Text = "Studia:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxKierunek
            // 
            comboBoxKierunek.Anchor = AnchorStyles.None;
            comboBoxKierunek.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxKierunek.FormattingEnabled = true;
            comboBoxKierunek.Location = new Point(24, 333);
            comboBoxKierunek.Margin = new Padding(3, 4, 3, 4);
            comboBoxKierunek.Name = "comboBoxKierunek";
            comboBoxKierunek.Size = new Size(196, 36);
            comboBoxKierunek.TabIndex = 4;
            // 
            // comboBoxStopien
            // 
            comboBoxStopien.Anchor = AnchorStyles.None;
            comboBoxStopien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxStopien.FormattingEnabled = true;
            comboBoxStopien.Items.AddRange(new object[] { "I stopnia", "II stopnia" });
            comboBoxStopien.Location = new Point(24, 66);
            comboBoxStopien.Margin = new Padding(3, 4, 3, 4);
            comboBoxStopien.Name = "comboBoxStopien";
            comboBoxStopien.Size = new Size(196, 36);
            comboBoxStopien.TabIndex = 0;
            comboBoxStopien.SelectedIndexChanged += comboBoxStopien_SelectedIndexChanged;
            // 
            // comboBoxTryb
            // 
            comboBoxTryb.Anchor = AnchorStyles.None;
            comboBoxTryb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTryb.FormattingEnabled = true;
            comboBoxTryb.Items.AddRange(new object[] { "Stacjonarne", "NIe stacjonarne" });
            comboBoxTryb.Location = new Point(24, 119);
            comboBoxTryb.Margin = new Padding(3, 4, 3, 4);
            comboBoxTryb.Name = "comboBoxTryb";
            comboBoxTryb.Size = new Size(196, 36);
            comboBoxTryb.TabIndex = 2;
            // 
            // comboBoxWydzial
            // 
            comboBoxWydzial.Anchor = AnchorStyles.None;
            comboBoxWydzial.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxWydzial.FormattingEnabled = true;
            comboBoxWydzial.Items.AddRange(new object[] { "Elektryczny", "Mechaniczny", "Nawigacyjny", "Wydział zarządzania i nauk o jakości" });
            comboBoxWydzial.Location = new Point(24, 222);
            comboBoxWydzial.Margin = new Padding(3, 4, 3, 4);
            comboBoxWydzial.Name = "comboBoxWydzial";
            comboBoxWydzial.Size = new Size(196, 36);
            comboBoxWydzial.TabIndex = 6;
            comboBoxWydzial.SelectedIndexChanged += comboBoxWydzial_SelectedIndexChanged;
            // 
            // buttonPobierz
            // 
            buttonPobierz.Anchor = AnchorStyles.None;
            buttonPobierz.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPobierz.Location = new Point(318, 436);
            buttonPobierz.Margin = new Padding(3, 4, 3, 4);
            buttonPobierz.Name = "buttonPobierz";
            buttonPobierz.Size = new Size(197, 43);
            buttonPobierz.TabIndex = 7;
            buttonPobierz.Text = "Pobierz Plan";
            buttonPobierz.UseVisualStyleBackColor = true;
            buttonPobierz.Click += buttonPobierz_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(528, 154);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 198);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // PlanyLekcji
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PlanyLekcji";
            Size = new Size(896, 483);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBoxWydzial;
        private Label label3;
        private ComboBox comboBoxKierunek;
        private ComboBox comboBoxTryb;
        private ComboBox comboBoxStopien;
        private Button buttonPobierz;
        private Label label4;
        private Label label1;
        private SaveFileDialog saveFileDialog;
        private Panel panel5;
        private Button buttonPokaz;
        private PictureBox pictureBox1;
    }
}
