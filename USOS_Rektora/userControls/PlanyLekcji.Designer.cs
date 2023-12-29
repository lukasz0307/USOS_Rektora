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
            panel4 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            buttonPobierz = new Button();
            comboBoxWydzial = new ComboBox();
            comboBoxKierunek = new ComboBox();
            comboBoxTryb = new ComboBox();
            comboBoxStopien = new ComboBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(buttonPobierz);
            panel1.Controls.Add(comboBoxWydzial);
            panel1.Controls.Add(comboBoxKierunek);
            panel1.Controls.Add(comboBoxTryb);
            panel1.Controls.Add(comboBoxStopien);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 483);
            panel1.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.Controls.Add(label4);
            panel4.Location = new Point(0, 291);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(896, 51);
            panel4.TabIndex = 10;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(896, 51);
            label4.TabIndex = 5;
            label4.Text = "Kierunek:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(3, 37);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(896, 51);
            panel3.TabIndex = 9;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(896, 51);
            label1.TabIndex = 5;
            label1.Text = "Studia:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 189);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(896, 51);
            panel2.TabIndex = 8;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(896, 51);
            label3.TabIndex = 5;
            label3.Text = "Wydział:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonPobierz
            // 
            buttonPobierz.Anchor = AnchorStyles.None;
            buttonPobierz.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPobierz.Location = new Point(350, 404);
            buttonPobierz.Margin = new Padding(3, 4, 3, 4);
            buttonPobierz.Name = "buttonPobierz";
            buttonPobierz.Size = new Size(197, 43);
            buttonPobierz.TabIndex = 7;
            buttonPobierz.Text = "Pobierz Plan";
            buttonPobierz.UseVisualStyleBackColor = true;
            buttonPobierz.Click += buttonPobierz_Click;
            // 
            // comboBoxWydzial
            // 
            comboBoxWydzial.Anchor = AnchorStyles.None;
            comboBoxWydzial.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxWydzial.FormattingEnabled = true;
            comboBoxWydzial.Items.AddRange(new object[] { "Elektryczny", "Mechaniczny", "Nawigacyjny", "Wydział zarządzania i nauk o jakości" });
            comboBoxWydzial.Location = new Point(313, 248);
            comboBoxWydzial.Margin = new Padding(3, 4, 3, 4);
            comboBoxWydzial.Name = "comboBoxWydzial";
            comboBoxWydzial.Size = new Size(270, 36);
            comboBoxWydzial.TabIndex = 6;
            comboBoxWydzial.SelectedIndexChanged += comboBoxWydzial_SelectedIndexChanged;
            // 
            // comboBoxKierunek
            // 
            comboBoxKierunek.Anchor = AnchorStyles.None;
            comboBoxKierunek.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxKierunek.FormattingEnabled = true;
            comboBoxKierunek.Location = new Point(313, 345);
            comboBoxKierunek.Margin = new Padding(3, 4, 3, 4);
            comboBoxKierunek.Name = "comboBoxKierunek";
            comboBoxKierunek.Size = new Size(270, 36);
            comboBoxKierunek.TabIndex = 4;
            comboBoxKierunek.SelectedIndexChanged += comboBoxKierunek_SelectedIndexChanged;
            // 
            // comboBoxTryb
            // 
            comboBoxTryb.Anchor = AnchorStyles.None;
            comboBoxTryb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTryb.FormattingEnabled = true;
            comboBoxTryb.Items.AddRange(new object[] { "Stacjonarne", "NIe stacjonarne" });
            comboBoxTryb.Location = new Point(313, 147);
            comboBoxTryb.Margin = new Padding(3, 4, 3, 4);
            comboBoxTryb.Name = "comboBoxTryb";
            comboBoxTryb.Size = new Size(270, 36);
            comboBoxTryb.TabIndex = 2;
            // 
            // comboBoxStopien
            // 
            comboBoxStopien.Anchor = AnchorStyles.None;
            comboBoxStopien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxStopien.FormattingEnabled = true;
            comboBoxStopien.Items.AddRange(new object[] { "I stopnia", "II stopnia" });
            comboBoxStopien.Location = new Point(313, 92);
            comboBoxStopien.Margin = new Padding(3, 4, 3, 4);
            comboBoxStopien.Name = "comboBoxStopien";
            comboBoxStopien.Size = new Size(270, 36);
            comboBoxStopien.TabIndex = 0;
            comboBoxStopien.SelectedIndexChanged += comboBoxStopien_SelectedIndexChanged;
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
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
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
        private Panel panel2;
        private Panel panel4;
        private Label label4;
        private Panel panel3;
        private Label label1;
    }
}
