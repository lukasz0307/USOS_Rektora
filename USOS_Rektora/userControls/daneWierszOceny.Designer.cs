namespace USOS_Rektora.userControls
{
    partial class daneWierszOceny
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
            srednia = new Label();
            cyfrowa = new Label();
            elektronika = new Label();
            fizyka = new Label();
            matma = new Label();
            indeks = new Label();
            checkBox1 = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(srednia);
            panel1.Controls.Add(cyfrowa);
            panel1.Controls.Add(elektronika);
            panel1.Controls.Add(fizyka);
            panel1.Controls.Add(matma);
            panel1.Controls.Add(indeks);
            panel1.Controls.Add(checkBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 60);
            panel1.TabIndex = 0;
            // 
            // srednia
            // 
            srednia.BackColor = Color.Silver;
            srednia.BorderStyle = BorderStyle.FixedSingle;
            srednia.Dock = DockStyle.Left;
            srednia.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            srednia.Location = new Point(742, 0);
            srednia.Margin = new Padding(0);
            srednia.Name = "srednia";
            srednia.Size = new Size(154, 60);
            srednia.TabIndex = 9;
            srednia.Text = "srednia";
            srednia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cyfrowa
            // 
            cyfrowa.BackColor = Color.Silver;
            cyfrowa.BorderStyle = BorderStyle.FixedSingle;
            cyfrowa.Dock = DockStyle.Left;
            cyfrowa.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cyfrowa.Location = new Point(573, 0);
            cyfrowa.Margin = new Padding(0);
            cyfrowa.Name = "cyfrowa";
            cyfrowa.Size = new Size(169, 60);
            cyfrowa.TabIndex = 8;
            cyfrowa.Text = "technika cyfrowa";
            cyfrowa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // elektronika
            // 
            elektronika.BackColor = Color.Silver;
            elektronika.BorderStyle = BorderStyle.FixedSingle;
            elektronika.Dock = DockStyle.Left;
            elektronika.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            elektronika.Location = new Point(454, 0);
            elektronika.Margin = new Padding(0);
            elektronika.Name = "elektronika";
            elektronika.Size = new Size(119, 60);
            elektronika.TabIndex = 7;
            elektronika.Text = "elektronika";
            elektronika.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fizyka
            // 
            fizyka.BackColor = Color.Silver;
            fizyka.BorderStyle = BorderStyle.FixedSingle;
            fizyka.Dock = DockStyle.Left;
            fizyka.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            fizyka.Location = new Point(351, 0);
            fizyka.Margin = new Padding(0);
            fizyka.Name = "fizyka";
            fizyka.Size = new Size(103, 60);
            fizyka.TabIndex = 6;
            fizyka.Text = "fizyka";
            fizyka.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // matma
            // 
            matma.BackColor = Color.Silver;
            matma.BorderStyle = BorderStyle.FixedSingle;
            matma.Dock = DockStyle.Left;
            matma.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            matma.Location = new Point(226, 0);
            matma.Margin = new Padding(0);
            matma.Name = "matma";
            matma.Size = new Size(125, 60);
            matma.TabIndex = 5;
            matma.Text = "Matematyka";
            matma.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // indeks
            // 
            indeks.BackColor = Color.Silver;
            indeks.BorderStyle = BorderStyle.FixedSingle;
            indeks.Dock = DockStyle.Left;
            indeks.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            indeks.Location = new Point(57, 0);
            indeks.Margin = new Padding(0);
            indeks.Name = "indeks";
            indeks.Size = new Size(169, 60);
            indeks.TabIndex = 4;
            indeks.Text = "Nr. indeksu";
            indeks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            checkBox1.CheckAlign = ContentAlignment.MiddleCenter;
            checkBox1.Dock = DockStyle.Left;
            checkBox1.ForeColor = Color.Silver;
            checkBox1.Location = new Point(0, 0);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(57, 60);
            checkBox1.TabIndex = 0;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // daneWierszOceny
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(0);
            Name = "daneWierszOceny";
            Size = new Size(896, 60);
            Load += daneWierszOceny_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox checkBox1;
        private Label indeks;
        private Label matma;
        private Label fizyka;
        private Label elektronika;
        private Label cyfrowa;
        private Label srednia;
    }
}
