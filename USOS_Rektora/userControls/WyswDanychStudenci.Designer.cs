namespace USOS_Rektora.userControls
{
    partial class WyswDanychStudenci
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
            panelFiltrowanie = new Panel();
            panelChowaj = new Panel();
            buttonSzukaj = new Button();
            filtr2 = new ComboBox();
            baner = new Label();
            textBox1 = new TextBox();
            filtr1 = new ComboBox();
            iconButtonRozwijanie = new FontAwesome.Sharp.IconButton();
            panelDane = new Panel();
            tableDane = new TableLayoutPanel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            panelFiltrowanie.SuspendLayout();
            panelChowaj.SuspendLayout();
            panelDane.SuspendLayout();
            tableDane.SuspendLayout();
            SuspendLayout();
            // 
            // panelFiltrowanie
            // 
            panelFiltrowanie.BackColor = Color.Silver;
            panelFiltrowanie.Controls.Add(panelChowaj);
            panelFiltrowanie.Controls.Add(iconButtonRozwijanie);
            panelFiltrowanie.Dock = DockStyle.Left;
            panelFiltrowanie.Location = new Point(0, 0);
            panelFiltrowanie.Name = "panelFiltrowanie";
            panelFiltrowanie.Size = new Size(184, 482);
            panelFiltrowanie.TabIndex = 1;
            // 
            // panelChowaj
            // 
            panelChowaj.BackColor = Color.Silver;
            panelChowaj.Controls.Add(buttonSzukaj);
            panelChowaj.Controls.Add(filtr2);
            panelChowaj.Controls.Add(baner);
            panelChowaj.Controls.Add(textBox1);
            panelChowaj.Controls.Add(filtr1);
            panelChowaj.Location = new Point(14, 62);
            panelChowaj.Name = "panelChowaj";
            panelChowaj.Size = new Size(151, 397);
            panelChowaj.TabIndex = 8;
            // 
            // buttonSzukaj
            // 
            buttonSzukaj.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSzukaj.Location = new Point(0, 206);
            buttonSzukaj.Name = "buttonSzukaj";
            buttonSzukaj.Size = new Size(151, 38);
            buttonSzukaj.TabIndex = 7;
            buttonSzukaj.Text = "Szukaj";
            buttonSzukaj.TextAlign = ContentAlignment.TopCenter;
            buttonSzukaj.UseVisualStyleBackColor = true;
            // 
            // filtr2
            // 
            filtr2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            filtr2.FormattingEnabled = true;
            filtr2.Items.AddRange(new object[] { "równego", "zaczynającego się na" });
            filtr2.Location = new Point(0, 91);
            filtr2.Name = "filtr2";
            filtr2.Size = new Size(151, 36);
            filtr2.TabIndex = 5;
            // 
            // baner
            // 
            baner.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            baner.ForeColor = Color.White;
            baner.Location = new Point(0, 0);
            baner.Name = "baner";
            baner.Size = new Size(151, 30);
            baner.TabIndex = 3;
            baner.Text = "Dla";
            baner.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(0, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 34);
            textBox1.TabIndex = 6;
            // 
            // filtr1
            // 
            filtr1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            filtr1.FormattingEnabled = true;
            filtr1.Items.AddRange(new object[] { "imiona", "nazwiska", "stanowiska", "adresu" });
            filtr1.Location = new Point(0, 33);
            filtr1.Name = "filtr1";
            filtr1.Size = new Size(151, 36);
            filtr1.TabIndex = 2;
            // 
            // iconButtonRozwijanie
            // 
            iconButtonRozwijanie.BackColor = Color.Silver;
            iconButtonRozwijanie.Dock = DockStyle.Top;
            iconButtonRozwijanie.FlatStyle = FlatStyle.Flat;
            iconButtonRozwijanie.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonRozwijanie.ForeColor = Color.White;
            iconButtonRozwijanie.IconChar = FontAwesome.Sharp.IconChar.CircleArrowRight;
            iconButtonRozwijanie.IconColor = Color.White;
            iconButtonRozwijanie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonRozwijanie.IconSize = 40;
            iconButtonRozwijanie.ImageAlign = ContentAlignment.MiddleRight;
            iconButtonRozwijanie.Location = new Point(0, 0);
            iconButtonRozwijanie.Name = "iconButtonRozwijanie";
            iconButtonRozwijanie.Rotation = 180D;
            iconButtonRozwijanie.Size = new Size(184, 51);
            iconButtonRozwijanie.TabIndex = 4;
            iconButtonRozwijanie.Text = "Filtrowanie";
            iconButtonRozwijanie.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonRozwijanie.UseVisualStyleBackColor = false;
            iconButtonRozwijanie.Click += iconButtonRozwijanie_Click;
            // 
            // panelDane
            // 
            panelDane.AutoSize = true;
            panelDane.BackColor = Color.FromArgb(224, 224, 224);
            panelDane.Controls.Add(tableDane);
            panelDane.Dock = DockStyle.Fill;
            panelDane.Location = new Point(184, 0);
            panelDane.Name = "panelDane";
            panelDane.Size = new Size(712, 482);
            panelDane.TabIndex = 2;
            // 
            // tableDane
            // 
            tableDane.AutoScroll = true;
            tableDane.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableDane.ColumnCount = 8;
            tableDane.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.910938F));
            tableDane.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.2207966F));
            tableDane.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.2207966F));
            tableDane.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.2171488F));
            tableDane.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.2207985F));
            tableDane.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.2207966F));
            tableDane.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.2207966F));
            tableDane.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.7679319F));
            tableDane.Controls.Add(label7, 0, 0);
            tableDane.Controls.Add(label6, 6, 0);
            tableDane.Controls.Add(label5, 5, 0);
            tableDane.Controls.Add(label4, 4, 0);
            tableDane.Controls.Add(label3, 3, 0);
            tableDane.Controls.Add(label2, 2, 0);
            tableDane.Controls.Add(label1, 1, 0);
            tableDane.Controls.Add(label8, 7, 0);
            tableDane.Dock = DockStyle.Fill;
            tableDane.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            tableDane.Location = new Point(0, 0);
            tableDane.Name = "tableDane";
            tableDane.RowCount = 1;
            tableDane.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableDane.Size = new Size(712, 482);
            tableDane.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Silver;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1, 1);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(41, 480);
            label7.TabIndex = 7;
            label7.Text = "ID";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Silver;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(508, 1);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(92, 480);
            label6.TabIndex = 5;
            label6.Text = "Nr. telefonu";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Silver;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(415, 1);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(92, 480);
            label5.TabIndex = 4;
            label5.Text = "Miasto";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Silver;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(322, 1);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(92, 480);
            label4.TabIndex = 3;
            label4.Text = "Adres";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(229, 1);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(92, 480);
            label3.TabIndex = 2;
            label3.Text = "Stanowisko";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(136, 1);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(92, 480);
            label2.TabIndex = 1;
            label2.Text = "Nazwisko";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 1);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(92, 480);
            label1.TabIndex = 6;
            label1.Text = "Imię";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Silver;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 9.7F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(604, 1);
            label8.Name = "label8";
            label8.Size = new Size(104, 480);
            label8.TabIndex = 8;
            label8.Text = "Adres e-mail";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WyswDanychStudenci
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelDane);
            Controls.Add(panelFiltrowanie);
            Name = "WyswDanychStudenci";
            Size = new Size(896, 482);
            panelFiltrowanie.ResumeLayout(false);
            panelChowaj.ResumeLayout(false);
            panelChowaj.PerformLayout();
            panelDane.ResumeLayout(false);
            tableDane.ResumeLayout(false);
            tableDane.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelFiltrowanie;
        private Panel panelChowaj;
        private Button buttonSzukaj;
        private ComboBox filtr2;
        private Label baner;
        private TextBox textBox1;
        private ComboBox filtr1;
        private FontAwesome.Sharp.IconButton iconButtonRozwijanie;
        private Panel panelDane;
        private TableLayoutPanel tableDane;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
    }
}
