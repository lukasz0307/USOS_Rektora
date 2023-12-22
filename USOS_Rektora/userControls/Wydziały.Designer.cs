namespace USOS_Rektora.userControls
{
    partial class Wydziały
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
            listBoxKierunki = new ListBox();
            panelKierunki = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panelOWydz = new Panel();
            labelOWydziale = new Label();
            panel4 = new Panel();
            label4 = new Label();
            panelStudenci = new Panel();
            listBoxStud = new ListBox();
            panelKierunki.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelOWydz.SuspendLayout();
            panel4.SuspendLayout();
            panelStudenci.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxKierunki
            // 
            listBoxKierunki.BackColor = Color.Silver;
            listBoxKierunki.BorderStyle = BorderStyle.None;
            listBoxKierunki.Dock = DockStyle.Bottom;
            listBoxKierunki.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxKierunki.FormattingEnabled = true;
            listBoxKierunki.ItemHeight = 31;
            listBoxKierunki.Items.AddRange(new object[] { "Informatyka" });
            listBoxKierunki.Location = new Point(0, 108);
            listBoxKierunki.Margin = new Padding(0);
            listBoxKierunki.Name = "listBoxKierunki";
            listBoxKierunki.Size = new Size(180, 372);
            listBoxKierunki.TabIndex = 0;
            // 
            // panelKierunki
            // 
            panelKierunki.BackColor = Color.Silver;
            panelKierunki.BorderStyle = BorderStyle.FixedSingle;
            panelKierunki.Controls.Add(panel1);
            panelKierunki.Controls.Add(listBoxKierunki);
            panelKierunki.Dock = DockStyle.Left;
            panelKierunki.Location = new Point(0, 0);
            panelKierunki.Margin = new Padding(0);
            panelKierunki.Name = "panelKierunki";
            panelKierunki.Size = new Size(182, 482);
            panelKierunki.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 86);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.Gray;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(180, 86);
            label1.TabIndex = 0;
            label1.Text = "Lista kierunków";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(392, 86);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.Gray;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(392, 86);
            label2.TabIndex = 1;
            label2.Text = "O wydziale";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelOWydz
            // 
            panelOWydz.BackColor = Color.Silver;
            panelOWydz.BorderStyle = BorderStyle.FixedSingle;
            panelOWydz.Controls.Add(labelOWydziale);
            panelOWydz.Controls.Add(panel2);
            panelOWydz.Dock = DockStyle.Left;
            panelOWydz.Location = new Point(182, 0);
            panelOWydz.Margin = new Padding(0);
            panelOWydz.Name = "panelOWydz";
            panelOWydz.Size = new Size(394, 482);
            panelOWydz.TabIndex = 2;
            // 
            // labelOWydziale
            // 
            labelOWydziale.Dock = DockStyle.Top;
            labelOWydziale.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelOWydziale.Location = new Point(0, 86);
            labelOWydziale.Margin = new Padding(0);
            labelOWydziale.Name = "labelOWydziale";
            labelOWydziale.Size = new Size(392, 396);
            labelOWydziale.TabIndex = 1;
            labelOWydziale.Text = "o wyd";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gray;
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(318, 86);
            panel4.TabIndex = 0;
            // 
            // label4
            // 
            label4.BackColor = Color.Gray;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(318, 86);
            label4.TabIndex = 1;
            label4.Text = "Lista studentów";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelStudenci
            // 
            panelStudenci.BackColor = Color.Silver;
            panelStudenci.BorderStyle = BorderStyle.FixedSingle;
            panelStudenci.Controls.Add(listBoxStud);
            panelStudenci.Controls.Add(panel4);
            panelStudenci.Dock = DockStyle.Left;
            panelStudenci.Location = new Point(576, 0);
            panelStudenci.Margin = new Padding(0);
            panelStudenci.Name = "panelStudenci";
            panelStudenci.Size = new Size(320, 482);
            panelStudenci.TabIndex = 3;
            // 
            // listBoxStud
            // 
            listBoxStud.BackColor = Color.Silver;
            listBoxStud.BorderStyle = BorderStyle.None;
            listBoxStud.Dock = DockStyle.Bottom;
            listBoxStud.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxStud.FormattingEnabled = true;
            listBoxStud.ItemHeight = 31;
            listBoxStud.Items.AddRange(new object[] { "Informatyka" });
            listBoxStud.Location = new Point(0, 108);
            listBoxStud.Margin = new Padding(0);
            listBoxStud.Name = "listBoxStud";
            listBoxStud.Size = new Size(318, 372);
            listBoxStud.TabIndex = 1;
            // 
            // Wydziały
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelStudenci);
            Controls.Add(panelOWydz);
            Controls.Add(panelKierunki);
            Name = "Wydziały";
            Size = new Size(896, 482);
            Load += Wydziały_Load;
            panelKierunki.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panelOWydz.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panelStudenci.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxKierunki;
        private Panel panelKierunki;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panelOWydz;
        private Label labelOWydziale;
        private Panel panel4;
        private Label label4;
        private Panel panelStudenci;
        private ListBox listBoxStud;
    }
}
