namespace USOS_Rektora.userControls
{
    partial class Kalendarz
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
            iconButtonNast = new FontAwesome.Sharp.IconButton();
            iconButtonPop = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            miesiac = new Label();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            niedz = new Label();
            sob = new Label();
            pia = new Label();
            czw = new Label();
            sr = new Label();
            wt = new Label();
            pon = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // iconButtonNast
            // 
            iconButtonNast.Anchor = AnchorStyles.None;
            iconButtonNast.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            iconButtonNast.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            iconButtonNast.IconColor = Color.Black;
            iconButtonNast.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonNast.IconSize = 30;
            iconButtonNast.ImageAlign = ContentAlignment.MiddleRight;
            iconButtonNast.Location = new Point(394, 6);
            iconButtonNast.Name = "iconButtonNast";
            iconButtonNast.Size = new Size(96, 35);
            iconButtonNast.TabIndex = 1;
            iconButtonNast.Text = "Następny";
            iconButtonNast.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonNast.UseVisualStyleBackColor = true;
            iconButtonNast.Click += iconButtonNast_Click;
            // 
            // iconButtonPop
            // 
            iconButtonPop.Anchor = AnchorStyles.None;
            iconButtonPop.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            iconButtonPop.IconColor = Color.Black;
            iconButtonPop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonPop.IconSize = 30;
            iconButtonPop.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonPop.Location = new Point(292, 6);
            iconButtonPop.Name = "iconButtonPop";
            iconButtonPop.Size = new Size(96, 35);
            iconButtonPop.TabIndex = 2;
            iconButtonPop.Text = "Poprzedni";
            iconButtonPop.TextAlign = ContentAlignment.MiddleRight;
            iconButtonPop.UseVisualStyleBackColor = true;
            iconButtonPop.Click += iconButtonPop_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(miesiac);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 38);
            panel1.TabIndex = 3;
            // 
            // miesiac
            // 
            miesiac.BackColor = Color.Gray;
            miesiac.Dock = DockStyle.Fill;
            miesiac.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            miesiac.ForeColor = Color.White;
            miesiac.Location = new Point(0, 0);
            miesiac.Margin = new Padding(0);
            miesiac.Name = "miesiac";
            miesiac.Size = new Size(784, 38);
            miesiac.TabIndex = 4;
            miesiac.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 275);
            panel2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857113F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857113F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(niedz, 6, 0);
            tableLayoutPanel1.Controls.Add(sob, 5, 0);
            tableLayoutPanel1.Controls.Add(pia, 4, 0);
            tableLayoutPanel1.Controls.Add(czw, 3, 0);
            tableLayoutPanel1.Controls.Add(sr, 2, 0);
            tableLayoutPanel1.Controls.Add(wt, 1, 0);
            tableLayoutPanel1.Controls.Add(pon, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.Size = new Size(784, 275);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // niedz
            // 
            niedz.AutoSize = true;
            niedz.BackColor = Color.Gray;
            niedz.Dock = DockStyle.Fill;
            niedz.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            niedz.ForeColor = Color.White;
            niedz.Location = new Point(671, 0);
            niedz.Margin = new Padding(0);
            niedz.Name = "niedz";
            niedz.Size = new Size(113, 45);
            niedz.TabIndex = 6;
            niedz.Text = "Niedziela";
            niedz.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sob
            // 
            sob.AutoSize = true;
            sob.BackColor = Color.Gray;
            sob.Dock = DockStyle.Fill;
            sob.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            sob.ForeColor = Color.White;
            sob.Location = new Point(559, 0);
            sob.Margin = new Padding(0);
            sob.Name = "sob";
            sob.Size = new Size(112, 45);
            sob.TabIndex = 5;
            sob.Text = "Sobota";
            sob.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pia
            // 
            pia.AutoSize = true;
            pia.BackColor = Color.Gray;
            pia.Dock = DockStyle.Fill;
            pia.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            pia.ForeColor = Color.White;
            pia.Location = new Point(447, 0);
            pia.Margin = new Padding(0);
            pia.Name = "pia";
            pia.Size = new Size(112, 45);
            pia.TabIndex = 4;
            pia.Text = "Piątek";
            pia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // czw
            // 
            czw.AutoSize = true;
            czw.BackColor = Color.Gray;
            czw.Dock = DockStyle.Fill;
            czw.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            czw.ForeColor = Color.White;
            czw.Location = new Point(335, 0);
            czw.Margin = new Padding(0);
            czw.Name = "czw";
            czw.Size = new Size(112, 45);
            czw.TabIndex = 3;
            czw.Text = "Czwartek";
            czw.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sr
            // 
            sr.AutoSize = true;
            sr.BackColor = Color.Gray;
            sr.Dock = DockStyle.Fill;
            sr.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            sr.ForeColor = Color.White;
            sr.Location = new Point(223, 0);
            sr.Margin = new Padding(0);
            sr.Name = "sr";
            sr.Size = new Size(112, 45);
            sr.TabIndex = 2;
            sr.Text = "Środa";
            sr.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // wt
            // 
            wt.AutoSize = true;
            wt.BackColor = Color.Gray;
            wt.Dock = DockStyle.Fill;
            wt.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            wt.ForeColor = Color.White;
            wt.Location = new Point(111, 0);
            wt.Margin = new Padding(0);
            wt.Name = "wt";
            wt.Size = new Size(112, 45);
            wt.TabIndex = 1;
            wt.Text = "Wtorek";
            wt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pon
            // 
            pon.AutoSize = true;
            pon.BackColor = Color.Gray;
            pon.Dock = DockStyle.Fill;
            pon.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            pon.ForeColor = Color.White;
            pon.Location = new Point(0, 0);
            pon.Margin = new Padding(0);
            pon.Name = "pon";
            pon.Size = new Size(111, 45);
            pon.TabIndex = 0;
            pon.Text = "Poniedziałek";
            pon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(iconButtonNast);
            panel3.Controls.Add(iconButtonPop);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 313);
            panel3.Name = "panel3";
            panel3.Size = new Size(784, 49);
            panel3.TabIndex = 5;
            // 
            // Kalendarz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Kalendarz";
            Size = new Size(784, 362);
            Load += Kalendarz_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButtonNast;
        private FontAwesome.Sharp.IconButton iconButtonPop;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label niedz;
        private Label sob;
        private Label pia;
        private Label czw;
        private Label sr;
        private Label wt;
        private Label pon;
        private Label miesiac;
    }
}
